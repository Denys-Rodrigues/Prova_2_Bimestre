﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova
{
    public partial class Inserir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"insert into fornecedor
                                    (nome, sexo, dat_nasc, num_cart_trab, tel_fixo, tel_cel, 
                                     email, logradouro, numero, complemento, bairro, cidade, uf)
                                    values
                                    (@nome, @sexo, @dat_nasc, @num_cart_trab, @tel_fixo, @tel_cel, 
                                     @email, @logradouro, @numero, @complemento, @bairro, @cidade, @uf)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@sexo", ddlSexo.Text);
                cmd.Parameters.AddWithValue("@dat_nasc", txtNascimento.Text);
                cmd.Parameters.AddWithValue("@num_cart_trab", txtCarteiraTrabalho.Text);
                cmd.Parameters.AddWithValue("@tel_fixo", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@tel_cel", txtCelular.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@uf", txtUF.Text);

                Conexao.Conectar();

                cmd.ExecuteNonQuery();
                Response.Redirect("Listar.aspx");
            }
            catch (Exception ex)
            {
                lblResultado.CssClass = "text text-danger";
                lblResultado.Text = $"Error: {ex.Message}";
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}