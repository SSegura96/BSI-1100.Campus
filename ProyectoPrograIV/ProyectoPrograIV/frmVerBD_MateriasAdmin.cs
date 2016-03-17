using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//se agrega el using de OleBD

namespace ProyectoPrograIV
{
    public partial class frmVerBD_MateriasAdmin : Form
    {
        public frmVerBD_MateriasAdmin()
        {
            InitializeComponent();
        }//fin constructor

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }//fin evento btnAtras_Click(object sender, EventArgs e)

        //evento que realiza acciones cuando carga el form
        private void frmVerBD_MateriasAdmin_Load(object sender, EventArgs e)
        {
            //OleDbConnection conexion;
            //OleDbDataAdapter orden;
            //DataSet tabla;

            //conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Escuela.accdb");
            //string query = "SELECT Nombre ,Profesor FROM Materias";

            //orden = new OleDbDataAdapter(query, conexion);

            //tabla = new DataSet();

            //orden.Fill(tabla, "Materias");

            //dataGridView1.DataSource = tabla.Tables[0];
            //dataGridView1.Columns[0].HeaderText = "Nombre Materia";
            //dataGridView1.Columns[1].HeaderText = "Nombre Profesor";
            ////Pone las columnas en modo autoajuste lo cual permite que se adapten al tamaño del dataGried
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }//fin evento void frmVerBD_MateriasAdmin_Load(object sender, EventArgs e)

        //evento para agregar materias a la data base
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }//fin evento void btnAgregar_Click(object sender, EventArgs e)
    }
}
