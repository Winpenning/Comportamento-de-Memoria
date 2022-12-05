using System;

namespace Comportamento_de_Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, esc;
            int registration;

            string? project;

            Console.Write("Type your name: ");
            name = Console.ReadLine();

            Console.Write("Type your registration: ");
            registration = int.Parse(Console.ReadLine());

            Console.Write("Are you participating in a project (y/n)? ");
            esc = Console.ReadLine();

            if (esc == "y")
            {
                Console.Write("Type the name of your project: ");
                project= Console.ReadLine();
            }
            else
            {
                project = null;
            }

            Pessoa p = new Pessoa(name, registration, project);
            Console.WriteLine(p);
        }
    }
}