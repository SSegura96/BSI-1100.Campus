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

        public string getUsuario ()
        {
            return this.Usuario;
        }

        public void setUsuario(string _Usuario)
        {
            this.Usuario = _Usuario;
        }

        public string getContrasena()
        {
            return this.Contrasena;
        }

        public void setContrasena(string _Contrasena)
        {
            this.Contrasena = _Contrasena;
        }

        public string getRol()
        {
            return this.Rol;
        }

        public void setRol(string _Rol)
        {
            this.Rol = _Rol;
        }
    }
}
