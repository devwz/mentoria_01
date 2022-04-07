using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public Motor Motor { get; set; }
        public Roda Roda { get; set; } = new Roda();
    }
}
