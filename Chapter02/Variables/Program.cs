using System;
/*
* A type defines blueprint for a value. 

* A variable dentoes a storage location that can contain 
different values over time. A constant always represents the save value 

* The possible value for a variable depends on its type
*/

// Integers
int x = 12 * 30;
const int y = 22;
Console.WriteLine(x);
Console.WriteLine(y);

// String
string message = "This is a string";
string upperString = message.ToUpper();
Console.WriteLine(upperString);

// Conversion of int to string
int xx = 2021;
message = message + " " + xx.ToString();
Console.WriteLine(message);

//Bool
bool isRaining = false;
if (isRaining)
{
    Console.WriteLine("Enjoy the rain");
}

int age = 15;

bool lessThan18 = x < age;
if (lessThan18)
{
    Console.WriteLine("Go to school");
}
else
{
    Console.WriteLine("get a job");
}