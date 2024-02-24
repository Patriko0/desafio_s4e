using Desafio_S4E.DAO;
using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.Services
{
    public class ServiceEtapa
    {
        public bool Store(EtapaModel etapa, int id)
        {
            try
            {
                EtapaDAO etapaDAO = new EtapaDAO();
                etapaDAO.Create(etapa, id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataView Show()
        {
            try
            {
                EtapaDAO etapaDAO = new EtapaDAO();

                return etapaDAO.Read();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                EtapaDAO etapaDAO = new EtapaDAO();
                etapaDAO.Delete(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}