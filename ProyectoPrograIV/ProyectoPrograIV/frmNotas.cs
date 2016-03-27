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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        /**
        Genera la sentencia sql
        */
        private string generarQuery()
        {
            string query = "SELECT m.Nombre, e.Nombre, n.Nota"
                  + " FROM Materias AS m, Estudiantes AS e, Notas AS n"
                  + " WHERE m.CodMateria = n.Materia"
                  + " and e.Carne = n.Estudiante"
                  + " and e.Carne = " + txtCarne.Text + ";";
            return query;
        }

        /**
        valida en tiempo real lo que escribe el usuario
        */
        private void validarCarnet()
        {
            Logica lg = new Logica();
            txtEstudiante.Text = lg.comprobarCarne(txtCarne.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validarCarnet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal mp = new frmMenuPrincipal();
            mp.Hide();
            frmMostrar mostrar = new frmMostrar('N');
            mostrar.setQuery(generarQuery());
            mostrar.Show();
            this.Hide();

        }
    }
}
