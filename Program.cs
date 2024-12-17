using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prakticum_17
{
    class Program
    {
        static void Output(List<string> car)
        {
            foreach (var el in car)
            {
                Console.WriteLine(el);
            }
        }
        static void ToUp(List<string>car)
        {
            foreach (var el in car)
            {
                Console.WriteLine(el.ToUpper());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> car = new List<string>(6);
            //List<string> car1 = new List<string>() { "Toyota", "Skoda", "Opel","BMV","Volvo", "Volkswagen" };
            //var people2 = new List<string>() { "", "", "" };
            //var employer = new List<string>(people2);
            car.Add("Toyota");
            car.Add("Skoda");
            car.Add("Opel");
            car.Add("BMV");
            car.Add("Volvo");
            car.Add("Volkswagen");
            Output(car);
            ToUp(car);
            Console.WriteLine(car.Count);
            car.Add("Audi");
            Output(car);
            car.Insert(0,"Mercedes");
            Output(car);
            car.RemoveAt(3);
            Output(car);
            car.Reverse();
            Console.Read();

        }
    }
}
