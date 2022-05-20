using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz_kvitiv
{
    static class FactoryFlowers
    {
        public static Flower CreateFlower(int what_flower,int amount_of_flowers,int color) {
            switch (what_flower)
            {
                case 0:
                    return new Rose(amount_of_flowers, color);
                case 1:
                    return new Tulip(amount_of_flowers, color);
                case 2:
                    return new Chamomile(amount_of_flowers, color);
                case 3:
                    return new Narcis(amount_of_flowers, color);
                case 4:
                    return new Lily(amount_of_flowers, color);
                case 5:
                    return new Orchid(amount_of_flowers, color);
                case 6:
                    return new Hydrangea(amount_of_flowers, color);
                    
                default:
                    throw new Exception("Ви обрали не допустимий вид квітів");
            }
        }
    }
}
