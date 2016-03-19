using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

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

        /**
        Conecta con la base de datos y ejecuta el query que tinee por parametro
        */
        public void ConectarAccess(String query)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbCommand orden = new OleDbCommand(query, conexion);
            orden.Connection.Open();
            orden.ExecuteNonQuery();
            orden.Connection.Close();
        }

        /**
        Esta en construccion, va a Obtener un dato espesifico de la base de datos
        */ 
        public string ObtenerDato(string query)
        {
            string data = "";
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

        /**
        Obtine la tabla con el query y el nombre de la materia dados
        */
        public DataSet obtenerTabla (string query, string nombreTabla)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbDataAdapter cmd = new OleDbDataAdapter(query, conexion);
            DataSet table = new DataSet();
            cmd.Fill(table,nombreTabla);
            return table;
        }

        /**
        Esta en cosntruccion XD, va a analizar cada nombre de usuario con el dado en la base de datos 
        */
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
