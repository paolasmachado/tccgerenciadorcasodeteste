using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_CriterioDeAceitacao : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";
    string idCriterioDeAceitacao;
    bool editarCriterioDeAceitacao;

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
                this.ConsultarCriterioDeAceitacao(Request.QueryString["Codigo"]);
                idCriterioDeAceitacao = Request.QueryString["Codigo"];
                LabelTipo.Text = "Editar ";
                editarCriterioDeAceitacao = true;
            }
        }

    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        if (editarCriterioDeAceitacao)
        {
            EditarEstoriaDeUsuario(idCriterioDeAceitacao);
        }
        else
        {
            CriarCriterioDeAceitacao();
        }

        CampoDescricao.Text = "";
    }

    protected void CriarCriterioDeAceitacao()
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();

        string SQLComando = "INSERT INTO criteriodeaceitacao(titulo, prioridade, pontos, como, desejo, assim) VALUES "
                        + "(@Titulo, @Prioridade, @Pontos, @Como, @Desejo, @Assim)";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Titulo", CampoDescricao.Text);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void EditarCriterioDeAceitacao(string Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();
        string SQLComando = "UPDATE criteriodeaceitacao SET descricao = @Descricao , idestoriadeusuario = @IDEstoriadeusuario WHERE idEstoriadeusuario = @Codigo";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", Codigo);
        Comando.Parameters.AddWithValue("@Descricao", CampoDescricao.Text);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void ConsultarCriterioDeAceitacao(string Codigo)
    {


        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM criteriodeaceitacao WHERE idcriteriodeaceitacao = @Codigo;", Conexao);
        Comando.Parameters.AddWithValue("@Codigo", Codigo);
        Conexao.Open();
        DataSet dados = new DataSet();
        MySqlDataReader Reader = Comando.ExecuteReader();
        if (Reader.Read())
        {
            CampoDescricao.Text = Reader["descricao"].ToString();
        }

        Conexao.Close();
    }


}