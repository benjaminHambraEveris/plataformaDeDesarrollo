using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_I
{
    public class Recursos
    {
        public Recursos() { }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
