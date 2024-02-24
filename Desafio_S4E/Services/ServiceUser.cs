using Desafio_S4E.DAO;
using Desafio_S4E.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Desafio_S4E.Services
{
    public class ServiceUser
    {
        public bool Store(UserModel user)
        {
            try
            {
                UserDAO userDao = new UserDAO();
                userDao.Create(user);
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
                UserDAO userDAO = new UserDAO();

                return userDAO.Read();
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
                UserDAO userDAO = new UserDAO();
                userDAO.Delete(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}