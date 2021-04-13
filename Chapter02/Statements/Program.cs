using System;

/*
========== Statements ==========
*/

// Declaration  statements
// • Declares new variable
// • Ends in semi-colon
string someWord = "Word";
int someNumber = 43;
bool inch = true, famous = false;

// Constant is like variables. But it value cannot be changed
// Initialization must occur during declaration of a constant variable

const int num = 9;

// Local variables
// The scope of a local variable extends through the current block
// We cannot declare another local variable with the same name 
// in the current block or nested block

// Declare variables with declaration statements
string s;
int x, y;
System.Text.StringBuilder sb;
// Expression statements
x = 2 + 1; // Assignment expression
x++; // Increment expression
y = Math.Max(x, 5); // Assignment expression
Console.WriteLine(y); // Method call expression

//sb = new StringBuilder();  
// Assignment expression
//new StringBuilder(); 
// Object instantiation expression

// Selection statements

// IF statement
// An if statement execute a statement, if the bool expression is true
if (x < 5)
{
    Console.WriteLine("X is less than 5");
    Console.WriteLine("Let's move on");
}

// The else clause

if (1 + 1 == 3)
{
    Console.WriteLine("If block is executed");
}
else if (2 - 9 == 8)
{
    Console.WriteLine("If else block is executed");
}
else
{
    Console.WriteLine("Else block is executed");
}

// The switch statement
// Switch statements let us branch program execution 
// based on a selection of possible values

void ShowCard(int cardNumber)
{
    switch (cardNumber)
    {
        case 13:
            Console.WriteLine("King");
            break;
        case 12:
            Console.WriteLine("Queen");
            break;
        case 11:
            Console.WriteLine("Jack");
            break;
        case -1:    // Joker is -1     
            goto case 12;   // In this game joker counts as queen 
        default:  // Executes for any other cardNumber   
            Console.WriteLine(cardNumber);
            break;
    }
}

// Switch statements on type
TellMeTheType(12);
TellMeTheType("hello");
TellMeTheType(true);
void TellMeTheType(object x) // Object allows any type
{
    switch (x)
    {
        case int i:
            Console.WriteLine("It's an integer");
            Console.WriteLine($"The square of {i} is {i * i}");
            break;
        case string s:
            Console.WriteLine("It's a string");
            Console.WriteLine($"The length of {s} is {s.Length}");
            break;
        case bool b when b == true:     // Fires only when b is true    
            Console.WriteLine("True!");
            break;
        case bool b:
            Console.WriteLine("False!");
            break;
        case DateTime _:
            Console.WriteLine("It's a DateTime");
            break;
        case float f when f > 1000:
        case double d when d > 1000:
        case decimal m when m > 1000:
            Console.WriteLine("We can refer to x here but not f or d or m");
            break;
        default:
            Console.WriteLine("I don't know what x is");
            break;
    }
}

// Switch expressions

int cardNumber = 12;
string suite = "spades";
string cardName = (cardNumber, suite) switch
{
    (13, "spades") => "King of spades",
    (13, "clubs") => "King of clubs",
    _ => "Default Card",
};

// Iteration statement

// While and do While loops

int i = 0;
while (i < 3)
{
    Console.WriteLine(i);
    i++;
}

// In do while loop, the expression in the do block is always executed
int ii = 0; do
{
    Console.WriteLine(ii);
    ii++;
}
while (ii < 3);

// For loops

for (i = 0; i < 100; i++)
{
    Console.WriteLine(i);
};

// For each loop

foreach (char c in "char")
{
    Console.WriteLine(c);

};

// Jump statements
//  • continue
//  • break
//  • goto
//  • return
//  • throw

int number = 0;
while (number < 5)
{
    if (number == 2)
        break;
    Console.WriteLine(number);
    number++;
}

// The continue statement
//The continue statement forgoes the remaining statements 
//in a loop and makes an early start on the next iteration.
for (int iff = 0; iff < 10; iff++)
{
    if ((iff % 2) == 0) // If i is even,    
        continue;// continue with next iteration  
    Console.Write(iff + " ");
}

// Goto statement. 
// Its like Golang's Go to Statement

// Return statement
// returns a value to the caller

// throw 
// Used to raise exceptions
