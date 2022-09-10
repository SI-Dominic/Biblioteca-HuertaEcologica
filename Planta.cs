using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
    public class Planta
    {
        private int idEspecie { get; set; }
        private int idVariedad { get; set; }   
        private string nombreHuerta { get; set; }
        private string estado { get; set; }
        private int carga { get; set; }
        private int produccion { get; set; }
        private DateTime fecha { get; set; }

    }
}
