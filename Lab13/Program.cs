using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.Ленина, 19", 20, 12, 9);
            MultiBuilding multibuilding = new MultiBuilding("ул.Маркса, 18", 24, 16, 12, 5);

            building.Print();
            Console.WriteLine();
            multibuilding.Print();
            Console.ReadKey();
        }

        public class Building
        {
            public string Address { get; set; }
            public double LenghtBuilding { get; set; }
            public double WidthBuilding { get; set; }
            public double HeightBuilding { get; set; }


            public Building(string address, double lenghtBuilding, double widthBuilding, double heightBuilding)
            {
                this.Address = address;
                this.LenghtBuilding = lenghtBuilding;
                this.WidthBuilding = widthBuilding;
                this.HeightBuilding = heightBuilding;
            }
            public void Print()
            {
                Console.WriteLine("Адрес: {0}", Address);
                Console.WriteLine("Длина здания: {0}м", LenghtBuilding);
                Console.WriteLine("Ширина здания: {0}м", WidthBuilding);
                Console.WriteLine("Высота здания: {0}м", HeightBuilding);
            }
        }
        sealed public class MultiBuilding : Building
        {
            int Floors { get; set; }
            public MultiBuilding(string address, double lenghtBuilding, double widthBuilding, double heightBuilding, int floors)

                : base(address, lenghtBuilding, widthBuilding, heightBuilding)
            {
                Floors = floors;
            }
            public new void Print()
            {
                base.Print();
                Console.WriteLine("Этажность: {0}", Floors);
            }
        }


    }
}
