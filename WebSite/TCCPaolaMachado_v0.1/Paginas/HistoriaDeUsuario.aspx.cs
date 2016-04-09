using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_CadastroHistoriaDeUsuario : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=admin; database=bancotcc;";

    protected void Page_Load(object sender, EventArgs e)
    {
       if (Session["nome"] != null)
        {
       //     LabelBoasVindas.Text = "Bem - Vindo(a)  " + (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
       
    }
    protected void ButtonCriterioDeAceitacao_Click(object sender, EventArgs e)
    {

    }
    
    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();

        string SQLComando = "INSERT INTO historiadeusuario(titulo, prioridade, pontos, como, desejo, assim) VALUES "
                        + "(@Titulo, @Prioridade, @Pontos, @Como, @Desejo, @Assim)";
        Comando.Parameters.AddWithValue("@Prioridade", CampoPrioridade.SelectedValue.ToString());
        Comando.Parameters.AddWithValue("@Pontos", CampoPontos.Text);
        Comando.Parameters.AddWithValue("@Como", CampoComo);
        Comando.Parameters.AddWithValue("@Desejo", CampoDesejo.Text);
        Comando.Parameters.AddWithValue("@Assim", CampoAssim.Text);
        Comando.ExecuteNonQuery();

        Conexao.Close();
        LabelSucesso.Text = "Dados salvo com sucesso";
    }

    protected void ConsultarHistoriaDeUsuario(string idHistoriaDeUsuario)
    {


        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        MySqlCommand Comando = new MySqlCommand("SELECT * FROM historiadeusuario WHERE idhistoriadeusuario = @IDHistoriaDeUsuario;", Conexao);
        Comando.Parameters.AddWithValue("@IDHistoriaDeUsuario", idHistoriaDeUsuario);
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