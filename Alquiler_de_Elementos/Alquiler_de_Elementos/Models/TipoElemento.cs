using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alquiler_de_Elementos.Models
{
    public class TipoElemento
    {
        public TipoElemento(int id, string tipo, string descripcion, bool habilitado)
        {
            Id = id;
            Tipo = tipo;
            Descripcion = descripcion;
            this.habilitado = habilitado;
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public bool habilitado { get; set; }
    }
}