using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Login : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=admin; database=bancotcc;";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BotaoEnviar_Click(object sender, EventArgs e)
    {
       // bool ResultadoLogin = ConsultarUsuario();
        //if (ResultadoLogin)
        //{
            Session["nome"] = CampoUsuario.Text;

            Response.Redirect("Index.aspx");
       // }
       // else {
           // LabelResultado.Text = "Usuário e senha incorretos";
       // }
    }

    protected bool ConsultarUsuario()
    {

        bool ResultadoUsuario = false;

        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuariodosistema WHERE email = @Email and senha = @Senha;", Conexao);
        Comando.Parameters.AddWithValue("@Email", CampoUsuario.Text);
        Comando.Parameters.AddWithValue("@Senha", CampoSenha.Text);
        Conexao.Open();
        MySqlDataReader reader = Comando.ExecuteReader();
        if (reader.Read())
        {
            string Email = reader["email"].ToString();
            string Senha = reader["senha"].ToString();
            if ((CampoUsuario.Text.Equals(Email)) && (CampoSenha.Text.Equals(Senha)))
            {
                ResultadoUsuario = true;
            }
            else
            {
                ResultadoUsuario = false;
            }
        }
        Conexao.Close();

        return ResultadoUsuario;
    }
}