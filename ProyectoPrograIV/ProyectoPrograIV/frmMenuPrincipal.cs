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
    public partial class frmMenuPrincipal : Form
    {
        private string Usuario = "";
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string getUsuario ()
        {
            return this.Usuario;
        }

        public void setUsuario (string _usuario)
        {
            this.Usuario = _usuario;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LbUsuario.Text = getUsuario();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmContrasenna pass = new frmContrasenna();
            pass.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMostrar ms = new frmMostrar('P');
            ms.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMostrar ms = new frmMostrar('G');
            ms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMostrar ms = new frmMostrar('E');
            ms.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            frmContrasenna pass = new frmContrasenna();
            pass.Show();
            this.Hide();
        }

        private void PbHora_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PbProfesores_MouseHover(object sender, EventArgs e)
        {
            PbProfesores.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Profesores;
        }

        private void PbProfesores_MouseLeave(object sender, EventArgs e)
        {
            PbProfesores.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Profesores;
        }

        private void PbMaterias_MouseHover(object sender, EventArgs e)
        {
            PbMaterias.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Materias;
        }

        private void PbMaterias_MouseLeave(object sender, EventArgs e)
        {
            PbMaterias.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Materias; 
        }

        private void PbUsuario_MouseHover(object sender, EventArgs e)
        {
            PbUsuario.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Usuario; 
        }

        private void PbUsuario_MouseLeave(object sender, EventArgs e)
        {
            PbUsuario.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Usuario;
        }

        private void PbMatricular_MouseHover(object sender, EventArgs e)
        {
            PbMatricular.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Matricular; 
        }

        private void PbMatricular_MouseLeave(object sender, EventArgs e)
        {
            PbMatricular.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Matricular; 
        }

        private void PbSalir_MouseHover(object sender, EventArgs e)
        {
            PbSalir.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Salir; 
        }

        private void PbSalir_MouseLeave(object sender, EventArgs e)
        {
            PbSalir.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Salir;
        }

        private void PbEstudiantes_MouseHover(object sender, EventArgs e)
        {
            PbEstudiantes.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Estudiantes;
        }

        private void PbEstudiantes_MouseLeave(object sender, EventArgs e)
        {
            PbEstudiantes.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Estudiantes; 
        }

        private void PbGrupos_MouseHover(object sender, EventArgs e)
        {
            PbGrupos.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Grupos; 
        }

        private void PbGrupos_MouseLeave(object sender, EventArgs e)
        {
            PbGrupos.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Grupos; 
        }

        private void PbNotas_MouseHover(object sender, EventArgs e)
        {
            PbNotas.Image = (Image)ProyectoPrograIV.Properties.Resources.Over_btn_E_Notas;
        }

        private void PbNotas_MouseLeave(object sender, EventArgs e)
        {
            PbNotas.Image = (Image)ProyectoPrograIV.Properties.Resources.btn_E_Notas;
        }

        private void PbProfesores_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar('P');
            mostrar.Show();
            this.Hide();
        }

        private void PbMaterias_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar('M');
            mostrar.Show();
            this.Hide();
        }

        private void PbMatricular_Click(object sender, EventArgs e)
        {

        }

        private void PbEstudiantes_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar('E');
            mostrar.Show();
            this.Hide();
        }

        private void PbGrupos_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar('G');
            mostrar.Show();
            this.Hide();
        }

        private void PbNotas_Click(object sender, EventArgs e)
        {

        }
    }
}
