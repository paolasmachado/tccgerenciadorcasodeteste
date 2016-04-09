using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_ListagemHistoriaDeUsuario : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=admin; database=bancotcc;";

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["nome"] != null)
        {
           // LabelBoasVindas.Text = "Bem - Vindo(a)  " + (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

        //////////////////////////////////////////////////////////////////////////

       



    }

    protected void BotaoAdicionarHistoriaDeUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("HistoriaDeUsuario.aspx");
    }


    protected void BotaoPesquisar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        DataSet dados = new DataSet();
        MySqlDataAdapter Comando = new MySqlDataAdapter("SELECT * FROM historiadeusuario WHERE ; ", Conexao);
        //Comando.Parameters.AddWithValue("@Prioridade", CampoSearch.Text);
        //Comando.Fill(dados);
        //Tabela.DataSource = dados;
        //Tabela.DataBind();

    }

}