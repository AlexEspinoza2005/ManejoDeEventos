using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Sesion
    {
        [Key] public int IdSesion { get; set; }
        public string Titulo { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Sala { get; set; }

        public int IdEvento { get; set; }
        public Evento Evento { get; set; }
    }
}
