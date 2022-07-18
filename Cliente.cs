using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
    public abstract class Cliente
    {
        public string tipoDocumento { get; set; }  
        public int numeroDocumento { get; set; }
        public int contraseña  { get; set; }
        public string calle { get; set; }  

        public string barrio { get; set; }
        public int numero { get; set; }
        public string esquina { get; set; }
        public string correoElectronico { get; set; } 
        public int telefono { get; set; }
        public string departamento { get; set; }

        public Cliente(string tipoDocumento, int numeroDocumento, int contraseña, string calle, string barrio, int numero, string esquina, string correoElectronico, int telefono, string departamento)
        {
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.contraseña = contraseña;
            this.calle = calle;
            this.barrio = barrio;
            this.numero = numero;
            this.esquina = esquina;
            this.correoElectronico = correoElectronico;
            this.telefono = telefono;
            this.departamento = departamento;
        }

        public Cliente()
        {
        }
       
    }
}
