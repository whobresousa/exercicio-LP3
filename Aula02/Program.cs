using System;

namespace Bimestre01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Adryan Alencar", "Beatriz Minha Linda<3" };

            foreach (string item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
