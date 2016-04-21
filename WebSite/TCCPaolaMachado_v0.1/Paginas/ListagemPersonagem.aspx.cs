using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_ListagemPersonagem : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";

    public List<PersonagemClass> ListPersonagem = new List<PersonagemClass>();

    bool PesquisarPersonagemCodigo = false;

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
            PesquisaPersonagem();
            this.grdDados.DataSource = ListPersonagem;
            this.grdDados.DataBind();
        }
    }

    protected List<PersonagemClass> PesquisaPersonagem()
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM personagem;", Conexao);
        Conexao.Open();
        MySqlDataReader reader = Comando.ExecuteReader();
        while (reader.Read())
        {
            var Personagem = new PersonagemClass();
            Personagem.Codigo = Convert.ToInt32(reader["idpersonagem"].ToString());
            Personagem.Funcao = reader["funcao"].ToString();
            Personagem.Papel = reader["papel"].ToString();
            Personagem.Descricao = reader["descricao"].ToString();
            ListPersonagem.Add(Personagem);
        }
        return ListPersonagem;

    }


    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Excluir"))
        {
            string CodigoPersonagem = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(CodigoPersonagem))
                ExcluirPersonagem(CodigoPersonagem);
            // IMPLEMENTAR MENSAGEM DE CONFIRMAÇÃO 
            // IMPLEMENTAR ATUALIZAR A PÁGINA
        }

        if (e.CommandName.Equals("Editar"))
        {
            string CodigoPersonagem = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(CodigoPersonagem))
                this.Response.Redirect("Personagem.aspx?Codigo=" + CodigoPersonagem);
        }
    }

    public void ExcluirPersonagem(String Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();
        string SQLComando = "DELETE FROM personagem WHERE idpersonagem = @Codigo";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", Codigo);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void ButtonPesquisar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        String Query = "SELECT * FROM personagem  WHERE idpersonagem = @Codigo;";
        MySqlCommand Comando = new MySqlCommand(Query, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", CampoSearch.Text);
        Conexao.Open();

        MySqlDataReader reader = Comando.ExecuteReader();

        while (reader.Read())
        {
            var Personagem = new PersonagemClass();
            Personagem.Codigo = Convert.ToInt32(reader["idpersonagem"].ToString());
            Personagem.Papel = reader["papel"].ToString();
            Personagem.Funcao = reader["funcao"].ToString();
            Personagem.Descricao = reader["descricao"].ToString();
            ListPersonagem.Add(Personagem);
        }
        this.grdDados.DataSource = ListPersonagem;
        this.grdDados.DataBind();

    }



    protected void BotaoAdicionarPersonagem_Click(object sender, EventArgs e)
    {
        Response.Redirect("EstoriaDeUsuario.aspx");
    }
}