using System.ComponentModel;

namespace MartianRobots.Console
{
    public enum Orientacion : int
    {
        [Description("Norte")]
        N = 1,
        [Description("Este")]
        E = 2,
        [Description("Sur")]
        S = 3,
        [Description("Oeste")]
        W = 4
    }
}
