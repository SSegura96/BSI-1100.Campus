using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace ProyectoPrograIV
{
    class Logica
    {
        private bool SecureLock = true;

        public Logica()
        {

        }

        public Logica (string _query, string mensaje)
        {
            ConectarAccess(_query, mensaje);
        }

        public bool getSecureLock()
        {
            return this.SecureLock;
        }

        public void setSecureLock(bool _sLock)
        {
            this.SecureLock = _sLock;
        }

        /**
        Conecta con la base de datos y ejecuta el query que tinee por parametro
        */
        public void ConectarAccess(string query, string mensaje)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
                OleDbCommand orden = new OleDbCommand(query, conexion);
                orden.Connection.Open();
                orden.ExecuteNonQuery();
                orden.Connection.Close();
                MessageBox.Show(mensaje,"Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!! "+ ex);
            }
        }

        /**
        Obtine la tabla con el query y el nombre de la materia dados
        */
        public DataSet obtenerTabla (string query, string nombreTabla)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbDataAdapter cmd = new OleDbDataAdapter(query, conexion);
            DataSet table = new DataSet();
            cmd.Fill(table,nombreTabla);
            return table;
        }

        /**
        Analiza un vector en busca de un dato retorna true en caso de que lo encuentre
            retorna:
            i = el indice en caso de que encuentre el nombre de usuario
           -1 = en caso de que no lo encuentre 
        */
        private int ExisteUsuario(string dato, List <EstructuraUsuario> listaUsuarios)
        {
            for(int i = 0;i<listaUsuarios.Count;i++)
            {
                if (listaUsuarios[i].getUsuario().Equals(dato))
                {
                    return i;
                }
            }
            return -1;
        }

        private List <EstructuraUsuario> LlenarVectorUsuarios()
        {
            string query = "Select * from Usuarios";
            List <EstructuraUsuario> listaUsuarios = new List <EstructuraUsuario> ();
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            conexion.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string usuario = reader["NombreUsuario"].ToString();
                string contrasenna = reader["Contrasena"].ToString();
                string rol = reader["Rol"].ToString();
                listaUsuarios.Add(new EstructuraUsuario(usuario, contrasenna, rol));
            }        
            conexion.Close();
            return listaUsuarios;
        }

        /**
        Valida si el usuario ingresado en el texbox y el del la base datos es el mismo
            retorna:
            1 = si el usuario y la contraseña son validos
            0 = si son invalidos
           -1 = si el usuario no existe
           -2 = si el usurio no es Administrador
        */
        public int validarUsuarioContrasenna(string user, string pass, int tipo)
        {
            List <EstructuraUsuario> listaUsuarios = LlenarVectorUsuarios();// crea un vector con el objecto EstructuraUsuario que contine Usuario,Contrasenna,Rol
            int indice = ExisteUsuario(user, listaUsuarios); // ademas de validar que el usuario exista devuelve el indice donde se encuentra
            if ( indice != -1)
            { 
                string dbUser = listaUsuarios[indice].getUsuario(); // se obtiene el usuario
                string dbPass = listaUsuarios[indice].getContrasena();// se obtiene la contraseña 
                string dbRol = listaUsuarios[indice].getRol();

                if (tipo == 1)
                {
                    if(!dbRol.Equals("Administrador"))
                    {
                        return -2;
                    }
                }

                if (user.Equals(dbUser) && dbPass.Equals(pass)) // valida que el usuario y la contraseña sean los mismos que los ingresados
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            return -1;

        }

        /**
        Busca el alumno que tenga el carne, en caso de no encontrarlo devuelve NULL
            Parametros: 
                - String id: el carne introducido por el usuario
                - List carnets: La lista de estudiantes
        */
        private string buscarAlumno(string id,List <EstructuraAlumno> carnets)
        {
            for(int i = 0;i < carnets.Count();i++)
            {
                if(carnets[i].getCarne().Equals(id))
                {
                    return carnets[i].getNombre();
                }
            }
            return null;
        }

        /**
        Realiza la coneccion con la base de datos obtine los estudiantes y valida que el caenet introducido corresponda a un usuario
        Parametros: el carnet introducido : string id
        */
        public string comprobarCarne(string id)
        {
            string query = "Select Carne, Nombre from Estudiantes";
            List<EstructuraAlumno> listaCarnets = new List<EstructuraAlumno>();// lista donde guarda el estudiante
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\\Escuela.accdb");
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            conexion.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string carne = reader["Carne"].ToString();
                string nombre = reader["Nombre"].ToString();
                listaCarnets.Add(new EstructuraAlumno (carne,nombre));
            }//fin del while
            string alumno = buscarAlumno(id,listaCarnets);
            //si el alumno no existe alumno == NULL
            if (alumno == null)
            {
                return "El alumno no existe";
            }
            else
            {
                return alumno;
            }
        }

        /**
        Metodo que valida un TextBox de origen numerico (que solo pueda contener numeros).
            -Parametros:
                TextBox text: TextBox que se desea validar
        */
        public bool EsTextBoxNumerico(TextBox text)
        {
            int num = 0;//variable para el metodo tryParse con la que se compara el TextBox
            //Se utilza un bool para almacenar el resultado del TryParse
            bool esNumero;
            esNumero = int.TryParse(text.Text, out num);
            //Se pregunta por el valor del bool
            if (!esNumero)
            {
                //si el bool es 'false' se muestra un mensaje en pantalla.
                MessageBox.Show("Error: El valor ''" + text.Text + "'' no es un valor numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//fin if
            else
            {
                return true;
            }//fin else
        }//fin metodo bool EsTextBoxNumerico(TextBox text)

        /**
        Metodo para validar un TextBox y que el mismo no quede en blanco o vacio
            -Parametros:
                TextBox txtValidar: TextBox que se desea validar
        */
        public bool EsTextBoxVacio(TextBox txtValidar)
        {
            //se pregunta si el string que se pasa del textBox es null o vacio
            if (string.IsNullOrWhiteSpace(txtValidar.Text))
            {
                return true;
            }//fin if
            else
            {
                return false;
            }//fin else
        }//fin metodo bool EsTextBoxVacio(TextBox txtValidar)

        /**
        Metodo para validar los TextBox para que no queden en blanco o vacios
            -Paramteros:
                TextBox txtValidar: TextBox que se desea validar
                TextBox txtHabilitar: TextBox que se habilita despues de que el primero tenga un valor
        */
        public void ValidarTextBoxDobleVacio(TextBox txtValidar, TextBox txtHabilitar)
        {
            //se pregunta si el string que se pasa del textBox es null o vacio
            if (string.IsNullOrWhiteSpace(txtValidar.Text))
            {
                //si esta null o vacio se mantiene en modo lectura
                txtHabilitar.ReadOnly = true;
            }//fin if
            else
            {
                //si no esta vacio o null se quita el modo lectura
                txtHabilitar.ReadOnly = false;
            }//fin else
        }//fin metodo ValidarTextBoxDobleVacio

    }
}
