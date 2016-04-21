using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Login : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";
    string Nome;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BotaoEnviar_Click(object sender, EventArgs e)
    {
        string ResultadoLogin = ConsultarUsuario();
        if (!ResultadoLogin.Equals("Não encontrado"))
        {
            Session["nome"] = Nome;

            Response.Redirect("Index.aspx");
        }
        else
        {
            LabelMensagem.Text = "Usuário e senha incorretos";
        }
    }

    protected string ConsultarUsuario()
    {

        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuariodosistema WHERE email = @Email and senha = @Senha;", Conexao);
        Comando.Parameters.AddWithValue("@Email", CampoEmail.Text);
        Comando.Parameters.AddWithValue("@Senha", CampoSenha.Text);
        Conexao.Open();
        MySqlDataReader reader = Comando.ExecuteReader();
        if (reader.Read())
        {
            string Email = reader["email"].ToString();
            string Senha = reader["senha"].ToString();
            if ((CampoEmail.Text.Equals(Email)) && (CampoSenha.Text.Equals(Senha)))
            {
                Nome = reader["nome"].ToString();
            }
            else
            {
                Nome = "Não encontrado";
            }
        }
        else {
            Nome = "Não encontrado";
        }
        Conexao.Close();

        return Nome;
    }
}