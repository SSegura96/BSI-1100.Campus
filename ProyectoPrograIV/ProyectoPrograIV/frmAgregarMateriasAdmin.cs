using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class frmAgregarMateriasAdmin : Form
    {
        public frmAgregarMateriasAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//pone el fomr en el centro de la pantalla
            //evita cambiar el tamaño de la ventana
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
        }//fin constructor

        private void frmAgregarMateriasAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmVerBD_MateriasAdmin materiasAdmin = new frmVerBD_MateriasAdmin();
            this.Close();
            materiasAdmin.Show();
        }//fin evento void btnAtras_Click(object sender, EventArgs e)

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreMateria.Text = "";
            txtCodMateria.Text = "";
        }//fin evento void btnLimpiarCampos_Click(object sender, EventArgs e)
    }
}
