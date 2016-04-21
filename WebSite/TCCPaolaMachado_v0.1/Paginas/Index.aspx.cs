using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
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
        QuantidadeEstoriaDeUsuario.Text = ConsultarQuantidadeEstoriaDeUsuario();
        QuantidadeTarefas.Text = ConsultarQuantidadeTarefas();
        QuantidadeTestes.Text = ConsultarQuantidadeTarefas();
        QuantidadeBugs.Text = ConsultarQuantidadeBugs();

    }

    protected String ConsultarQuantidadeEstoriaDeUsuario() {
        String quantidade = "";

        return quantidade;
    }

    protected String ConsultarQuantidadeTarefas()
    {
        String quantidade = "";

        return quantidade;
    }

    protected String ConsultarQuantidadeTestes()
    {
        String quantidade = "";

        return quantidade;
    }

    protected String ConsultarQuantidadeBugs()
    {
        String quantidade = "";

        return quantidade;
    }

}