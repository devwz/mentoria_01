using System;

namespace SqlCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro()
            {
                Modelo = "Fusca",
                Ano = 1978
            };

            CarroRepositorio repositorio = new CarroRepositorio();

            repositorio.Adicionar(carro);
        }
    }
}
