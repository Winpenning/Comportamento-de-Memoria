using System;
using System.Globalization;
namespace Comportamento_de_Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, esc;
            int registration,n;
            double sum = 0.0;
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

                Console.Write("How many reviews has your project had?");
                n = int.Parse(Console.ReadLine());

                double[] array = new double[n]; 

                for(int i = 0; i<n; i++)
                {
                    Console.WriteLine("Enter the score "+ i +": ");
                    array[i] = double.Parse(Console.ReadLine());
                    sum += array[i];
                }
                double avg = sum / n;
                Console.WriteLine("average score: " + avg);

                

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