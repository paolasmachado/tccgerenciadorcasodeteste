using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_ListagemProjeto : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";

    public List<ProjetoClass> ListProjeto = new List<ProjetoClass>();

    bool PesquisarProjetoCodigo = false;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["nome"] != null)
        {
            LabelBoasVindas.Text = (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        if (!Page.IsPostBack)
        {
            PesquisarProjeto();
            this.grdDados.DataSource = ListProjeto;
            this.grdDados.DataBind();
        }
    }

    protected List<ProjetoClass> PesquisarProjeto()
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM projeto;", Conexao);
        Conexao.Open();
        MySqlDataReader reader = Comando.ExecuteReader();
        while (reader.Read())
        {
            var Projeto = new ProjetoClass();
            Projeto.Codigo = Convert.ToInt32(reader["idprojeto"].ToString());
            Projeto.Titulo = reader["titulo"].ToString();
            Projeto.Descricao = reader["descricao"].ToString();
            Projeto.Empresa = reader["empresa"].ToString();
            ListProjeto.Add(Projeto);
        }
        return ListProjeto;

    }


    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            string CodigoProjeto = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(CodigoProjeto))
                ExcluirProjeto(CodigoProjeto);
            // IMPLEMENTAR MENSAGEM DE CONFIRMAÇÃO 
            // IMPLEMENTAR ATUALIZAR A PÁGINA
        }

        if (e.CommandName.Equals("Editar"))
        {
            string CodigoProjeto = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(CodigoProjeto))
                this.Response.Redirect("Projeto.aspx?Codigo=" + CodigoProjeto);
        }
    }

    public void ExcluirProjeto(String Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();
        string SQLComando = "DELETE FROM projeto WHERE idprojeto = @Codigo";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", Codigo);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void BotaoAdicionarProjeto_Click(object sender, EventArgs e)
    {
        Response.Redirect("Projeto.aspx");

    }
    protected void ButtonPesquisar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        String Query = "SELECT * FROM projeto  WHERE idprojeto = @Codigo;";
        MySqlCommand Comando = new MySqlCommand(Query, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", CampoSearch.Text);
        Conexao.Open();

        MySqlDataReader reader = Comando.ExecuteReader();

        while (reader.Read())
        {
            var Projeto = new ProjetoClass();
            Projeto.Codigo = Convert.ToInt32(reader["idprojeto"].ToString());
            Projeto.Titulo = reader["titulo"].ToString();
            Projeto.Descricao = reader["descricao"].ToString();
            Projeto.Empresa = reader["empresa"].ToString();
            ListProjeto.Add(Projeto);
        }
        this.grdDados.DataSource = ListProjeto;
        this.grdDados.DataBind();

    }

    
}