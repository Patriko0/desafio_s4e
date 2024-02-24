using Desafio_S4E.DAO;
using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E.Views.User
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Save_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel(){Name = TXT_Nome.Text};
            UserDAO userDAO = new UserDAO();
            userDAO.Create(user);
            Response.Redirect("/User");
        }
    }
}