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
        Logica logica = new Logica();

        public frmVerBD_MateriasAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//pone el form en el centro de la pantalla
            //evita cambiar el tamaño de la ventana
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
        }//fin constructor

        //evento que realiza acciones cuando carga el form
        private void frmVerBD_MateriasAdmin_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion;//conection String
            OleDbDataAdapter orden;// query + conexion
            DataSet tabla; //tabla

            conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Escuela.accdb");
            string query = "SELECT CodMateria ,Nombre FROM Materias";

            orden = new OleDbDataAdapter(query, conexion);

            tabla = new DataSet();

            orden.Fill(tabla, "Materias");

            dataGridView1.DataSource = tabla.Tables[0];
            //pone nombre a las columnas del DataGrid
            dataGridView1.Columns[0].HeaderText = "Codigo Materia";
            dataGridView1.Columns[1].HeaderText = "Nombre Materia";
            //Pone las columnas en modo autoajuste lo cual permite que se adapten al tamaño del dataGried
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }//fin evento void frmVerBD_MateriasAdmin_Load(object sender, EventArgs e)

        //evento para agregar materias a la data base desde otro form
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMateriasAdmin agregar = new frmAgregarMateriasAdmin();
            this.Hide();
            agregar.Show();
        }//fin evento void btnAgregar_Click(object sender, EventArgs e)

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            this.Close();
            principal.Show();
        }//fin evento void btnAtras_Click_1(object sender, EventArgs e)

    }//fin class
}//fin namespace
