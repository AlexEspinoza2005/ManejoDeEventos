using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Certificado
    {
        [Key]
        public int IdCertificado { get; set; }

        public DateTime FechaEmision { get; set; }

        [ForeignKey("Inscripcion")]
        public int IdInscripcion { get; set; }

        public Inscripcion Inscripcion { get; set; }
    }
}
