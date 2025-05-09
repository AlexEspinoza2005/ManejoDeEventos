using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Evento
    {

        [Key] public int IdEvento { get; set; }
        public string Nombre { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Tipo { get; set; } 
        public string Lugar { get; set; }

        public List<Sesion>? Sesiones { get; set; }
        public List<EventoPonente>? PonentesAsignados { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }

    }
}
