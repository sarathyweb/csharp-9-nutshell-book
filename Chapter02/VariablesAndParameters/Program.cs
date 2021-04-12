using System;
using System.Text;

/*
========== Variables and parameters =========
*/

// The variables reside in stack and heap
// Stack is a block of memory for storing local variables
// Whenever a new objected is created, it is allocated on the heap
// the reference to the object is returned

// Definite assignment policy
// • Local variables must be assigned a value before they are read
// • Arguments must be supplied when an method is called

// Passing arguments by value
int x = 8;
Foo(x); // Pass by value. Makes a copy of x
Console.WriteLine(x); // X will be still 8

// Passing a reference-type argument by value 
// copies the reference but not the object. 
// sb and fooBarSB are separate variables
// that reference the same StringBuilder object:
StringBuilder sb = new StringBuilder();
FooBar(sb);
Console.WriteLine(sb.ToString());    // Test



// The ref modifier
// To pass by reference, C# the ref modifer
int xx = 8;
BarFoo(ref xx);
Console.WriteLine(xx);// x is now 9

// Swap two strings
string xxx = "Google";
string yyy = "Facebook";
Swap(ref xxx, ref yyy);
Console.WriteLine(xxx);   // Facebook
Console.WriteLine(yyy);   // Google


// The out modifier
// Out modifier is same as ref, except
//  • It need not to assigned before calling a function
//  • It must be assigned before coming out from a function

string a, b;
Split("Stevie Ray Vaughn", out a, out b);
// Same as above
//Split ("Stevie Ray Vaughan", out string a, out string b);
Console.WriteLine(a);   // Stevie Ray
Console.WriteLine(b);   //Vaughn

// Use _ to discard a parameter
Split("Partha Sarathy T", out string c, out _);
Console.WriteLine(c); // Partha Sarathy

// The in modifier
// The in modifier is similar to ref. 
// Except that the argument's value cannot be modified by the method

// The params modifier
// Its like variadic functions in Go
// The params modifier must be in the last parmeter of a function / method

Console.WriteLine(Sum(1, 2, 3, 4));

int Sum(params int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }
    return sum;
}

// Optional parameters
// A parameter is optional if it specifies a default 
Console.WriteLine(IsEven());

bool IsEven(int number = 0)
{
    if (number % 2 == 0)
    {
        return true;
    }
    return false;
}

// Named arguments
Console.WriteLine(Multiply(number2: 50, number1: 25));

int Multiply(int number1, int number2)
{
    return number1 * number2;
}

// Ref Locals
//numRef is a reference to numbers[2]
// When we modify numRef, we modify the array element 
int[] numbers = { 0, 1, 2, 3, 4 };
ref int numRef = ref numbers[2];

// Var - Implicitly typed local variables
var x1 = "Hello"; // same as string x = "Hello";

// Target typed new expression
System.Text.StringBuilder sb1 = new();
// Same as
// System.Text.StringBuilder sb1 = new System.Text.StringBuilder();

void Split(string name, out string fNames, out string lNames)
{
    int i = name.LastIndexOf(' ');
    fNames = name.Substring(0, i);
    lNames = name.Substring(i + 1);
}

static void Swap(ref string a, ref string b)
{
    string temp = a;
    a = b;
    b = temp;
}

static void BarFoo(ref int p)
{
    p++;
    Console.WriteLine(p);
}

static void Foo(int p)
{
    p++;
    Console.WriteLine(p);
}

static void FooBar(StringBuilder fooBarSB)
{
    fooBarSB.Append("Test");
    fooBarSB = null; // Because fooBarSB is a copy of a reference, 
                     //setting it to null doesn’t make sb null.
}
