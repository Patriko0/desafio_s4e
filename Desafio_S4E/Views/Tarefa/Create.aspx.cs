using Desafio_S4E.DAO;
using Desafio_S4E.Models;
using Desafio_S4E.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E.Views.Tarefa
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BTN_Salvar_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(Request.QueryString["Id"]);
            TarefaModel tarefa = new TarefaModel() { Desc = TXT_Desc.Text, DataInicio = DateTime.Now };
            ServiceTarefa tarefaDAO = new ServiceTarefa();
            tarefaDAO.Store(tarefa, userId);

        }
    }
}