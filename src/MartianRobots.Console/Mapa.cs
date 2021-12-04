using System.Collections.Generic;
using System.Linq;

namespace MartianRobots.Console
{
    public class Mapa
    {
        const int sentidoHorario = 1;
        const int sentidoAntiHorario = -1;

        private readonly IDictionary<Coordenadas, List<PuntoDeReferencia>> PuntosDeReferencia = new Dictionary<Coordenadas, List<PuntoDeReferencia>>();

        public IDictionary<Coordenadas, IEnumerable<PuntoDeReferencia>> ObtenerPuntosDeReferencia()
        {
            return PuntosDeReferencia.ToDictionary(l => l.Key, l => l.Value.AsEnumerable());
        }

        public Coordenadas Origen { get; private set; }
        public Coordenadas CoordendasSuperiorDerecha { get; private set; }

        public void Configurar(Coordenadas coordendasSuperiorDerecha)
        {
            Origen = new Coordenadas(0, 0);
            CoordendasSuperiorDerecha = coordendasSuperiorDerecha;
        }

        public Orientacion GirarDerecha(Orientacion orientacion)
        {
            var nuevaOrientacion = orientacion + sentidoHorario;

            if (nuevaOrientacion > Orientacion.W)
                nuevaOrientacion = Orientacion.N;

            return (Orientacion)nuevaOrientacion;
        }

        public Orientacion GirarIzquierda(Orientacion orientacion)
        {
            var nuevaOrientacion = orientacion + sentidoAntiHorario;
            if (nuevaOrientacion < Orientacion.N)
                nuevaOrientacion = Orientacion.W;

            return (Orientacion)nuevaOrientacion;
        }

        public Coordenadas ObtenerProximaPosicion(Coordenadas posicion, Orientacion orientacion)
        {
            Coordenadas nuevaPosicion = new Coordenadas(posicion.X, posicion.Y);

            if (orientacion == Orientacion.N)
            {
                nuevaPosicion.Y++;
            }
            else if (orientacion == Orientacion.E)
            {
                nuevaPosicion.X++;
            }
            else if (orientacion == Orientacion.S)
            {
                nuevaPosicion.Y--;
            }
            else if (orientacion == Orientacion.W)
            {
                nuevaPosicion.X--;
            }
            return nuevaPosicion;
        }

        public bool EstaDentroDeLimites(Coordenadas posicion)
        {
            if (posicion.X >= Origen.X
                && posicion.Y >= Origen.Y
                && posicion.X <= CoordendasSuperiorDerecha.X
                && posicion.Y <= CoordendasSuperiorDerecha.Y) return true;

            return false;
        }

        public IDictionary<Coordenadas, IEnumerable<PuntoDeReferenciaPerdido>> ObtenerPuntosDeReferenciaPerdidos()
        {
            return ObtenerPuntosDeReferencia()
                .Where(p => p.Value.OfType<PuntoDeReferenciaPerdido>().Any())
                .ToDictionary(p => p.Key, p => p.Value.OfType<PuntoDeReferenciaPerdido>());
        }
        public void AgregarPuntoDeReferencia(Coordenadas posicion, PuntoDeReferencia puntoDeReferencia)
        {
            if (!PuntosDeReferencia.ContainsKey(posicion))
            {
                PuntosDeReferencia.Add(posicion, new List<PuntoDeReferencia>());
            }
            PuntosDeReferencia[posicion].Add(puntoDeReferencia);
        }

    }


}
