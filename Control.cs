using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeLaHuerta
{
    class Control
    {
        public string ctrlRegistro(Usuario usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.Id)
            {
                respuesta = "Debe llenar todos los campos";

            } else {
                if (usuario.Contraseña == usuario.ConContraseña)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        modelo.registro(usuario);
                    }
                }
                else { 
                    respuesta = "Las contraseñas no coinciden"
                }

            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16);
                { 
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));

            }
            return sb.ToString();
        }
    }

 }

