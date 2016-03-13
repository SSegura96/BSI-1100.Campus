using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoPrograIV
{
    class Logica
    {
        private bool SecureLock = true;

        public Logica()
        {

        }

        public Logica (String _query)
        {
            ConectarAccess(_query);
        }

        public bool getSecureLock()
        {
            return this.SecureLock;
        }

        public void setSecureLock(bool _sLock)
        {
            this.SecureLock = _sLock;
        }

        public void ConectarAccess(String query)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbCommand orden = new OleDbCommand(query, conexion);
            orden.Connection.Open();
            orden.ExecuteNonQuery();
            orden.Connection.Close();
        }

        public String ObtenerDato(String query)
        {
            String data = "";
            try
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
                OleDbCommand cmd = new OleDbCommand(query, conexion);
                conexion.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                data = reader.GetString(0);
                conexion.Close();
            }
            catch (Exception ex)
            {

            }

            return data;
        }

        public bool validarUsuarioContrasenna(String user, String pass)
        {
            String dbUser = "RKoch3196";
            String dbPass = "rk001";

            if(user.Equals(dbUser) && dbPass.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
