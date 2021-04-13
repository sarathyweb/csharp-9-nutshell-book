using System;

/*
========== Null Operators ==========
C# provides three operators to make it easy ro work with null
    • ??  the null-coalescing operator
    • ??= the null-coalescing assignment operator
    • ?.  the null-conditional operator 
*/

// The null-coalescing operator
string s1 = null;
string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing" if s is null

// The null-coalescing assignment operator
// If the operand to the left is null, assign the 
// right operand to the left operand
// myVariable ??= someDefault;
// This is equivalent to:
// if (myVariable == null) myVariable = someDefault;

// Null conditional operator
// It allows us to call methods and access members just like
// the standard dot operatar, except if the operand on the left is null, 
// the expression evaluates to null, instead of throwing a NullReferenceException
System.Text.StringBuilder sb = null;
string s = sb?.ToString();  // No error; s instead evaluates to null
// Above tow line are equivalent to 
//string s = (sb == null ? null : sb.ToString());