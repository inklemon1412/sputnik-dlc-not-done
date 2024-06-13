using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sputnik_dlc
{
    internal class BilligPins : IPin
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public BilligPins(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void Show()
        {

        }
    }
}
