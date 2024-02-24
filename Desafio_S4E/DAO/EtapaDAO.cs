using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.DAO
{
    public class EtapaDAO
    {
        public void Create(EtapaModel etapa)
        {
            try
            {
                string sql = $"INSERT INTO Etapa (descricao, dataInicio, dataConclusao) VALUES ('{etapa.Desc},{etapa.DataInicio},{etapa.DataConclusao}')";
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
                string sql = $"SELECT * FROM Etapa";
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
                string sql = $"DELETE FROM Etapa WHERE id = {id}";
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