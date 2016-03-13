using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//import de arraylist

namespace ProyectoPrograIV
{
    public partial class VerBD_Estandar : Form
    {
        public VerBD_Estandar()
        {
            llenarArrayList();//Se inicializa aqui porque tiene que estar lleno antes de recorrerse
            InitializeComponent();
            llenarVector();//se usa el metodo para llenar el vector
            iniciarComboBox();//metodo para iniciar el combo box
            //llenarArrayList();//carga la informacion de las materias
        }

        string[] vectorImg = new string [12];
        ArrayList informacionMaterias = new ArrayList();

        //se llena el ArrayList con la informacion de cada materia
        private void llenarArrayList()
        {
            informacionMaterias.Add("En esta materia los estudiantes usan instrumentos relacionados con carpinteria, haciendo uso de las instalaciones y laboratorios proporcionados por la escuela.");//ArtesIndustriales
            informacionMaterias.Add("La materia se enfoca en darle un conocimiento basico o intoductorio al estudiante sobre las ciencias biologicas.");//CienciasNaturales
            informacionMaterias.Add("Los estudiantes asistiran a un laboratorio en el cual se les enseñara a usar una computadora, manteniendolos siempre actualizados con la tecnologia de hoy en dia.");//Computacion
            informacionMaterias.Add("Se animara a los estudiantes a desarrollar y motivar sus impulsos creativos mediante actividades artisticas como pintar, dibujar, etc.");//EducacionArtistica
            informacionMaterias.Add("Este curso promete mantener siempre en buena condicion y salud a los estudiantes con rutinas o juegos durante el dia.");//EducacionFisica
            informacionMaterias.Add("El curso esta diseñado para enseñarle al estudiante como valerse por si mismo en la casa para evitar la dependencia.");//EducacionDelHogar
            informacionMaterias.Add("Se busca estimular los dotes musicales de los estudiantes para asi darles la relajacion necesaria con la musica.");//EducacionMusical
            informacionMaterias.Add("Esta materia sirve para que el estudiante pueda aprender como aprovechar al maximo su lengua materna, asi como inspirar su gusto por la literatura.");//Español
            informacionMaterias.Add("Este entorno se usa para que el estudiante pueda dedicarle un tiempo a sus tendencias religiosas sin importar su inclinacion.");//EducacionReligiosa
            informacionMaterias.Add("El objetivo de esta materia es brindarle cultura general al estudiante sobre la historia del mundo y como es la geografia del mismo.");//HistoriaYGeografia
            informacionMaterias.Add("Esta materia tiene como objetivo motivar al estudiante y enseñarle lo que posiblemente sera su segundo idioma y segunda lengua materna en el futuro.");//Ingles
            informacionMaterias.Add("El curso pretende motivar al estudiante a utilizar su razonamiento logico para aprender a usar operaciones basicas de matematicas.");
        }

        //Metodo para llenar el vector con la ubicacion de las imagenes
        private void llenarVector()
        {
            vectorImg[0] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\ArtesIndustriales.jpg";
            vectorImg[1] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\CienciasNaturales.jpg";
            vectorImg[2] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Computacion.jpg";
            vectorImg[3] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionArtistica.jpg";
            vectorImg[4] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionFisica.jpg";
            vectorImg[5] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionDelHogar.jpg";
            vectorImg[6] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionMusical.jpg";
            vectorImg[7] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Español.jpg";
            vectorImg[8] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionReligiosa.jpg";
            vectorImg[9] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\HistoriaYGeografia.jpg";
            vectorImg[10] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Ingles.jpg";
            vectorImg[11] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectSpace\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Matematicas.jpg";
        }

        //este metodo sirve para iniciar el combo box con el primer item
        private void iniciarComboBox()
        {
            int comboItem = 0;//posicion de la imagen
            cbxMaterias.SelectedIndex = 0;//item del combo box
            pBImagenMateria.Image = Image.FromFile(vectorImg[comboItem]);//agrega la imagen la imgen
            pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;//pone imagen en modo estrecho
            txtInfoMateria.Text = informacionMaterias[(comboItem)].ToString();
        }

        //cambia la imgen conforme al idice del vector
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboItem = 0;
            comboItem = cbxMaterias.SelectedIndex;
            pBImagenMateria.Image = Image.FromFile(vectorImg[comboItem]);
            pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;
            txtInfoMateria.Text = informacionMaterias[comboItem].ToString();
        }

        //metodo sin uso.. NO SE COMO BORRARLO !!!!!!!!!!!!!!!!!11
        private void pBImagenMateria_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            //FORMPRINCIPAL FMP = NEW FORM();
            //FMP.HIDE();
            //lleguele pa
        }
    }
}
