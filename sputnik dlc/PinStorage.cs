using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sputnik_dlc
{
    internal class PinStorage
    {
        private List<IPin> _pins;

    public PinStorage()
        {
            _pins = new List<IPin>();
        }

        public void AddPin(IPin pin)
        {
            _pins.Add(pin);
        }

        public void ShowItems()
        {
            foreach (var pin in _pins)
            {
                pin.Show();
            }
        }
    }
}
