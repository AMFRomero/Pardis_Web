using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pardis_Web.model
{
    public class Requisito
    {
        private int likes;
        private int visitas;
        private int puntos;
        private int valoracion;

        public Requisito(int likes, int visitas, int puntos, int valoracion)
        {
            this.Likes = likes;
            this.Visitas = visitas;
            this.Puntos = puntos;
            this.Valoracion = valoracion;
        }

        public int Likes { get => likes; set => likes = value; }
        public int Visitas { get => visitas; set => visitas = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
    }
}