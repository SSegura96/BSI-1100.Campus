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
            InitializeComponent();
            llenarVector();//se usa el metodo para llenar el vector
            iniciarComboBox();//metodo para iniciar el combo box
        }

        string[] vectorImg = new string [12];
        ArrayList informacionMaterias = new ArrayList();

        //se llena el ArrayList con la informacion de cada materia
        private void llenarArrayList()
        {
            informacionMaterias.Add("En esta materia los estudiantes usan instrumentos relacionados con carpinteria haciendo uso de las instalaciones y laboratorios proporcionados por la escuela.");

        }

        //Metodo para llenar el vector con la ubicacion de las imagenes
        private void llenarVector()
        {
            vectorImg[0] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\ArtesIndustriales.jpg";
            vectorImg[1] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\CienciasDeLaNaturaleza.jpg";
            vectorImg[2] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Computacion.jpg";
            vectorImg[3] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionArtistica.jpg";
            vectorImg[4] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionFisica.jpg";
            vectorImg[5] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionDelHogar.jpg";
            vectorImg[6] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionMusical.jpg";
            vectorImg[7] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Español.jpg";
            vectorImg[8] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\EducacionReligiosa.jpg";
            vectorImg[9] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\HistoriaYGeografia.jpg";
            vectorImg[10] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Ingles.jpg";
            vectorImg[11] = "C:\\Users\\Javier\\Documents\\Visual Studio 2015\\GitHub\\ProyectoPrograIV\\ProyectoPrograIV\\ProyectoPrograIV\\ImagenesMaterias\\Matematicas.jpg";
        }

        //este metodo sirve para iniciar el combo box con el primer item
        private void iniciarComboBox()
        {
            //int comboItem = 0;//posicion de la imagen
            //cbxMaterias.SelectedIndex = 0;//item del combo box
            //pBImagenMateria.Image = Image.FromFile(vectorImg[comboItem]);//agrega la imagen la imgen
            //pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;//pone imagen en modo estrecho
        }

        //cambia la imgen conforme al idice del vector
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int comboItem = 0;
            //comboItem = cbxMaterias.SelectedIndex;
            //pBImagenMateria.Image = Image.FromFile(vectorImg[comboItem]);
            //pBImagenMateria.SizeMode = PictureBoxSizeMode.StretchImage;
            ////txtInfoMateria.Text = informacionMaterias;
        }

        private void pBImagenMateria_Click(object sender, EventArgs e)
        {

        }
    }
}
