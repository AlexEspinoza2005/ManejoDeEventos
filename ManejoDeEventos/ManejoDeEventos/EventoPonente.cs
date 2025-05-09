using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class EventoPonente
    {
        [Key] public int IdEventoPonente { get; set; }

        public int IdEvento { get; set; }
        public Evento Evento { get; set; }

        public int IdPonente { get; set; }
        public Ponente Ponente { get; set; }
        public List<EventoPonente>? EventosAsignados { get; set; }

    }
}
