using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract base class Vehicle
public abstract class Vehicle
{
    //property for Make
    public string Make { get; set; }

    //constructor to initialize Make 
    public Vehicle(string make)
    {
        Make = make;
    }
}

