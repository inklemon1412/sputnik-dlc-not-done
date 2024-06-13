using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sputnik_dlc
{
    internal interface IPin
    {
       public string Name { get; set; }
       public int Price { get; set; }

        void Show();
    }
}
