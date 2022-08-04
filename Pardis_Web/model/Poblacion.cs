using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pardis_Web.model
{
    public class Poblacion
    {
        private int id_poblacion;
        private string nombre;
        private int id_pais;

        public Poblacion(int id_poblacion, string nombre, int id_pais)
        {
            this.id_poblacion = id_poblacion;
            this.nombre = nombre;
            this.id_pais = id_pais;
        }

        public int Id_poblacion { get => id_poblacion; set => id_poblacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_pais { get => id_pais; set => id_pais = value; }
    }
}