using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaz_kvitiv
{
    class Program
    {
        public static void PrintAsortument() {
            
            Console.WriteLine("0 - рози " + new Rose(1, 1).Price + " грн. за шт.");//беру прайс саме з класу,щоб при змiнi цiни,вона автоматично змiнювалась у самому магазинi квiтiв
            Console.WriteLine("1 - тюльпани " + new Tulip(1, 1).Price + " грн. за шт.");
            Console.WriteLine("2 - ромашки " + new Chamomile(1, 1).Price + " грн. за шт.");
            Console.WriteLine("3 - нарциси " + new Narcis(1, 1).Price + " грн. за шт.");
            Console.WriteLine("4 - лiлiї " + new Lily(1, 1).Price + " грн. за шт.");
            Console.WriteLine("5 - орхiдеї " + new Orchid(1, 1).Price + " грн. за шт.");
            Console.WriteLine("6 - гортензiї " + new Hydrangea(1, 1).Price + " грн. за шт.");
        }
        public static void ColorAsortument() {
            Console.WriteLine("0 - червоний");
            Console.WriteLine("1 - розовий");
            Console.WriteLine("2 - синiй");
            Console.WriteLine("3 -оранжевий ");
            Console.WriteLine("4 - фiолетовий");
            Console.WriteLine("5 - жовтий");
            Console.WriteLine("6 - бiлий");

        }
        public static int PriceOfOrder(Bouquet[] bouquets) {
            int sum = 0;
            for (int i = 0; i < bouquets.Length; i++)
            {
                sum += bouquets[i].Price_Of_Bouquet;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Bouquet[] bouquets;
            Console.WriteLine("Доброго дня! Вас вiтає магазин квiтiв \"У Ясiчки\"! Наш асортимент:");
            Console.WriteLine(new string('-', 30));
            PrintAsortument();
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Скiльки букетiв бажаєте замовити?");
            Console.Write("Кiлькiсть букетiв = ");
            int amount_of_bouquets=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (amount_of_bouquets <= 0 || amount_of_bouquets>=50) {
                throw new Exception("Введена вами кiлькiсть букетiв є немаожливою для виконання нашим магазином");
            }
            bouquets = new Bouquet[amount_of_bouquets];
            for (int i = 0; i < bouquets.Length; i++)
            {
                Console.WriteLine("Формуємо букет №"+(i+1)+":");
                Console.WriteLine("Скiльки видiв квiтiв ви бажаєте мати у букетi?");
                Console.Write("Кiлькiсть видiв квiт у букетi = ");
                int amount_of_types = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (amount_of_types <= 0 || amount_of_types > 7) {
                    throw new Exception("Ви ввели недопустиму кiлькiсть видiв квiт");
                }
                 bouquets[i] = new Bouquet(amount_of_types);
                for (int j = 0; j <bouquets[i].flowers.Length ; j++)
                {
                    Console.WriteLine("Оберiть "+(j+1)+"-ий вид квiтiв для букету з асортименту: ");
                    Console.WriteLine(new string('-', 30));
                    PrintAsortument();
                    Console.WriteLine(new string('-', 30));
                    Console.Write("Ваш вибiр = ");
                    int what_flower = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Оберiть колiр вибраних квiтiв з асортименту:");
                    Console.WriteLine(new string('-', 30));
                    ColorAsortument();
                    Console.WriteLine(new string('-', 30));
                    Console.Write("Ваш вибiр = ");
                    int color = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Кiлькiсть обраних квiт = ");
                    int amount_of_flowers = Convert.ToInt32(Console.ReadLine());
                    bouquets[i].flowers[j] = FactoryFlowers.CreateFlower(what_flower, amount_of_flowers, color);
                    Console.WriteLine();
                }
                Console.WriteLine("Букет №"+(i+1)+" сформовано:");
                bouquets[i].PrintBouquet();
                Console.WriteLine("Загальна вартiсть букета "+bouquets[i].Price_Of_Bouquet+" грн.");
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Ваше замовлення: ");
            Console.WriteLine();
            for (int i = 0; i < bouquets.Length; i++)
            {
                Console.WriteLine("Букет №" + (i + 1) +":");
                bouquets[i].PrintBouquet();
                Console.WriteLine();
                Console.WriteLine("Загальна вартiсть букета " + bouquets[i].Price_Of_Bouquet + " грн.");
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine("Загальна вартiсть замовлення "+PriceOfOrder(bouquets)+" грн.");
            Console.WriteLine("Дякуємо за замовлення!Гарного дня!");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
