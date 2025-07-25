using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Clase___Lista.Class
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Completada { get; set; }

        public Tarea (int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
            FechaCreacion = DateTime.Now;
            Completada = false;
        }

        public void MarcarCompletada()
        {
            Completada = !Completada;
        }

    }
}
