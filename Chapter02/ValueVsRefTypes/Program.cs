using System;
/* 
============ Value types vs reference types ==============
* The content of a value type variable is simply a value
* For example, the content of the built-in type int is 32 bits of data 
*/

//Custom value type

PointStruct p1 = new PointStruct();
p1.X = 7;
PointStruct p2 = p1;

Console.WriteLine(p1.X); // 7
Console.WriteLine(p2.X); // 7

p1.X = 9;
Console.WriteLine(p1.X);  // 9
Console.WriteLine(p2.X);  // 7


// Reference type
// * A reference type has two parts: An object and the reference to that object
// * Assigning  a reference type copies the reference , not the object.
PointClass p3 = new PointClass();
p3.X = 7;

PointClass p4 = p3; // Copies p3's reference.
Console.WriteLine(p3.X); // 7
Console.WriteLine(p4.X); // 7

p3.X = 9;

Console.WriteLine(p3.X); // 7
Console.WriteLine(p4.X); // 7

// Null can be assigned to reference types
PointClass p5 = null;
Console.WriteLine(p5 == null); //true

// Value type cannot have a null value

//Value type 
public struct PointStruct
{
    public int X, Y;
}

// Rewritten as reference type
public class PointClass
{
    public int X, Y;
}
