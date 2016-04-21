using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_Projeto : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";
    string idProjeto;
    bool editarProjeto;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            LabelBoasVindas.Text = (Session["nome"].ToString());
            LabelTipo.Text = "Criar ";
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            if (Request.QueryString["Codigo"] != null)
            {
                this.ConsultarProjeto(Request.QueryString["Codigo"]);
                idProjeto = Request.QueryString["Codigo"];
                LabelTipo.Text = "Editar ";
                editarProjeto = true;
            }
        }
    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        if (editarProjeto)
        {
            EditarProjeto(idProjeto);
        }
        else
        {
            CriarProjeto();

        }
        CampoTitulo.Text = "";
        CampoDescricao.Text = "";
        CampoEmpresa.Text = "";
        CampoDataInicio.Text = "";
        CampoDataFinal.Text = "";
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

    protected void EditarProjeto(string Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando;

        string SQLComando = "UPDATE projeto SET titulo = @Titulo, datainicio = @DataInicio, Datafim = @Datafim, descricao = @Descricao,"
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

    protected void ConsultarProjeto(string idProjeto)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM projeto WHERE idprojeto = @IDProjeto;", Conexao);
        Comando.Parameters.AddWithValue("@IDProjeto", idProjeto);
        Conexao.Open();
        DataSet dados = new DataSet();
        MySqlDataReader Reader = Comando.ExecuteReader();
        if (Reader.Read())
        {
            CampoTitulo.Text = Reader["titulo"].ToString();
            CampoDescricao.Text = Reader["descricao"].ToString();
            CampoEmpresa.Text = Reader["empresa"].ToString();
            CampoDataInicio.Text = Reader["datainicio"].ToString();
            CampoDataFinal.Text = Reader["datafim"].ToString();
        }

        Conexao.Close();
    }

    protected void ButtonCriarPersonagem_Click(object sender, EventArgs e)
    {
        Response.Redirect("Personagem.aspx");
    }
}