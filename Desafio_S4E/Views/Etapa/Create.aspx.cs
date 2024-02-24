using Desafio_S4E.Models;
using Desafio_S4E.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio_S4E.Views.Etapa
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void BTN_Salvar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);

            ServiceEtapa serviceEtapa = new ServiceEtapa();
            EtapaModel etapa = new EtapaModel() { Desc = TXT_Desc.Text, DataInicio = DateTime.Now, DataConclusao = null };
            serviceEtapa.Store(etapa, id);



        }
    }
}