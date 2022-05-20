using System;

namespace magaz_kvitiv
{
    abstract class Flower
    {
        protected int price;
        protected enum Color { Red = 0, Pink = 1, Blue = 2, Orange = 3, Purple = 4, Yellow = 5, White = 6 }
        protected string name;
        protected int amount_of_flower=-1;
        protected Color color;
        public Flower(int amount, int color)
        {
            amount_of_flower = amount;
            FlowerColor = color;
        }
        public int FlowerColor { 
            set {
                if (value >= 0 && value <= 6)
                    color = (Color)value;
                else
                    throw new Exception("Ви обрали недопустимий колір");
            } 
        }
        public int Amount { set { amount_of_flower = value; } }
        public int Price { get => price; }
        public void Print() {
            string writecolor;
            switch (color)
            {
                case Color.Red:
                    writecolor = "Червонi";
                    break;
                case Color.Pink:
                    writecolor = "Розовi";
                    break;
                case Color.Blue:
                    writecolor = "Синi";
                    break;
                case Color.Orange:
                    writecolor = "Оранжевi";
                    break;
                case Color.Purple:
                    writecolor = "Фiолотевi";
                    break;
                case Color.Yellow:
                    writecolor = "Жовтi";
                    break;
                case Color.White:
                    writecolor = "Бiлi";
                    break;
                default:
                    writecolor = "";
                    break;
            }
            System.Console.WriteLine(writecolor +" "+name+" кiлькiстю "+amount_of_flower+" шт. - вартiсть "+PriceOfFlowers+" грн.");
        }
        public int PriceOfFlowers { get => price * amount_of_flower;  }
        public string Name { get => name; }
    }
}
