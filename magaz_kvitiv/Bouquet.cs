using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz_kvitiv
{
    class Bouquet
    {
        public Flower[] flowers;
        public Bouquet(int amout_of_types_flowers)
        {
            
            flowers = new Flower[amout_of_types_flowers];
        }
        public int Price_Of_Bouquet
        {
            get {
                int sum = 0;
                for (int i = 0; i <flowers.Length; i++)
                {
                    sum += flowers[i].PriceOfFlowers;
                }
                return sum;
            }
        }
        public void PrintBouquet() {
            for (int i = 0; i < flowers.Length; i++)
            {
                flowers[i].Print();
            }
        }
    }
}
