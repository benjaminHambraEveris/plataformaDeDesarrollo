using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;
            Console.WriteLine("Intenta adiviar el numero que estoy pensando. Tenes " + contador + " intenetos.");
            Random random = new Random();
            int num = random.Next(50);
            Console.WriteLine(num);
            
        }
    }
}
