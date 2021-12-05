using System;
using System.Collections.Generic;
using console = System.Console;

namespace MartianRobots.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            console.WriteLine("Demo Martian Robots!");

            int X;
            int Y;
            Orientacion O;


            string entrada0 = "5 3";

            string[] str;

            str = entrada0.Split(" ");
            X = Int32.Parse(str[0]); Y = Int32.Parse(str[1]);
            var coordendasSuperiorDerecha = new Coordenadas(X, Y);

            var mapa = new Mapa();
            mapa.Configurar(coordendasSuperiorDerecha);
            var control = new ControlDeLaMision();
            control.Mapa(mapa);


            var entradas = new Dictionary<string, string> {
                { "1 1 E", "RFRFRFRF" },
                { "3 2 N", "FRRFLLFFRRFLL" },
                { "0 3 W", "LLFFFRFLFL" },
            };

            foreach (var entrada in entradas)
            {
                console.WriteLine(entrada.Key); 

                str = entrada.Key.Split(" ");
                X = Int32.Parse(str[0]); Y = Int32.Parse(str[1]); O = Helper.ObtenerOrientacion(str[2]);
                control.AgregarRobot(new Robot(new Coordenadas(X, Y), O));

                console.WriteLine(entrada.Value);

                var instrucciones = entrada.Value.Split(" ");
                foreach (var instruccion in instrucciones)
                {
                    control.ProcesarInstruccion(instruccion);
                }
            }
         
            console.WriteLine(control.ObtenerInformeDeEstado(control));
        }
    }
}
