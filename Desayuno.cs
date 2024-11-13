using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_TRABAJO_DE_PROG.___GRUPO_5
{
    public class Desayuno
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Dias { get; set; }


        public string[] ListaDias()
        {
            return Dias.Split(",");
        }
    }
}
