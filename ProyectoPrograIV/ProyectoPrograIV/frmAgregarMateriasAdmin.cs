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
            txtCodMateria.MaxLength = 7;
        }//fin constructor

        Logica logica = new Logica();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se genera un query
            string query = "INSERT INTO Materias(CodMateria,Nombre) values('" + txtCodMateria.Text + "','" + txtNombreMateria.Text + "')"; ;
            //Se genera un mensaje para verificar que los datos se han guardado
            string mensaje = "La nueva materia ha sido guardada con exito!.";
            //Se utiliza el metodo de logica para conectar la base de datos
            logica.ConectarAccess(query, mensaje);
        }//fin evento btnAgregar_Click

        private void btnAtras_Click(object sender, EventArgs e)
        {
            
        }//fin evento void btnAtras_Click

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreMateria.Text = "";
            txtCodMateria.Text = "";
        }//fin evento void btnLimpiarCampos_Click

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            //se genera un codigo mediante un metodo
            txtCodMateria.Text = generarCodigoMateria();
        }//fin evento void btnGenerarCodigo_Click

        //metodo para generar un codigo de materia
        private String generarCodigoMateria()
        {
            String codigo = "EGB-";//variable que va almacenar el codigo creado
            Random rnd = new Random();//variable para el numero random del codigo
            int num = rnd.Next(1, 100);//se genera un numero entre 1 y 100
            codigo += num;//se agrega al codigo
            return codigo;
        }//fin metodo generarCodigoMateria()
    }
}
