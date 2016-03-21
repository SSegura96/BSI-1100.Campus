using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    class Logica
    {
        private bool SecureLock = true;

        public Logica()
        {

        }

        public Logica (string _query, string mensaje)
        {
            ConectarAccess(_query, mensaje);
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
        public void ConectarAccess(string query, string mensaje)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
                OleDbCommand orden = new OleDbCommand(query, conexion);
                orden.Connection.Open();
                orden.ExecuteNonQuery();
                orden.Connection.Close();
                MessageBox.Show(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!! "+ ex);
            }
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
                data = reader.GetData(0).ToString();
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
        public bool validarUsuarioContrasenna(string user, string pass)
        {
            string dbUser = "RKoch3196";
            string dbPass = "rk001";

            if (user.Equals(dbUser) && dbPass.Equals(pass))
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
