using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comportamento_de_Memoria
{
    public class Pessoa
    {
        private string Name { get; set; }
        private int Registration { get; set; }
        private int n { get; set; }
        private double[] array { get; set; }

        private string? Project { get; set; }

        public Pessoa(string name, int registration, string? project)
        {
            Name = name;
            Registration = registration;
            Project = project;
        }


        public override string ToString()
        {
            if(Project != null)
            {
                return "\nName: " +Name+ "\nRegistration: " + Registration + "\nProject: "+Project;
            }
            else
            {
                return "\nName: " + Name +
                       "\nRegistration: " + Registration +
                       "\nProject: No project";
            }
        }
    }
}
