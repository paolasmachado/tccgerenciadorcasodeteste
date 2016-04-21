using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_EstoriaDeUsuario : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";
    string idEstoriaDeUsuario;
    bool editarEstoria;

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
                this.ConsultarEstoriaDeUsuario(Request.QueryString["Codigo"]);
                idEstoriaDeUsuario = Request.QueryString["Codigo"];
                LabelTipo.Text = "Editar ";
                editarEstoria = true;
            }
        }

    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        if (editarEstoria)
        {
            EditarEstoriaDeUsuario(idEstoriaDeUsuario);
        }
        else
        {
            CriarEstoriaDeUsuario();
        }

        CampoTituloHistoria.Text = "";
        CampoPrioridade.Text = "";
        CampoPontos.Text = "";
        CampoDesejo.Text = "";
        CampoComo.Text = "";
        CampoAssim.Text = "";
    }

    protected void CriarEstoriaDeUsuario()
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();

        string SQLComando = "INSERT INTO estoriadeusuario(titulo, prioridade, pontos, como, desejo, assim) VALUES "
                        + "(@Titulo, @Prioridade, @Pontos, @Como, @Desejo, @Assim)";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Titulo", CampoTituloHistoria.Text);
        Comando.Parameters.AddWithValue("@Prioridade", CampoPrioridade.SelectedValue.ToString());
        Comando.Parameters.AddWithValue("@Pontos", CampoPontos.Text);
        Comando.Parameters.AddWithValue("@Como", CampoComo.Text);
        Comando.Parameters.AddWithValue("@Desejo", CampoDesejo.Text);
        Comando.Parameters.AddWithValue("@Assim", CampoAssim.Text);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void EditarEstoriaDeUsuario(string idEstoriaDeUsuario)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();
        string SQLComando = "UPDATE estoriadeusuario SET titulo = @Titulo, prioridade = @Prioridade, pontos = @Pontos," +
            " como = @Como, desejo = @Desejo , assim = @Assim WHERE idEstoriadeusuario = @IDEstoriaDeUsuario";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@IDEstoriaDeUsuario", idEstoriaDeUsuario);
        Comando.Parameters.AddWithValue("@Titulo", CampoTituloHistoria.Text);
        Comando.Parameters.AddWithValue("@Prioridade", CampoPrioridade.SelectedValue.ToString());
        Comando.Parameters.AddWithValue("@Pontos", CampoPontos.Text);
        Comando.Parameters.AddWithValue("@Como", CampoComo.Text);
        Comando.Parameters.AddWithValue("@Desejo", CampoDesejo.Text);
        Comando.Parameters.AddWithValue("@Assim", CampoAssim.Text);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }

    protected void ConsultarEstoriaDeUsuario(string idEstoriaDeUsuario)
    {


        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM estoriadeusuario WHERE idestoriadeusuario = @IDEstoriaDeUsuario;", Conexao);
        Comando.Parameters.AddWithValue("@IDEstoriaDeUsuario", idEstoriaDeUsuario);
        Conexao.Open();
        DataSet dados = new DataSet();
        MySqlDataReader Reader = Comando.ExecuteReader();
        if (Reader.Read())
        {
            CampoTituloHistoria.Text = Reader["titulo"].ToString();
            CampoPrioridade.SelectedValue = Reader["prioridade"].ToString();
            CampoPontos.Text = Reader["pontos"].ToString();
            CampoComo.Text = Reader["como"].ToString();
            CampoDesejo.Text = Reader["desejo"].ToString();
            CampoAssim.Text = Reader["assim"].ToString();
        }

        Conexao.Close();
    }


}