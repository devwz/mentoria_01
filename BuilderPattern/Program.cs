using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new CarBuilder();

            builder.SetYear("2022");
            builder.SetColor("Branca");
            builder.SetModel("Onix");

            Vehicle vehicle = builder.Vehicle;

            Console.WriteLine(vehicle.Model);

            //

            /*
            builder = new CarBuilder();
            Vehicle vehicle1 = builder
                .SetYear("2022")
                .SetColor("Branco")
                .SetModel("Onix")
                .Build();
            */
        }
    }
}
