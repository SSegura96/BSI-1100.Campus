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

        private void ConectarAccess(string query)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbCommand orden = new OleDbCommand(query, conexion);
            orden.Connection.Open();
            orden.ExecuteNonQuery();
            orden.Connection.Close();
        }
    }
}
