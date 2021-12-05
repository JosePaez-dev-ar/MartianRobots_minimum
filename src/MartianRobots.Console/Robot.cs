using System.Linq;
using System.Text;

namespace MartianRobots.Console
{
    public class Robot
    {
        public Coordenadas Posicion { get; set; }

        public Orientacion Orientacion { get; set; }

        public Robot(Coordenadas posicion, Orientacion orientacion)
        {
            Posicion = posicion;
            Orientacion = orientacion;
        }

        public bool EstaPerdido { get; set; }

        public void AccionGirarDerecha(Robot robot, Mapa map)
        {
            if (robot.EstaPerdido) return;

            robot.Orientacion = map.GirarDerecha(robot.Orientacion);
        }

        public void AccionGirarIzquierda(Robot robot, Mapa map)
        {
            if (robot.EstaPerdido) return;

            robot.Orientacion = map.GirarIzquierda(robot.Orientacion);
        }

        public void AccionAvanzar(Robot robot, Mapa map)
        {
            if (robot.EstaPerdido) return;
            var proximaPosicion = map.ObtenerProximaPosicion(robot.Posicion, robot.Orientacion);

            var puntoDeReferenciaPerdido = map.ObtenerPuntosDeReferenciaPerdidos();
            var proximaPosicionEstaPerdido = puntoDeReferenciaPerdido.TryGetValue(robot.Posicion, out var marcas)
                && marcas.Any(m => m.CoordenadasPerdidasGrabadas == proximaPosicion);

            if (proximaPosicionEstaPerdido) return;

            if (map.EstaDentroDeLimites(proximaPosicion))
            {
                robot.Posicion = proximaPosicion;
            }
            else
            {
                map.AgregarPuntoDeReferencia(robot.Posicion, new PuntoDeReferenciaPerdido(proximaPosicion));
                robot.EstaPerdido = true;
            }
        }

        public string InformeDeEstado()
        {
            var builder = new StringBuilder();
            {
                builder
                    .Append(Posicion.X)
                    .Append(' ')
                    .Append(Posicion.Y)
                    .Append(' ')
                    .Append(Orientacion)
                    .Append(' ')
                    .Append(EstaPerdido ? "PERDIDO" : "");
            }
            return builder.ToString();
        }
    }
}
