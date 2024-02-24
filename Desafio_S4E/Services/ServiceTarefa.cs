using Desafio_S4E.DAO;
using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.Services
{
    public class ServiceTarefa
    {
        public bool Store(TarefaModel tarefa)
        {
            try
            {
                TarefaDAO tarefaDAO = new TarefaDAO();
                tarefaDAO.Create(tarefa);
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
                TarefaDAO tarefaDAO = new TarefaDAO();

                return tarefaDAO.Read();
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
                TarefaDAO tarefaDAO = new TarefaDAO();
                tarefaDAO.Delete(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}