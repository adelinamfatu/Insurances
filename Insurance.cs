using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsigurariDeViataSiBunuri
{
    public class Insurance
    {
        string type;
        double price;
        int period;

        public Insurance(string type, int period)
        {
            this.type = type;
            this.period = period;
        }

        public Insurance(string type, double price, int period)
        {
            this.type = type;
            this.price = price;
            this.period = period;
        }

        public string Type
        {
            get => type;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public int Period
        {
            get => period;
        }
    }
}
