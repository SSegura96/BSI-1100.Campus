using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class frmMostrar : Form
    {
        private char tipo = ' ';
        private string query = "";

        //Constructor vacio sirve para solo ejecutar un querry
        public frmMostrar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Constructor sobrecargado sirve para mostrar toda una tabla segun el valor de tipo
        /*
            - 'E' = Estudiantes
            - 'G' = Grupos
            - 'M' = Materias
            - 'N' = Notas
            - 'P' = Profesores
        */
        public frmMostrar(char _tipo)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            setTipo(_tipo);
        }

        public char getTipo()
        {
            return this.tipo;
        }

        public void setTipo(char _tipo)
        {
            this.tipo = _tipo;
        }

        public string getQuery ()
        {
            return this.query;
        }

        public void setQuery (string _query)
        {
            this.query = _query;
        }

        private string obtenerNombreTabla()
        {
            switch(tipo)
            {
                case 'E':
                    return "Estudiantes";
                break;

                case 'G':
                    return "Grupos";
                break;

                case 'M':
                    return "Materias";
                break;

                case 'N':
                    return "Notas";
                break;

                case 'P':
                    return "Profesores";
                break;

                default:
                    return null;
                break;
            }
        }

        private void generarQuery ()
        {
           setQuery("Select * from "+obtenerNombreTabla());
        }

        private void inicializarTabla()
        {
            Logica lg = new Logica(); // crea la instancia de logica
            DataSet table = new DataSet(); // crea una nueva tabla para guardar lo del metodo obtener tabla
            table = lg.obtenerTabla(getQuery() , obtenerNombreTabla());
            dataGridView1.DataSource = table.Tables[0];
            ponerHeaders(obtenerNombreTabla());
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //pone nombre a las columnas del DataGrid
        private void ponerHeaders(string nombreTabla)
        {
            switch (nombreTabla)
            {
                case "Estudiantes":
                    dataGridView1.Columns[0].HeaderText = "Carne Estudiante";
                    dataGridView1.Columns[1].HeaderText = "Nombre Estudiante";
                    dataGridView1.Columns[2].HeaderText = "Correo Estudiante";
                    dataGridView1.Columns[3].HeaderText = "Grupo Estudiante";
                    break;

                case "Grupos":
                    dataGridView1.Columns[0].HeaderText = "Codigo Grupos";
                    dataGridView1.Columns[1].HeaderText = "Codigo Materia";
                    dataGridView1.Columns[2].HeaderText = "Codigo Profesor";
                    dataGridView1.Columns[3].HeaderText = "Codigo Estudiante";
                    break;

                case "Materias":
                    dataGridView1.Columns[0].HeaderText = "Codigo Materia";
                    dataGridView1.Columns[1].HeaderText = "Nombre Materia";
                    dataGridView1.Columns[2].HeaderText = "Trimestre";
                    break;

                case "Notas":
                    dataGridView1.Columns[0].HeaderText = "Codigo Materia";
                    dataGridView1.Columns[1].HeaderText = "Carne Estudiante";
                    dataGridView1.Columns[2].HeaderText = "Nota";
                    break;

                case "Profesores":
                    dataGridView1.Columns[0].HeaderText = "Codigo Profesor";
                    dataGridView1.Columns[1].HeaderText = "Nombre Profesor";
                    dataGridView1.Columns[2].HeaderText = "Correo Profesor";
                    dataGridView1.Columns[3].HeaderText = "Telefono Profesor";
                    break;
            }//fin switch
        }//fin metedo void ponerHeaders(string nombreTabla)

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal mp = new frmMenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            if (getTipo() != ' ')
            {
                generarQuery();
            }
            inicializarTabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
