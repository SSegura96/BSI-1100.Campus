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

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            //se genera un codigo mediante un metodo
            txtCodMateria.Text = generarCodigoMateria();
        }//fin evento void btnGenerarCodigo_Click(object sender, EventArgs e)

        //metodo para generar un codigo de materia
        private String generarCodigoMateria()
        {
            String materia = txtNombreMateria.Text;//nombre del text box
            String codigo = "";//variable que va almacenar el codigo creado
            int i = 0;//indice para controlar el tamaño de la oracion
            codigo += materia[0] + "";//Se pone la primera letra de la oracion
            //ciclo que saca que codigo
            while (i < materia.Length)
            {
                //si hay un espacio se agrega la letra que esta despues del espacio
                if (materia[i] == ' ')
                {
                    codigo += materia[i + 1];
                }//fin if
                i++;
            }//fin while
            Random rnd = new Random();//variable para el numero random del codigo
            int num = rnd.Next(1, 100);//se genera un numero entre 1 y 100
            codigo += num;//se agrega al codigo
            return codigo;
        }//fin metodo
    }
}
