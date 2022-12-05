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
        private string _name;
        private int Registration { get; set; }

        private string? _project;

        public Pessoa(string name, int registration, string? project)
        {
            _name = name;
            Registration = registration;
            _project = project;
        }


        public override string ToString()
        {
            if(_project != null)
            {
                return "\nName: " + _name + "\nRegistration: " + Registration + "\nProject: "+ _project;
            }
            else
            {
                return "\nName: " + _name +
                       "\nRegistration: " + Registration +
                       "\nProject: No project";
            }
        }
    }
}
