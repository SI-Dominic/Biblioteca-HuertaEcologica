using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
    public class Especie
    {
        private int id_especie { get; set; }
        private string metodo { get; set; }
        private string nombre { get; set; }
        private DateTime cosecha { get; set; }
        private DateTime trasplantar { get; set; }
        private DateTime germinacion { get; set; }
        private int profundidad { get; set; }
    }
}

