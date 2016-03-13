using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoPrograIV
{
    class Logic
    {
        public Logic (String _query)
        {
            conectaAccess(_query);
        }

        private void conectaAccess(String query)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Directory.GetCurrentDirectory()+"\\Escuela.accdb");
            OleDbCommand orden = new OleDbCommand(query, conexion);
            orden.Connection.Open();
            orden.ExecuteNonQuery();
            orden.Connection.Close();
        }
    }
}
