using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograIV
{
    class EstructuraUsuario
    {
        private string Usuario;
        private string Contrasena;
        private string Rol;

        public EstructuraUsuario(string _Usuario, string _Contrasena, string _Rol)
        {
            setUsuario(_Usuario);
            setContrasena(_Contrasena);
            setRol(_Rol);
        }

        string getUsuario ()
        {
            return this.Usuario;
        }

        void setUsuario(string _Usuario)
        {
            this.Usuario = _Usuario;
        }

        string getContrasena()
        {
            return this.Contrasena;
        }

        void setContrasena(string _Contrasena)
        {
            this.Contrasena = _Contrasena;
        }

        string getRol()
        {
            return this.Rol;
        }

        void setRol(string _Rol)
        {
            this.Rol = _Rol;
        }
    }
}
