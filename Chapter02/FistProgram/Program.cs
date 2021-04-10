using System;

/* 
System => namespace -> Types are oraginised into namespaces. 
    Class is also a type
Console => Class -> Groups function members and data members
    to form an object oriented building block
WriteLine => Method -> Performs a function
*/

Console.WriteLine(FeetToInches(5));
SayHello();
// Here int is the return type
// this method accepts one parameter of type int
// Type int represents a 32 bit integer
int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

// this function doesn't return anything. So void is used 
// if a method doesn't accept any parameters, empty () are used
void SayHello()
{
    Console.WriteLine("Hello from SayHello();");
}