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
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
