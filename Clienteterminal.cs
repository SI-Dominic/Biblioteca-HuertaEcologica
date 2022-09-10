using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
    public class Clienteterminal : Cliente
    {
        private string tipoDocumento { get; set; }
        private int numeroDocumento { get; set; }
        private string primerNombre { get; set; }
        private string segundoNombre { get; set; }
        private string primerApellido { get; set; }
        private string segundoApellido { get; set; }
        public Clienteterminal(string tipoDocumento, int numeroDocumento, int contraseña, string calle, string barrio, int numero, string esquina, string correoElectronico, int telefono, string departamento){}
    }
}
