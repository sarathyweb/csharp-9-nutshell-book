using System;

/*
The predefined types are
• Value types
    • Numeric
        • Signed integer
            • sbyte
            • short 
            • int
            • long
        • Unsigned integer
            • byte
            • ushort
            • uint
            • ulong
        • Real number
            • float
            • double
            • decimal
    • Logical 
        • bool
    • Character
        • char 
• Reference types
    • String
    • Object
*/

// Numeric literals
int x = 122;
long y = 0xA1; // 0x is ued to specify Hexadecimal numbers 
int million = 1_000_000; // _ can be used to improve readability
int b = 0b100011100; // 0b prefix is used to specify binary numbers

// Real numbers can use decimal and exponential notaiton
double d = 1.5;
double billion = 1E09;

// Numerical literal type inference
// If the literal contains a decimal point or the exponential symbol (E), 
// it is a double.
// Otherwise, the literal’s type is the first type in this list 
// that can fit the literal’s value: int, uint, long, and ulong.

Console.WriteLine(1.0.GetType()); // double
Console.WriteLine(1E08.GetType()); // double
Console.WriteLine(1.GetType()); // int32 (int)
Console.WriteLine(0xF0000000.GetType()); // unit32 (uint)
Console.WriteLine(0x100000000.GetType());  // Int64   (long)

// Numeric suffixes
// They are used to explicitly define the type of a variable
float s1 = 1.0F; // F -> float
double s2 = 1D; // D -> double
decimal s3 = 8.0M;// M -> decimal
uint s4 = 1U; // U -> uint
long s5 = 1L; // L -> Long
ulong s6 = 1UL; // UL -> ulong

// Numeric conversions
