using System;
using System.Collections.Generic;
using System.Text;

namespace InjecaoDependencia
{
    public class Gato
    {
        private IAnimalia _mamifero;

        public Gato(IAnimalia mamifero)
        {
            _mamifero = mamifero;
        }

        public void Respirar()
        {
            _mamifero.Respirar();
        }
    }
}
