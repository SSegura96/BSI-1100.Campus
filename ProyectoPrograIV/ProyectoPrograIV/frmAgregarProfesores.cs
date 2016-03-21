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
    public partial class frmAgregarProfesores : Form
    {
        Logica lg = new Logica();

        public frmAgregarProfesores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public String generarUsuario()
        {
            String nombre = txtNombre.Text;
            String code = "";
            int i = 0;
            code += nombre[0]+"";
            while (i < nombre.Length)
            {
                if(nombre[i] == ' ')
                {
                    code += nombre[i + 1];
                }
                i++;
            }
            Random rnd = new Random();
            int num = rnd.Next(1,100);
            code += num;
            return code;
        }

        public bool validarNombre()
        {
            if(txtNombre.Text == "" || txtNombre.Text == " ")
            {
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "@";
            txtTelefono.Text = "";
        }

        public void agregarRegistro()
        {
            String query = "";
            query = "Insert into Profesores(CodProfesor,Nombre,Correo,Telefono) values ('" + txtCodigo.Text + "','" + txtNombre.Text + "','" + txtCorreo.Text + "', '"+txtTelefono.Text+"')";
            lg.ConectarAccess(query, "Datos guardados.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProfesores_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(validarNombre())
            {
                txtCodigo.Text = (generarUsuario());
            }
            else
            {
                MessageBox.Show("Error: El espacio ¨Nombre¨ no puede estar vacio.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            MessageBox.Show("Casillas limpias");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal mp = new frmMenuPrincipal();
            this.Hide();
            mp.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarRegistro();
        }
    }
}
