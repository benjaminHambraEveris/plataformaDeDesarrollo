using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_I
{
    public class Detalles
    {
        public Detalles() { }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public int IdRecurso { get; set; }
        public Recursos Recurso { get; set; }
        public int IdTarea { get; set; }
        public Tareas Tarea { get; set; }
    }
}
