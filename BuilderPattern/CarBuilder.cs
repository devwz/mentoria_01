using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CarBuilder : Builder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle();
        }

        public override void SetColor(string color)
        {
            Vehicle.Color = color;
        }

        public override void SetModel(string model)
        {
            Vehicle.Model = model;
        }

        public override void SetYear(string year)
        {
            Vehicle.Year = year;
        }

        /*
        public override Vehicle Build()
        {
            return Vehicle;
        }

        public override Builder SetColor(string color)
        {
            Vehicle.Color = color;
        }
        */
    }
}
