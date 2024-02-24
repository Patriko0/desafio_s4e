using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Tarefas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tarefas");
        }

        protected void BTN_Users_Click(object sender, EventArgs e)
        {
            Response.Redirect("User");
        }
    }
}