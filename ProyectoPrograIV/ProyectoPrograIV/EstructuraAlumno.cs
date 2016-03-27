using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIV
{
    class EstructuraAlumno
    {
        private string Carne;
        private string Nombre;

        public EstructuraAlumno(string _carne, string _nombre)
        {
            setCarne(_carne);
            setNombre(_nombre);
        }

        public string getCarne ()
        {
            return Carne;
        }

        public void setCarne(string _carne)
        {
            Carne = _carne;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string _nombre)
        {
            Nombre = _nombre;
        }

    }
}
