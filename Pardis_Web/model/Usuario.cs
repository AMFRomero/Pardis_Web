using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pardis_Web.model
{
    public class Usuario
    {
        private string nombre;
        private string apellidofirst;
        private string apellidosecond;
        private string email;
        private string password;
        private string dni;
        private int id_usuario;
        private bool isprofesor;

        public Usuario()
        {

        }

        public Usuario(string nombre, string apellidofirst, string apellidosecond, string email, string password, string dni, int id_usuario, bool isprofesor)
        {
            this.Nombre = nombre;
            this.Apellidofirst = apellidofirst;
            this.Apellidosecond = apellidosecond;
            this.Email = email;
            this.Password = password;
            this.Dni = dni;
            this.Id_usuario = id_usuario;
            this.Isprofesor = isprofesor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidofirst { get => apellidofirst; set => apellidofirst = value; }
        public string Apellidosecond { get => apellidosecond; set => apellidosecond = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public bool Isprofesor { get => isprofesor; set => isprofesor = value; }
    }
}