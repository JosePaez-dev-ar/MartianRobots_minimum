using System.Collections.Generic;
using System.Text;

namespace MartianRobots.Console
{

    public class ControlDeLaMision
    {
        private Mapa _mapa { get; set; }

        private readonly List<Robot> lstRobots = new List<Robot>();

        private Robot _robot { get; set; }

        public IReadOnlyCollection<Robot> Robots => lstRobots.AsReadOnly();


        public void Mapa(Mapa mapa)
        {
            _mapa = mapa;
        }

        public void AgregarRobot(Robot robot)
        {
            lstRobots.Add(robot);
            _robot = robot;
        }


        public void ProcesarInstruccion(string Instrucciones)
        {

            foreach (var instruccion in Instrucciones.ToUpper())
            {
                switch (instruccion)
                {
                    case 'L':
                        _robot.AccionGirarIzquierda(_robot, _mapa);
                        break;

                    case 'R':
                        _robot.AccionGirarDerecha(_robot, _mapa);
                        break;

                    case 'F':
                        _robot.AccionAvanzar(_robot, _mapa);
                        break;
                }
            }
        }

        public string ObtenerInformeDeEstado(ControlDeLaMision control)
        {
            var builder = new StringBuilder();
            foreach (var robot in control.Robots)
            {
                builder.Append(robot.InformeDeEstado());

                builder.AppendLine();
            }
            return builder.ToString();
        }

    }
}
