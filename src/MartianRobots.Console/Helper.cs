using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianRobots.Console
{
   public  class Helper
    {
        public static Orientacion ObtenerOrientacion(string codigo)
        {
            switch (codigo)
            {
                case "N":
                    return Orientacion.N;
                case "E":
                    return Orientacion.E;
                case "S":
                    return Orientacion.S;
                case "W":
                    return Orientacion.W;
                default:
                    return 0;
            }
        }
    }
}
