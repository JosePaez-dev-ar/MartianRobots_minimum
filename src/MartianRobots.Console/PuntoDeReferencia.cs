namespace MartianRobots.Console
{
    public abstract record PuntoDeReferencia();

    public record PuntoDeReferenciaPerdido : PuntoDeReferencia
    {
        public Coordenadas CoordenadasPerdidasGrabadas { get; }
        public PuntoDeReferenciaPerdido(Coordenadas registroCoordenadasPerdidas)
        {
            CoordenadasPerdidasGrabadas = registroCoordenadasPerdidas;
        }
    }
}
