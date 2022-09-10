using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
     class Usuario
    {
        public Usuario()
        {
        }

        private int id { get; set; }
        private string usuario { get; set; }
        private string contraseña { get; set; }

        private string conContraseña { get; set; }

        public Usuario(int id, string usuario, string contraseña, string conContraseña)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.conContraseña = conContraseña;
        }
    }
}
