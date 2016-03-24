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
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
        }

        private void ValidarContrasenna()
        {
            if(!txtCContrasenna.Text.Equals(txtContrasenna.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                lbContrasenna.ForeColor = Color.Red;
                lbCContrasenna.ForeColor = Color.Red;
            }
            else
            {
                lbContrasenna.ForeColor = Color.Black;
                lbCContrasenna.ForeColor = Color.Black;
            }
        }

        private bool ValidarAgregar()
        {
            Label[] lbVector = {lbUsuario,lbContrasenna, lbCContrasenna};
            int i = 0;

            if (txtUsuario.Text == "" || txtContrasenna.Text == "" || txtCContrasenna.Text == "")
            {
                if (txtUsuario.Text == "")
                {
                    i = 0;
                }

                if (txtContrasenna.Text == "")
                {
                    i = 1;
                }

                if (txtCContrasenna.Text == "")
                {
                    i = 2;
                }
                MessageBox.Show("No puede quedar " + lbVector[i].Text + "vacio ");
                lbVector[i].ForeColor = Color.Red;
                return false;
            }
            else
            {
                lbUsuario.ForeColor = Color.Black;
                lbContrasenna.ForeColor = Color.Black;
                lbCContrasenna.ForeColor = Color.Black;
                return true;
            }
        }

        private void Limpiar()
        {
            txtUsuario.Clear();
            txtContrasenna.Clear();
            txtCContrasenna.Clear();
            CboxRol.SelectedIndex = 0;
            txtUsuario.Focus();
        }

        private String GenerarQuery()
        {
            return "Insert into Usuarios (NombreUsuario,Contrasena,Rol) values ('" +txtUsuario.Text+"','"+txtContrasenna.Text+"','"+CboxRol.SelectedItem+"')";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmContrasenna pass = new frmContrasenna();
            pass.Show();
            this.Hide();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            CboxRol.SelectedIndex = 0;
        }

        private void txtCContrasenna_Leave(object sender, EventArgs e)
        {
            ValidarContrasenna();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica lg = new Logica();

            if (ValidarAgregar())
            {
               lg.ConectarAccess(GenerarQuery(),"Datos Guardados.");
            }
                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
