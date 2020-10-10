using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial_I
{
    public class Usuarios
    {
        public Usuarios() { }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
