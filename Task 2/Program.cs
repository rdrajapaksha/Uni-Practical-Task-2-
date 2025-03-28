using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02Abstract
{

    // syntax for creating an abstract class
    // access_modifier Keyword_abstract Keyword_class class_name
    public abstract class Vehicle
    {
        public string Make { get; }

        // abstract method
        //public abstract void StartEngine();

        //constructor
        public Vehicle(string make)
        {
            this.Make = make;

        }
    }

    public class Car : Vehicle
    {
        public int NoofDoors;

        public Car(string make, int doors) : base(make)
        {
            NoofDoors = doors;

        }

        /*public override void StartEngine()
        {
            Console.WriteLine("BRRRR.....");
        }*/

    }

    

    public class Program
    {
        static void Main(string[] args)

        {
            Car car1 = new Car("Ferrari", 2);
            Console.WriteLine($"My Car is a {car1.Make} with {car1.NoofDoors} doors.");
            Console.Read();
        }
    }
}
