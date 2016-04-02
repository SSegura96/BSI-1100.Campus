using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;//using
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
            this.ActiveControl = txtNombre;//pone el foco en el textbox especificado.
            this.StartPosition = FormStartPosition.CenterScreen;//pone el form en el centro.
            txtGrupo.MaxLength = 3;//pone un limite de caracteres al textBox
            //se instancian en modo lectura tres textBox
            txtCarne.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtGrupo.ReadOnly = true;
        }//fin constructor

        Logica lg = new Logica();

        //Metodo para generar el carne del estudiante
        private String generarCarne()
        {
            //Se guarda el valor del año en un variable temporal.
            int anno = DateTime.Now.Year;

            //Se crea un numero aleatorio para finalizar el carne
            Random random = new Random();
            int num = random.Next(1, 10000);//Se crea un un numero de cuatro digitos

            string grupo = txtGrupo.Text;
            grupo = grupo.Replace("-", "");
            //se crea un carne para el estudiante poniendo el año de matricula, el grupo y el random.
            String carne = anno.ToString() + grupo + num;

            return carne;
        }//fin metodo String generarCarne()

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //se valida que txtNombre no este vacio y eso decide si se habilita txtCorreo
            lg.ValidarTextBoxDobleVacio(txtNombre, txtCorreo);
        }//fin evento txtNombre_TextChanged

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //se valida que txtCorreo no este vacio y eso decide si se habilita txtGrupo
            lg.ValidarTextBoxDobleVacio(txtCorreo, txtGrupo);
        }//fin evento txtCorreo_TextChanged

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            //llama al metodo para que genere un carne para el estudiante y lo muestre en el textBox.
            txtCarne.Text = generarCarne();
        }//fin evento txtGrupo_TextChanged

        //Se guarda el estudiante con la informacion digitada por el usuario
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se valida que txtNombre no este vacio
            if (!lg.EsTextBoxVacio(txtNombre))
            {
                //se valida que txtGrupo sea un valor numerico
                if (lg.EsTextBoxNumerico(txtGrupo))
                {
                    OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Escuela.accdb");
                    //Statement de SQL para hcer inserciones a la DB que tenemos en access
                    string query = "INSERT INTO Estudiantes(Carne,Nombre,Correo,Grupo) values('" + txtCarne.Text + "','" + txtNombre.Text + "','" + txtCorreo.Text + "','" + txtGrupo.Text + "')";
                    //Incializacion del OleDbCommand con los parametros del query y conexion
                    OleDbCommand orden = new OleDbCommand(query, conexion);

                    orden.Connection.Open(); //Se abre la base de datos y se prepara para modificacion
                    orden.ExecuteNonQuery(); //Se ejecuta el query SQL deseado
                    orden.Connection.Close();//Se cierra la base de datos
                }//fin if txtGrupo
            }//fin if  if txtNombre
            else
            {
                MessageBox.Show("Por favor llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//fin else txtNombre
        }//fin evento btnAgregar_Click

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //se limpian los textBox
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtGrupo.Text = "";
            txtCarne.Text = "";
            this.ActiveControl = txtNombre; //pone el focus en text box definido
        }//fin evento btnLimpiar_Click

        //Evento para volver a mostrar la DB de estudiantes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMostrar estudiantes = new frmMostrar('E');
            this.Close();
            estudiantes.Show();
        }//fin evento btnVolver_Click
    }//fin class
}//fin namespace
