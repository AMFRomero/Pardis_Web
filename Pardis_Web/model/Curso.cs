using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pardis_Web.model
{
    public class Curso
    {
        private int id_curso;
        private string nombre;
        private int id_usuario;
        private int id_subcategoria;
        private int duracion;
        private int id_valoracion;
        private int precio;

        public Curso(int id_curso, string nombre, int id_usuario, int id_subcategoria, int duracion, int id_valoracion, int precio)
        {
            this.Id_curso = id_curso;
            this.Nombre = nombre;
            this.Id_usuario = id_usuario;
            this.Id_subcategoria = id_subcategoria;
            this.Duracion = duracion;
            this.Id_valoracion = id_valoracion;
            this.Precio = precio;
        }

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_subcategoria { get => id_subcategoria; set => id_subcategoria = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Id_valoracion { get => id_valoracion; set => id_valoracion = value; }
        public int Precio { get => precio; set => precio = value; }

   
        

        }
    }
