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


        //Inicio de métodos
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
                this.Text = "Inicio de sesion Estandar";
                Wallpaper.Image = (Image)ProyectoPrograIV.Properties.Resources.BaseContrasena;
                PbRegistarse.Show();
                PbCerrar.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Cerrar;
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Acceder;
            }
            else
            {
                MessageBox.Show("Para poder registar un nuevo usuario\n es necesario ingresar como\n administrador","¡Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Text = "Inicio de sesion Administrativo";
                Wallpaper.Image = (Image)ProyectoPrograIV.Properties.Resources.BaseAdministrador;
                PbRegistarse.Hide();
                PbCerrar.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_A_Atras;
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_A_Acceder;
            }
        }

        /**
        Valida si el usuario y la contraseña digitadas son correctas
        */
        private void validarAcceder()
        {
            Logica lg = new Logica();
            string User = txtUsuario.Text;
            string Pass = txtContrasenna.Text;
            string mensaje = "";
            int resp = lg.validarUsuarioContrasenna(User, Pass, getTipo());
            if (resp == 1)
            {
                if(getTipo() == 0)
                {
                    frmMenuPrincipal mp = new frmMenuPrincipal();
                    mp.setUsuario(txtUsuario.Text);
                    mp.Show();
                }
                else
                {
                    frmAgregarUsuario ag = new frmAgregarUsuario();
                    ag.Show();
                }
                    this.Hide();
            }
            else
            {
                if (resp == 0)
                {
                    mensaje = "El usuario o contraseña es invalido";
                }
                else
                {
                    if (resp == -1)
                    {
                        mensaje = "El usuario que introdujo no exite";
                    }
                    else
                    {
                        mensaje = "Su usuario no cuenta con privilegios administrativos";
                    }
                }
            }
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Inicio de manejo de eventos
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void PbCerrar_MouseHover(object sender, EventArgs e)
        {
            PbCerrar.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Cerrar;
        }

        private void PbCerrar_MouseLeave(object sender, EventArgs e)
        {
            PbCerrar.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Cerrar;
        }

        private void PbRegistarse_MouseHover(object sender, EventArgs e)
        {
            PbRegistarse.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Registarse;
        }

        private void PbRegistarse_MouseLeave(object sender, EventArgs e)
        {
            PbRegistarse.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Registarse;
        }

        private void PbAcceder_MouseHover(object sender, EventArgs e)
        {
            if (getTipo() == 0)
            {
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Acceder;
            }
            else
            {
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_A_Acceder;
            }
        }

        private void PbAcceder_MouseLeave(object sender, EventArgs e)
        {
            if (getTipo() == 0)
            {
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Acceder;
            }
            else
            {
                PbAcceder.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_A_Acceder;
            }
        }

        private void PbInfo_MouseHover(object sender, EventArgs e)
        {
            PbInfo.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_A_Info;
           
        }

        private void PbInfo_MouseLeave(object sender, EventArgs e)
        {
            PbInfo.Image = (Image)ProyectoPrograIV.Properties.Resources.btnInfo;
        }

        private void PbAcceder_Click(object sender, EventArgs e)
        {
            validarAcceder();
        }

        private void PbRegistarse_Click(object sender, EventArgs e)
        {
            setTipo(1);
            cambiarEstado();
        }

        private void PbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La modalidad de cambio de contraseña sigue en contruccion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmContrasenna_Load(object sender, EventArgs e)
        {

        }
    }
}
