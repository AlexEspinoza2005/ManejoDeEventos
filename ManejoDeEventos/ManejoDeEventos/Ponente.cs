using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeEventos
{
    public class Ponente
    {

        [Key] public int IdPonente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Institucion { get; set; }
        public string Email { get; set; }
    }
}
