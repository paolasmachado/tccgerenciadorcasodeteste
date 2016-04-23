using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class Paginas_ListagemEstoriaDeUsuario : System.Web.UI.Page
{
    string StringConexao = "server=127.0.0.1; User Id=root; password=1234; database=bancotcc;";

    public List<EstoriaDeUsuarioClass> ListEstoria = new List<EstoriaDeUsuarioClass>();

    bool PesquisarEstoriaCodigo = false;

    string CodigoURL;

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

        CodigoURL = Request.Url.Query;
        string[] URL = CodigoURL.Split('=');
        CodigoURL = URL[1];

        if (!Page.IsPostBack)
        {
            PesquisarEstoriasDeUsuario();
            this.grdDados.DataSource = ListEstoria;
            this.grdDados.DataBind();
        }
    }

    protected List<EstoriaDeUsuarioClass> PesquisarEstoriasDeUsuario()
    {
            MySqlConnection Conexao = new MySqlConnection(StringConexao);
            MySqlCommand Comando = new MySqlCommand("SELECT * FROM estoriadeusuario;", Conexao);
            Conexao.Open();
            MySqlDataReader reader = Comando.ExecuteReader();
            while (reader.Read())
            {
                var EstoriaDeUsuario = new EstoriaDeUsuarioClass();
                EstoriaDeUsuario.Codigo = Convert.ToInt32(reader["idestoriadeusuario"].ToString());
                EstoriaDeUsuario.Titulo = reader["titulo"].ToString();
                EstoriaDeUsuario.Pontos = Convert.ToInt32(reader["pontos"].ToString());
                ListEstoria.Add(EstoriaDeUsuario);
            }
            return ListEstoria;
       
    }

    protected void grdDados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
        if (e.CommandName.Equals("Vincular"))
        {
            string CodigoEstoria = e.CommandArgument.ToString();
            if (!String.IsNullOrEmpty(CodigoEstoria)) {

                VincularEstoriaDeUsuario(CodigoURL);
            }
        }
    }

    protected void ButtonPesquisar_Click(object sender, EventArgs e)
    {
        MySqlConnection Conexao = new MySqlConnection(StringConexao);
        String Query = "SELECT * FROM estoriadeusuario  WHERE idestoriadeusuario = @Codigo;";
        MySqlCommand Comando = new MySqlCommand(Query, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", CampoSearch.Text);
        Conexao.Open();

        MySqlDataReader reader = Comando.ExecuteReader();

        while (reader.Read())
        {
            var EstoriaDeUsuario = new EstoriaDeUsuarioClass();
            EstoriaDeUsuario.Codigo = Convert.ToInt32(reader["idestoriadeusuario"].ToString());
            EstoriaDeUsuario.Titulo = reader["titulo"].ToString();
            EstoriaDeUsuario.Pontos = Convert.ToInt32(reader["pontos"].ToString());
            ListEstoria.Add(EstoriaDeUsuario);
        }
        this.grdDados.DataSource = ListEstoria;
        this.grdDados.DataBind();

    }

    protected void VincularEstoriaDeUsuario(string Codigo)
    {
        MySqlConnection Conexao = new MySqlConnection();
        MySqlCommand Comando = new MySqlCommand();
        Conexao.ConnectionString = StringConexao;
        Comando.Connection = Conexao;
        Conexao.Open();
        string SQLComando = "UPDATE criteriodeaceitacao SET descricao = @Descricao , idestoriadeusuario = @IDEstoriadeusuario WHERE idEstoriadeusuario = @Codigo";
        Comando = new MySqlCommand(SQLComando, Conexao);
        Comando.Parameters.AddWithValue("@Codigo", Codigo);
        Comando.ExecuteNonQuery();
        Conexao.Close();
    }
}