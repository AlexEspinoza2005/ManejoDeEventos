using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Inscripcion
    {
        [Key]
        public int IdInscripcion { get; set; }

        public DateTime FechaInscripcion { get; set; }
        public string Estado { get; set; }

        public int IdParticipante { get; set; }
        public Participante Participante { get; set; }

        public int IdEvento { get; set; }
        public Evento Evento { get; set; }

        public Pago? Pago { get; set; }

        public Certificado? Certificado { get; set; }
    }

}
