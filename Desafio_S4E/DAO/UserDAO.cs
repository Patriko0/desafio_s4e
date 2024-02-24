using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.DAO
{
    public class UserDAO
    {
        public void Create(UserModel user)
        {
            try
            {
                string sql = $"INSERT INTO Usuario (nome) VALUES ('{user.Name}')";
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
                string sql = $"SELECT * FROM Usuario";
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
                string sql = $"DELETE FROM Usuario WHERE id = {id}";
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