using Desafio_S4E.Models;
using Desafio_S4E.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E.Views.Tarefa
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            ServiceEtapa serviceEtapa = new ServiceEtapa();

            dv = serviceEtapa.Show();
            List<TarefaModel> tarefa = new List<TarefaModel>();
            foreach (DataRowView row in dv)
            {
                tarefa.Add(new TarefaModel() { Id = (int)row["id"], Desc = (string)row["descricao"] });
            }

            Session.Add("tarefas", tarefa);
        }

        protected void DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}