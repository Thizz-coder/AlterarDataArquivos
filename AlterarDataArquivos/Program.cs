using System;
using AlterarDataArquivos.Utils;
namespace AlterarDataArquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            LogWriter logWriter = new LogWriter();
            robot.Executar(logWriter);
        }
    }
}