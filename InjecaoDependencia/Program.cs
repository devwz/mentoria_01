using System;

namespace InjecaoDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro.Modelo);

            // carro.Motor = new Motor();

            Console.WriteLine(carro.Motor.Cilindrada);

            //

            Mamifero mamifero = new Mamifero();
            Gato gato = new Gato(mamifero);
            gato.Respirar();
        }
    }
}
