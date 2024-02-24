using Desafio_S4E.Models;
using Desafio_S4E.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E.Views.User
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataView dv = new DataView();
            ServiceUser serviceUser = new ServiceUser();

            dv = serviceUser.Show();
            List<UserModel> users = new List<UserModel>();
            foreach (DataRowView row in dv)
            {
                users.Add(new UserModel() {Id = (int)row["id"] ,Name = (string)row["nome"] });
            }

            Session.Add("users", users);

        }

        protected void BTN_Create_Click(object sender, EventArgs e)
        {
            Response.Redirect("User/create");
        }

        protected void BTN_AddTarefa_Click(object sender, EventArgs e)
        {

        }

        protected void BTN_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}