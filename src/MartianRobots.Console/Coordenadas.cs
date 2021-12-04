namespace MartianRobots.Console
{
    public class Coordenadas
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Coordenadas() { }
        public Coordenadas(int x, int y)
        {
            X = x; Y = y;
        }
        public static Coordenadas operator +(Coordenadas posicionA, Coordenadas PosicionB)
        {
            return new Coordenadas { X = posicionA.X + PosicionB.X, Y = posicionA.Y + PosicionB.Y };
        }
        public static Coordenadas operator -(Coordenadas posicionA, Coordenadas posicionB)
        {
            return new Coordenadas { X = posicionA.X - posicionB.X, Y = posicionA.Y - posicionB.Y };
        }
    }

}
