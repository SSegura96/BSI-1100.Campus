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
    public partial class frmAgregarEstudiante : Form
    {
        public frmAgregarEstudiante()
        {
            InitializeComponent();
            InitializeComponent();
            this.ActiveControl = txtNombre;//pone el foco en el textbox especificado.
            this.StartPosition = FormStartPosition.CenterScreen;//pone el form en el centro.
            txtGrupo.MaxLength = 2;//pone un limite de caracteres al textBox
            //se instancian en modo lectura tres textBox
            txtCarne.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtGrupo.ReadOnly = true;
        }//fin constructor

        //Instancia de la clase "Logica" para usar los metodos que posee de validacion ce TextBox y uno metodo para conectar a la DB Access
        Logica validaciones = new Logica();

        //Metodo para generar un carne aleatorio apra el estudiante
        private String generarCarne()
        {
            //Se guarda el valor del año en un variable temporal.
            int anno = DateTime.Now.Year;

            //Se crea un numero aleatorio para finalizar el carne
            Random random = new Random();
            int num = random.Next(1, 10000);//Se crea un un numero de cuatro digitos

            //se crea un carne para el estudiante poniendo el año de matricula, el grupo y el random.
            String carne = anno.ToString() + txtGrupo.Text + num;

            return carne;
        }//fin metodo String generarCarne()

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //se limpian los textBox
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtGrupo.Text = "";
            txtCarne.Text = "";
            this.ActiveControl = txtNombre;
        }//fin evento

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }//fin evento btnAtras_Click

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se valida que txtNombre no este vacio
            if (!validaciones.EsTextBoxVacio(txtNombre))
            {
                //se valida que txtGrupo sea un valor numerico
                if (validaciones.EsTextBoxNumerico(txtGrupo))
                {
                    string query = "INSERT INTO Estudiantes(Carne,Nombre,Correo,Grupo) values('" + txtCarne.Text + "','" + txtNombre.Text + "','" + txtCorreo.Text + "','" + txtGrupo.Text + "')";
                    string mensaje = "Los datos del estudiante se agregaron exitosamente!.";
                    validaciones.ConectarAccess(query, mensaje);
                }//fin if txtGrupo
            }//fin if  if txtNombre
            else
            {
                MessageBox.Show("Por favor llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//fin else txtNombre
        }//fin evento btnAgregar_Click

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //se valida que txtNombre no este vacio y eso decide si se habilita txtCorreo
            validaciones.ValidarTextBoxDobleVacio(txtNombre, txtCorreo);
        }//fin evento txtNombre_TextChanged

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //se valida que txtCorreo no este vacio y eso decide si se habilita txtGrupo
            validaciones.ValidarTextBoxDobleVacio(txtCorreo, txtGrupo);
        }//fin evento txtCorreo_TextChanged

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            //llama al metodo para que genere un carne para el estudiante y lo muestre en el textBox.
            txtCarne.Text = generarCarne();
        }//fin evento txtGrupo_TextChanged
    }
}
