using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIV
{
    class EstructuraMateria
    {
        /**
            Clase para poder crear objetos tipo materia
            Implementada en frmMatricular.
        */
        private string codigo;
        private string nombre;

        public EstructuraMateria(string _codigo, string _nombre)
        {
            this.codigo = _codigo;
            this.nombre = _nombre;
        }//fin constructor

        //Sets y Gets
        public string getCodigo()
        {
            return this.codigo;
        }

        public void setCodigo(string _codigo)
        {
            this.codigo = _codigo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }
    }
}
