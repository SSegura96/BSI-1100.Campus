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
    public partial class frmContrasenna : Form
    {
        private int tipo = 0;

        public frmContrasenna()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public int getTipo()
        {
            return this.tipo;
        }

        public void setTipo(int _tipo)
        {
            this.tipo = _tipo;
        }

        public void cambiarEstado()
        {
            if(getTipo()==0)
            {
                btnRegistrarse.Show();
                btnCerrar.Text = "Cerrar";
            }
            else
            {
                btnRegistrarse.Hide();
                btnCerrar.Text = "Atras";
            }
        }

        /**
        Valida si el usuario y la contraseña digitadas son correctas
        */
        private void validarAcceder()
        {
            Logica lg = new Logica();
            String User = txtUsuario.Text;
            String Pass = txtContrasenna.Text;
            if (lg.validarUsuarioContrasenna(User, Pass))
            {
                if(getTipo() == 0)
                {
                    frmMenuPrincipal mp = new frmMenuPrincipal();
                    mp.Show();
                }
                else
                {
                    AgregarUsuario ag = new AgregarUsuario();
                    ag.Show();
                }
                    this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es invalido");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Contrasenna_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (getTipo() == 0)
            {
                Application.Exit();
            }
            else
            {
                setTipo(0);
                cambiarEstado();
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            validarAcceder();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo el personal administrativo \n puede registrar un nuevo usuario");
            setTipo(1);
            cambiarEstado();
        }
    }
}
