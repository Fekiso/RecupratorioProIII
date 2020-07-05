using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alquiler_de_Elementos.Models
{
    public class Alquiler
    {
        public Alquiler(int id_Alquiler, string nom_Cliente, string nomElemento, int id_Tipo_Elemento, int tiempo, bool habilitado)
        {
            this.id_Alquiler = id_Alquiler;
            Nom_Cliente = nom_Cliente;
            NomElemento = nomElemento;
            this.id_Tipo_Elemento = id_Tipo_Elemento;
            Tiempo = tiempo;
            Habilitado = habilitado;
        }

        public int id_Alquiler { get; set; }
        public string Nom_Cliente { get; set; }
        public string NomElemento { get; set; }
        public int id_Tipo_Elemento { get; set; }
        public int Tiempo { get; set; }
        public bool Habilitado { get; set; }

    }
}