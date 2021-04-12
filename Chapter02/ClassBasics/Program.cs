using System;
using Animals;

//Class
// The new operator creates an instance of a custom type
UnitConverter feetToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5280);

Console.WriteLine(feetToInches.Convert(30));    // 360
Console.WriteLine(feetToInches.Convert(100));   // 1200

/*
* A type contains data members and function members
* The data member of UnitConverter is the field called ratio
* The function members of UnitConverter is the method Convert 
 and the UnitConverter's constructor
*/



// Instance Members
// The data members and function members that operate on 
// the instance of the type are called instance members
// For example, the UnitConverter's Convert method  is an instance member.

// Static Members
// The data members and instance members that do do not operate 
// on the instance of the type can be marked as static
// To refer to a static member from outside its type, we specify its type name
// rather than an instance.
// For example, the WriteLine method of Console class. 
// Because WriteLine is static, we call Console.WriteLine(), not new Console.WriteLine()
// Static type -> We cannot create an instance of the type

Panda p1 = new Panda("Sarathy 1");
Panda p2 = new Panda("Sarathy 2");

Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(Panda.Population); // Static member
namespace Animals
{

    public class Panda
    {
        public string Name; // Instance field
        public static int Population; // Static field

        public Panda(string n) // Constructor
        {
            Name = n;
            Population = Population + 1;
        }
    }
}
public class UnitConverter
{
    int ratio; // field

    public UnitConverter(int unitRatio) //Constructor
    {
        ratio = unitRatio;
    }

    public int Convert(int unit) // Method
    {
        return unit * ratio;
    }
}



// Program entrypoint 
// If there is no static Main) method,  
class Program
{
    static void Main()   // Program entry point 
    {
        int x = 12 * 30;
        Console.WriteLine(x);
    }
}