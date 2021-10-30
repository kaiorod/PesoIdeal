using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double alt, pesoideal;
            string sexo;

            Console.Beep();
            Console.Clear();
            Console.Write("Digite sua altura : ");
            alt = double.Parse(Console.ReadLine());

            Console.Write(" [M] Masculino \n [F] Feminino \nEscolha seu sexo : " );
            sexo = Console.ReadLine();

            switch (sexo)
            {
                case "M":
                pesoideal = alt * 72.7 - 58;
                Console.Write("\nSeu peso ideal é de : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{pesoideal:N2}kg");
                Console.ResetColor();
                break;
                case "m":
                pesoideal = alt * 72.7 - 58;
                Console.Write("\nSeu peso ideal é de : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{pesoideal:N2}kg");
                Console.ResetColor();
                break;

                case "F":
                pesoideal = alt * 62.1 - 44.7;
                Console.Write("\nSeu peso ideal é de : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{pesoideal:N2}kg");
                Console.ResetColor();
                break;
                case "f":
                pesoideal = alt * 62.1 - 44.7;
                Console.Write("\nSeu peso ideal é de : ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{pesoideal:N2}kg");
                Console.ResetColor();
                break;
            }
        }
    }
}
