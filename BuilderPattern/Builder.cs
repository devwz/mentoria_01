using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    // https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/abstract
    public abstract class Builder
    {
        protected Vehicle vehicle;

        public Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }

        public abstract void SetModel(string model);
        public abstract void SetYear(string year);
        public abstract void SetColor(string color);

        // mostrar depois

        // public abstract Builder SetModel(string model);
        // public abstract Builder SetYear(string year);
        // public abstract Builder SetColor(string color);
        // public abstract Vehicle Build();
    }
}
