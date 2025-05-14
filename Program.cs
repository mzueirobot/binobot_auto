
using System;
using System.Threading;

namespace BinobotAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o Bot...");
            Bot bot = new Bot();
            bot.Start();
            Console.ReadLine();
        }
    }

    public class Bot
    {
        public void Start()
        {
            Console.WriteLine("Bot iniciado!");
            Thread.Sleep(5000);  // Simula um processo longo, como execução do bot.
        }
    }
}
