using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.DAO
{
    public class TarefaDAO
    {
        public void Create(TarefaModel tarefa)
        {
            try
            {
                string sql = $"INSERT INTO Tarefa (descricao, dataInicio) VALUES ('{tarefa.Desc},{tarefa.DataInicio}')";
                Conexao conn = new Conexao();
                conn.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataView Read()
        {
            try
            {
                string sql = $"SELECT * FROM Tarefa";
                Conexao conn = new Conexao();
                DataView data = conn.Execute(sql);
                return data;
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
                string sql = $"DELETE FROM Tarefa WHERE id = {id}";
                Conexao conn = new Conexao();
                conn.ExecuteReader(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}