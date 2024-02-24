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
        public void Create(TarefaModel tarefa, int idUser)
        {
            try
            {
                string sql = $"INSERT INTO Tarefa (descricao, dataInicio) VALUES ('{tarefa.Desc}','{tarefa.DataInicio.ToShortDateString()}')";
                Conexao conn = new Conexao();
                conn.ExecuteReader(sql);

                sql = "SELECT TOP 1 * FROM Tarefa ORDER BY id DESC";

                DataView dv = conn.Execute(sql);
                int tarefaId = (int)dv[0]["id"];

                sql = $"Insert into TarefaUsuario (idUsuario, idTarefa) Values ({idUser}, {tarefaId})";
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