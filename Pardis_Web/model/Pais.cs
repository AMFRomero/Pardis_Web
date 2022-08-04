using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pardis_Web.model
{
    public class Pais
    {
        private int id_pais;
        private string nombre;

        public Pais(int id_pais, string nombre)
        {
            this.id_pais = id_pais;
            this.nombre = nombre;
        }

        public int Id_pais { get => id_pais; set => id_pais = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}