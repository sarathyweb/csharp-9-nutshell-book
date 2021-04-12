using System;
/*
========== Operators ==========
+   Addition
-   Substraction
*   Multiplication
/   Division
%   Reminder after division
*/

// Increment and decrement operators
int x = 10;
int y = 20;
Console.WriteLine(x++);// Output: 10, Value of x: 11
Console.WriteLine(++y);// Output: 21, value of y: 21

/*
=== Special operations on integral types ===
*/
//The integral types are int, unit, long, ulong,short,ushort, byte, sbyte
//  Division always truncates reminders
int ccccccccccc = 2 / 3; // 0
// Division by 0 causes exception
//int b = 5 / 0;

// Integer Overflow 
int a = int.MaxValue;
Console.WriteLine(a); //2147483647
// Overflowing silently
Console.WriteLine(++a); //-2147483648 

// checked is used to thrown an overflow exception

int a1 = 1000000;
int b1 = 1000000;
//int c1 = checked(a1 * b1);

/*
Bitwise operators
~   Complement
&   AND
|   OR
^   XOR
<<  Shift left
>>  Shift right
*/

/*
Special float and double values
*/
Console.WriteLine(double.NegativeInfinity);   // -Infinity
Console.WriteLine(double.PositiveInfinity);   // +Infinity
Console.WriteLine(double.NaN);   // NaN( Not a number)

// Double vs Decimal
// Use double for scientific computation
// Use decimal for financial computation

// Equality and comparision operators
// == and != test for equality of any type
// <=, >= < , > are comparsion operators
int xx = 1;
int yy = 2;
bool xy = xx == yy;
Console.WriteLine(xy);

// For reference types, the equality is based on reference, 
// not the actual value of the underlying object

Dude d1 = new Dude("Sarathy");
Dude d2 = new Dude("Sarathy");
Console.WriteLine(d1 == d2); // False

Dude d3 = d1;
Console.WriteLine(d1 == d3); // True

// Here we're comparing the value of two strings, not two objects. 
Console.WriteLine(d1.Name == d2.Name); // true

/* 
Conditional operators
&&  AND
||  OR
!   NOT
*/

/* Ternary Operator */
// Format (condition) ? expr1: expr2;
// if condition is true, expr1 is executed, otherwise expr2 is executed.

public class Dude
{
    public string Name;
    public Dude(string n)
    {
        Name = n;
    }
}