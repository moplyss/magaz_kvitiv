using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz_kvitiv
{
    class Orchid : Flower
    {
        public Orchid(int amount, int color)
            : base(amount, color)
        {
            name = "орхiдеї";
            price = 90;
        }
     

    }
}
