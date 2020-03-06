using System;

namespace RecoveringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.Recover();
            Upholsterer upholsterer = new Upholsterer();
            upholsterer.Recover();
            FootballPlayer player = new FootballPlayer();
            player.Recover();
        }
    }
    class Patient : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("I am getting better");
        }
    }
    class Upholsterer : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("The furniture is restored.");
        }
    }
    class FootballPlayer : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("I got the ball!");
        }
    }
    public interface IRecoverable
    {
        public void Recover();
    }
}
