using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Paginas_UsuarioDoSistema : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=admin; database=bancotcc;";
    MySqlConnection Conexao;
    MySqlCommand Comando;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["nome"] != null)
        {
            LabelBoasVindas.Text = "Bem - Vindo(a)  " + (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void BotaoEnviar_Click(object sender, EventArgs e)
    {
        CriarUsuarioDoSistema();
   

    }

    protected void CriarUsuarioDoSistema() {

        Conexao = new MySqlConnection();
        Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();

        string SQLComando = "INSERT INTO usuariodosistema (nomeusuario, email, usuario, perfil, senha) VALUES "
                        + "( @Nome, @Email, @Usuario, @Perfil, @Senha)";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Nome", CampoNome.Text.ToString());
        Comando.Parameters.AddWithValue("@Email", CampoEmail.Text.ToString());
        Comando.Parameters.AddWithValue("@Usuario", CampoUsuario.Text);
        Comando.Parameters.AddWithValue("@Perfil", CampoPerfil.SelectedValue.ToString());
        Comando.Parameters.AddWithValue("@Senha", CampoSenha.Text);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

}