using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Paginas_Projeto : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=admin; database=bancotcc;";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
          //  LabelBoasVindas.Text = "Bem - Vindo(a)  " + (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {

    }

    protected void CriarProjeto() {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();

        string SQLComando = "INSERT INTO projeto(titulo, datainicio, datafim, descricao, empresa) VALUES "
                        + "(@Titulo, @DataInicio, @DataFim, @Descricao, @Empresa)";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Titulo", CampoTitulo.Text.ToString());
        Comando.Parameters.AddWithValue("@DataInicio", CampoDataInicio.Text.ToString());
        Comando.Parameters.AddWithValue("@DataFim", CampoDataFinal.Text);
        Comando.Parameters.AddWithValue("@Descricao", CampoDescricao.Text);
        Comando.Parameters.AddWithValue("@Empresa", CampoEmpresa.Text);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    protected void AlterarProjeto(string Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando;

        string SQLComando = "UPDATE Cliente SET titulo = @Titulo, datainicio = @DataInicio, Datafim = @Datafim, descricao = @Descricao,"
            + " empresa = @Empresa WHERE idprojeto = @Idprojeto";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Idprojeto", Codigo);
        Comando.Parameters.AddWithValue("@Titulo", CampoTitulo.Text.ToString());
        Comando.Parameters.AddWithValue("@DataInicio", CampoDataInicio.Text.ToString());
        Comando.Parameters.AddWithValue("@Datafim", CampoDataFinal.Text);
        Comando.Parameters.AddWithValue("@Descricao", CampoDescricao.Text);
        Comando.Parameters.AddWithValue("@Empresa", CampoEmpresa.Text);
        Comando.ExecuteNonQuery();
    }

    protected void ExcluirProjeto()
    {
       
    }
}