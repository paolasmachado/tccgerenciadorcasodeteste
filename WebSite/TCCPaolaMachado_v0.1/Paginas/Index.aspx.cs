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
          //  LabelBoasVindas.Text = "Bem - Vindo(a)  " + (Session["nome"].ToString());
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        QuantidadeEstoriaDeUsuario.Text = "20";
        QuantidadeAtividades.Text ="10";
        QuantidadeTestes.Text = "5";
        QuatidadeBugs.Text = "4";

    }

}