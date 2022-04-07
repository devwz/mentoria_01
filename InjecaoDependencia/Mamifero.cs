using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia
{
    public class Mamifero : IAnimalia
    {
        public string Animal { get; set; }

        public void Andar()
        {
            Console.WriteLine($"{Animal} está andando...");
        }

        public void Respirar()
        {
            Console.WriteLine($"{Animal} está respirando...");
        }
    }
}
