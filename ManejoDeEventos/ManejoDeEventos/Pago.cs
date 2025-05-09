using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MedioPago { get; set; }

        [ForeignKey("Inscripcion")]
        public int IdInscripcion { get; set; }

        public Inscripcion Inscripcion { get; set; }
    }
}
