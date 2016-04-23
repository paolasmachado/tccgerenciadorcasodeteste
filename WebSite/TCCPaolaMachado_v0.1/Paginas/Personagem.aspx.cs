using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_Personagem : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";
    string idPersonagem;
    bool editarPersonagem;

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
                this.ConsultarPersonagem(Request.QueryString["Codigo"]);
                idPersonagem = Request.QueryString["Codigo"];
                LabelTipo.Text = "Editar ";
                editarPersonagem = true;
            }
        }
    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        if (editarPersonagem)
        {
            EditarPersonagem(idPersonagem);
        }
        else
        {
            CriarPersonagem();

        }
        CampoPapel.Text = "";
        CampoFuncao.Text = "";
        CampoDescricao.Text = "";
    }

    protected void CriarPersonagem() {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();     

        string SQLComando = "INSERT INTO personagem(papel, funcao, descricao) VALUES "
                        + "(@Papel, @Funcao, @Descricao)";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Papel", CampoPapel.Text);
        Comando.Parameters.AddWithValue("@Funcao", CampoFuncao.Text);
        Comando.Parameters.AddWithValue("@Descricao", CampoDescricao.Text);
        Comando.ExecuteNonQuery();

        Conexao.Close();
    }

    protected void EditarPersonagem(string Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando;

        string SQLComando = "UPDATE personagem SET papel = @Papel, funcao = @Funcao, descricao = @Descricao,"+
            " idestoriadeusuario = @IDEstoriadeusuario, idprojeto = @IDProjeto WHERE idpersonagem = @IDPersonagem";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@IDPersonagem", Codigo);
        Comando.Parameters.AddWithValue("@Papel", CampoPapel.Text.ToString());
        Comando.Parameters.AddWithValue("@Funcao", CampoFuncao.Text.ToString());
        Comando.Parameters.AddWithValue("@Descricao", CampoDescricao.Text);
        Comando.Parameters.AddWithValue("@IDEstoriadeusuario","");
        Comando.Parameters.AddWithValue("@IDProjeto", "");
        Comando.ExecuteNonQuery();
    }

    protected void ConsultarPersonagem(string idPersonagem)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM personagem WHERE idpersonagem = @IDPersonagem;", Conexao);
        Comando.Parameters.AddWithValue("@IDPersonagem", idPersonagem);
        Conexao.Open();
        DataSet dados = new DataSet();
        MySqlDataReader Reader = Comando.ExecuteReader();
        if (Reader.Read())
        {
            CampoPapel.Text = Reader["papel"].ToString();
            CampoFuncao.Text = Reader["funcao"].ToString();
            CampoDescricao.Text = Reader["descricao"].ToString();
        }

        Conexao.Close();
    }


    protected void ButtonEstoriaDeUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("EstoriaDeUsuario.aspx");
    }
}