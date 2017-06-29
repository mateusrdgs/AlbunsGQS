using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albuns.Classes
{
    public static class Auxilio
    {

        public static string removerEspacos(string valor)
        {
            return valor.Trim();
        }

        public static int retornarNumero(string valor)
        {
            int numero;
            Int32.TryParse(removerEspacos(valor), out numero);
            return numero;
        }

        public static int retornarAno(string valor) 
        {
            int ano;
            Int32.TryParse(removerEspacos(valor), out ano);
            return ano;
        }

        public static bool validarCampoTexto(string valor)
        {
            return removerEspacos(valor).Length > 0;
        }

        public static bool validarCampoNumero(string valor)
        {
            int numero;
            Int32.TryParse(removerEspacos(valor), out numero);
            return numero > 0;
        }

        public static bool validarCampoAno(string valor)
        {
            int ano;
            Int32.TryParse(removerEspacos(valor), out ano);
            return ano < DateTime.Now.Year;
        }
    }
}
