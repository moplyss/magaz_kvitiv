using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz_kvitiv
{
    class Hydrangea : Flower
    {
        public Hydrangea(int amount, int color)
            : base(amount, color)
        {
            name = "гортензiї";
            price = 93;
        }
    }
}
