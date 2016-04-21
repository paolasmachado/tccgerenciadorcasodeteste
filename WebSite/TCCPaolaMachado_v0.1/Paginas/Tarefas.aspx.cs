using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Classes_Tarefas : System.Web.UI.Page
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
    }

    protected void ButtonEnviar_Click(object sender, EventArgs e)
    {

    }
}