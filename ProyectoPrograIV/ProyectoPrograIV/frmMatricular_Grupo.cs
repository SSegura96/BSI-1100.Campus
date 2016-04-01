using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;//using para las conexiones
using System.Drawing;
using System.IO;//using para el conection String
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV
{
    public partial class frmMatricular_Grupo : Form
    {
        public frmMatricular_Grupo()
        {
            this.ActiveControl = rdBtnPrimerCiclo;//deja seleccionado este radioButton por defecto
            //se ponen ambos comboBox en modo lectura por asi decirlo.
            cbxGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlumnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProfesores.DropDownStyle = ComboBoxStyle.DropDownList;
            //Se ponen los metodos para inicializar los combo box
            llenarComboBoxEstudiantes();
            llenarComboBoxMaterias();
            llenarComboBoxProfesores();
        }//fin constructor

        private bool esPrimerCiclo;//Variable bandera para controlar como se va a llenar el combo box de ''seccion'' dependiendo del combo box de ''_grado''

        private List<EstructuraAlumno> listaEstudiantes = new List<EstructuraAlumno>();//lista donde guardan los datos del estudiante
        private List<EstructuraMateria> listaMaterias = new List<EstructuraMateria>();//Lista donde se guardan los datos de las materias
        private List<EstructuraProfesor> listaProfesores = new List<EstructuraProfesor>();//Lista donde se guardan los datos de los profesores

        //Variables para solo obtener los codigos y poder almacenarlos en la DB
        private string codigoMateria = "";
        private string codigoProfesor = "";
        private int carneEstudiante = 0;

        //metodo que obtiene valores de la DB y los carga al combo box estudiantes y a su lista
        private void llenarComboBoxEstudiantes()
        {
            string query = "Select Carne, Nombre from Estudiantes";//Instruccion SQL
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");//Conection String
            OleDbCommand cmd = new OleDbCommand(query, conexion);//Ejecuta el comando
            conexion.Open();//Abre la DB
            OleDbDataReader reader = cmd.ExecuteReader();//Se crea un reader del comando
            //Ciclo que lee cada columna del comando
            while (reader.Read())
            {
                //Se obtiene el carne y el nomre y son almacenados en una lista y el combo box
                string carne = reader["Carne"].ToString();
                string nombre = reader["Nombre"].ToString();
                listaEstudiantes.Add(new EstructuraAlumno(carne, nombre));
                cbxAlumnos.Items.Add(carne + " / " + nombre);
            }//fin del while
            conexion.Close();//Cierra la DB
            cbxAlumnos.SelectedIndex = 0;//Pone el primer valor por defecto en el combo box
        }//fin metodo llenarComboBoxEstudiantes()

        //metodo que obtiene valores de la DB y los carga al combo box materias y a su lista
        private void llenarComboBoxMaterias()
        {
            string query = "Select * from Materias";//Instruccion SQL
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");//Conection String
            OleDbCommand cmd = new OleDbCommand(query, conexion);//Ejecuta el comando
            conexion.Open();//Abre la DB
            OleDbDataReader reader = cmd.ExecuteReader();//Se crea un reader del comando
            //Ciclo que lee cada columna del comando
            while (reader.Read())
            {
                //Se obtiene el codigo de la materia y el nombre y son almacenados en una lista y el combo box
                string codigo = reader["CodMateria"].ToString();
                string nombre = reader["Nombre"].ToString();
                listaMaterias.Add(new EstructuraMateria(codigo, nombre));
                cbxMaterias.Items.Add("[" + codigo + "] " + nombre);
            }//fin del while
            conexion.Close();//Cierra la DB
            cbxMaterias.SelectedIndex = 0;//Pone el primer valor por defecto en el combo box
        }//fin metodo llenarComboBoxMaterias()

        //metodo que obtiene valores de la DB y los carga al combo box profesores y a su lista
        private void llenarComboBoxProfesores()
        {
            string query = "Select CodProfesor, Nombre from Profesores";//Instruccion SQL
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");//Conection String
            OleDbCommand cmd = new OleDbCommand(query, conexion);//Ejecuta el comando
            conexion.Open();//Abre la DB
            OleDbDataReader reader = cmd.ExecuteReader();//Se crea un reader del comando
            //Ciclo que lee cada columna del comando
            while (reader.Read())
            {
                //Se obtiene el codigo del profesor y el nombre y son almacenados en una lista y el combo box
                string codigo = reader["CodProfesor"].ToString();
                string nombre = reader["Nombre"].ToString();
                listaProfesores.Add(new EstructuraProfesor(codigo, nombre));
                cbxProfesores.Items.Add(codigo + " | " + nombre);
            }//fin del while
            conexion.Close();//Cierra la DB
            cbxProfesores.SelectedIndex = 0;//Pone el primer valor por defecto en el combo box
        }//fin metodo llenarComboBoxProfesores()

        //Metodo para llenar el combo box de ''Grado'' con los atributos de primer ciclo
        private void llenarPrimerCiclo()
        {
            esPrimerCiclo = true;//Se pone instancia de la variable para usarla en el switch del evento: cbxGrado_SelectedIndexChanged
            cbxGrado.Items.Add("1º Grado");
            cbxGrado.Items.Add("2º Grado");
            cbxGrado.Items.Add("3º Grado");
            cbxGrado.SelectedIndex = 0;//Se deja el primer Item seleccionado para mejor visualizacion del usuario
        }//Fin metodo llenarPrimerCiclo()

        //Metodo para llenar el combo box de ''Grado'' con los atributos del segundo ciclo
        private void llenarSegundoCiclo()
        {
            esPrimerCiclo = false;//Se pone instancia de la variable para usarla en el switch del evento: cbxGrado_SelectedIndexChanged
            cbxGrado.Items.Add("4º Grado");
            cbxGrado.Items.Add("5º Grado");
            cbxGrado.Items.Add("6º Grado");
            cbxGrado.SelectedIndex = 0;//Se deja el primer Item seleccionado para mejor visualizacion del usuario
        }//fin metodo llenarSegundoCiclo()

        /*
        Metodo para llenar el combo box de ''seccion''
            -Parametro:
                int _grado: variable que se refiere al _grado seleccionado en el combo box 
                           de materias y se encarga de mostrar la seccion con su clase.
                           Ejemplo: seccion = 1 (combo box ''Grado'')
                                    clase = 1
                                    seccion = 5 (parametro)

                                    Resultado Combo box Seccion = 5-1 (seccion - clase)
                                    Y asi consecutivamente.
        */
        private void llenarSecciones(int _grado)
        {

            cbxSeccion.Items.Clear();//Se limpia el combo box para evitar Items repetidos
            int clase = 1;//Se crea la variable int ''clase'' que permite llevar un control de la cantidad de clases que posee ese _grado.

            //Ciclo para añadir al combo box las clases necesarias
            do
            {
                cbxSeccion.Items.Add(_grado + "-" + clase);//Se añade el Item al combo box
                clase++;//se aumenta la clase
            } while (clase == 1);//Fin del ciclo, valida la cantidad de clases que va a crear
            cbxSeccion.SelectedIndex = 0;//Se deja el primer Item seleccionado para mejor visualizacion del usuario
        }//fin metodo llenarSecciones(int _grado)

        /*
        Evento para cambias los combo box de "Grado" y "Seccion" en tiempo real del primer ciclo
        */
        private void rdBtnPrimerCiclo_CheckedChanged(object sender, EventArgs e)
        {
            cbxGrado.Items.Clear();//Se limpia el combo box de "Grado" para evitar repetir Items
            llenarPrimerCiclo();//Se llena el combo box con los Items del metodo
        }//fin evento rdBtnPrimerCiclo_CheckedChanged

        /*
        Evento para cambias los combo box de "Grado" y "Seccion" en tiempo real del segundo ciclo
        */
        private void rdBtnSegundoCiclo_CheckedChanged(object sender, EventArgs e)
        {
            cbxGrado.Items.Clear();//Se limpia el combo box de "Grado" para evitar repetir Items
            llenarSegundoCiclo();//Se llena el combo box con los Items del metodo
        }//fin evento rdBtnSegundoCiclo_CheckedChanged

        private void cbxGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se obtiene el Item del combo box "Grado"
            switch (cbxGrado.SelectedIndex)
            {
                //Primer Item:
                case 0:
                    //Si es de primer ciclo se llena el combo box con el _grado "1"
                    if (esPrimerCiclo)
                    {
                        llenarSecciones(1);
                    }//fin if
                    //Sino se llena con el _grado 4: (Primer Item del segundo ciclo)
                    else
                    {
                        llenarSecciones(4);
                    }//fin else
                    break;

                //Segundo Item:
                case 1:
                    //Si es de primer ciclo se llena el combo box con el _grado "2"
                    if (esPrimerCiclo)
                    {
                        llenarSecciones(2);
                    }//fin if
                    //Sino se llena con el _grado 4: (Primer Item del segundo ciclo)
                    else
                    {
                        llenarSecciones(5);
                    }//fin else
                    break;

                //Tercer Item:
                case 2:
                    //Si es de primer ciclo se llena el combo box con el _grado "3"
                    if (esPrimerCiclo)
                    {
                        llenarSecciones(3);
                    }//fin if
                    //Sino se llena con el _grado 4: (Primer Item del segundo ciclo)
                    else
                    {
                        llenarSecciones(6);
                    }//fin else
                    break;
            }//fin switch (cbxGrado.SelectedIndex)
        }//fin evento cbxGrado_SelectedIndexChanged

        /*
        Metodo para obtener el codigo de la materia de la lista que entra por parametro
            -Parametros:
                string _nombreMateria: nombre de la materia
                List<EstructuraMateria> _listaMaterias: lista de tipo <EstructuraMateria>
        */
        private string ObtenerCodigoMateria(string _nombreMateria, List<EstructuraMateria> _listaMaterias)
        {
            //ciclo que recorre la lista
            for (int i = 0; i < _listaMaterias.Count; i++)
            {
                //se pregunta por posicion si el nombre de la materia es igual al nombre del parametro
                if (_listaMaterias[i].getNombre().Equals(_nombreMateria))
                {
                    //si el nombre es igual se devuelve el codigo
                    return _listaMaterias[i].getCodigo();
                }//fin if
            }//fin ciclo for

            //Si no se encuentra la materia se obtiene un error
            MessageBox.Show("Error: Materia no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }//fin metodo ObtenerCodigoMateria(string _nombreMateria, List<EstructuraMateria> _listaMaterias)

        /*
        Metodo para obtener el codigo del profesor de la lista que entra por parametro
            -Parametros:
                string _nombreProfesor: nombre del profesor
                List<EstructuraProfesor> _listaProfesor: lista de tipo <EstructuraProfesor>
        */
        private string ObtenerCodigoProfesor(string _nombreProfesor, List<EstructuraProfesor> _listaProfesor)
        {
            //ciclo que recorre la lista
            for (int i = 0; i < _listaProfesor.Count; i++)
            {
                //se pregunta por posicion si el nombre del profesor es igual al nombre del parametro
                if (_listaProfesor[i].getNombre().Equals(_nombreProfesor))
                {
                    //si el nombre es igual se devuelve el codigo
                    return _listaProfesor[i].getCodigo();
                }//fin if
            }//fin ciclo for

            //Si no se encuentra la materia se obtiene un error
            MessageBox.Show("Error: Profesor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }//fin metodo ObtenerCodigoProfesor(string _nombreProfesor, List<EstructuraProfesor> _listaProfesor)

        /*
        Metodo para obtener el codigo del alumno de la lista que entra por parametro
            -Parametros:
                string _nombreAlumno: nombre del alumno
                List<EstructuraAlumno> _listaAlumnos: lista de tipo <EstructuraAlumno>
        */
        private string ObtenerCodigoAlumno(string _nombreAlumno, List<EstructuraAlumno> _listaAlumnos)
        {
            //ciclo que recorre la lista
            for (int i = 0; i < _listaAlumnos.Count; i++)
            {
                //se pregunta por posicion si el nombre del profesor es igual al nombre del parametro
                if (_listaAlumnos[i].getNombre().Equals(_nombreAlumno))
                {
                    //si el nombre es igual se devuelve el codigo
                    return _listaAlumnos[i].getCarne();
                }//fin if
            }//fin ciclo for

            //Si no se encuentra la materia se obtiene un error
            MessageBox.Show("Error: Alumno no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }//fin metodo ObtenerCodigoAlumno(string _nombreAlumno, List<EstructuraAlumno> _listaAlumnos)

        private void obtenerCodigos()
        {
            //Se obtiene el codigo de la materia
            int indiceComboMateria = cbxMaterias.SelectedIndex;//se crea una variable temporal para almacenar el indice del combo box Materia
            string nombreMateria = listaMaterias.ElementAt(indiceComboMateria).getNombre();//se obtiene el nombre de la materia en la posicion de la lista
            codigoMateria = ObtenerCodigoMateria(nombreMateria, listaMaterias);//se usa el metodo para encontrar el codigo de la materia

            //Se obtiene el codigo del profesores
            int indiceComboProfesor = cbxProfesores.SelectedIndex;//se crea una variable temporal para almacenar el indice del combo box Profesor
            string nombreProfesor = listaProfesores.ElementAt(indiceComboProfesor).getNombre();//se obtiene el nombre del profesor en la posicion de la lista
            codigoProfesor = ObtenerCodigoProfesor(nombreProfesor, listaProfesores);//se usa el metodo para encontrar el codigo del profesor

            //Se obtiene el codigo del alumno
            int indiceComboAlumnos = cbxAlumnos.SelectedIndex;//se crea una variable temporal para almacenar el indice del combo box Alumno
            string nombreAlumno = listaEstudiantes.ElementAt(indiceComboAlumnos).getNombre();//se obtiene el nombre del alumno en la posicion de la lista
            carneEstudiante = int.Parse(ObtenerCodigoAlumno(nombreAlumno, listaEstudiantes));//se usa el metodo para encontrar el codigo del alumno
        }//fin metodo obtenerCodigos()

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obtenerCodigos();//se usa el metodo obtener los codigos
            Logica lg = new Logica();//instancia de la clase logia
            string query = "INSERT INTO Grupos(CodGrupo,Materia,Profesor,Estudiante) values('" + cbxSeccion.SelectedItem.ToString() + "','" + codigoMateria + "','" + codigoProfesor + "','" + carneEstudiante + "')";//Sentencia SQL para almacenar los datos
            string mensaje = "El grupo se ha creado correctamente!.";//mensaje que se muestra si el query funciona
            lg.ConectarAccess(query, mensaje);//metodo para conectar a la DB
        }//fin evento btnAgregar_Click

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
