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
    public partial class frmVer_MateriasEstandar : Form
    {
        object[] vectorImg = new object[12];//sea crea un vector de tipo objeto
        ArrayList informacionMaterias = new ArrayList();//Se crea un ArrayList

        public frmVer_MateriasEstandar()
        {
            InitializeComponent();
            llenarVector();//se usa el metodo para llenar el vector
            llenarArrayList();//se usa el metodo para llenar el arraylist
            iniciarComboBox();//metodo para iniciar el combo box
            this.BackgroundImage = ProyectoPrograIV.Properties.Resources.verBD_Estandar;//se establece imgen de fondo
            this.StartPosition = FormStartPosition.CenterScreen;//pone el form en el centro de la pantalla
            //evita cambiar el tamaño de la ventana
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
        }//fin constructor

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
            informacionMaterias.Add("El curso pretende motivar al estudiante a utilizar su razonamiento logico para aprender a usar operaciones basicas de matematicas.");//Matematicas
        }//fin mentodo void llenarArrayList()

        //Metodo para llenar el vector con la ubicacion de las imagenes importadas en el proyecto
        private void llenarVector()
        {
            vectorImg[0] = ProyectoPrograIV.Properties.Resources.ArtesIndustriales;
            vectorImg[1] = ProyectoPrograIV.Properties.Resources.CienciasNaturales;
            vectorImg[2] = ProyectoPrograIV.Properties.Resources.Computacion;
            vectorImg[3] = ProyectoPrograIV.Properties.Resources.EducacionArtistica;
            vectorImg[4] = ProyectoPrograIV.Properties.Resources.EducacionFisica;
            vectorImg[5] = ProyectoPrograIV.Properties.Resources.EducacionDelHogar;
            vectorImg[6] = ProyectoPrograIV.Properties.Resources.EducacionMusical;
            vectorImg[7] = ProyectoPrograIV.Properties.Resources.Español;
            vectorImg[8] = ProyectoPrograIV.Properties.Resources.EducacionReligiosa;
            vectorImg[9] = ProyectoPrograIV.Properties.Resources.HistoriaYGeografia;
            vectorImg[10] = ProyectoPrograIV.Properties.Resources.Ingles;
            vectorImg[11] = ProyectoPrograIV.Properties.Resources.Matematicas;
        }//fin metodo void llenarVector()

        //este metodo sirve para iniciar el combo box con el primer item
        private void iniciarComboBox()
        {
            int comboItem = 0;//posicion de la imagen
            cbxMaterias.SelectedIndex = 0;//item del combo box
            pBImagenMateria.Image = (Image)vectorImg[comboItem];//agrega la imagen la imgen
            pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;//pone imagen en modo estrecho
            txtInfoMateria.Text = informacionMaterias[(comboItem)].ToString();//carga la informacion que contiene el arraylist en el txt
        }//fin metodo void iniciarComboBox()

        //cambia la imgen y la informacion conforme al idice del vector y arraylist respectivamente
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboItem = 0;
            comboItem = cbxMaterias.SelectedIndex;
            pBImagenMateria.Image = (Image)vectorImg[comboItem];
            pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;
            txtInfoMateria.Text = informacionMaterias[(comboItem)].ToString();
        }//fin evento void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        //cierra la ventana actual y muestra el menu principal
        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            this.Close();
            principal.Show();
        }//fin metodo

    }//fin class
}//fin namespace
