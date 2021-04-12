using System;

/*
========== Char =========
• Char represents a UTF-16 and occupies 2 bytes
*/

char C = 'A';
/*
Escape Sequence
\`  Single Quote
\"  Double Quote
\\  backslash
\0  Null
\a  Alert
\b  backspace
\f  Formfeed (next page)
\n  Newline
\r Carriage return
\t Horizontal tab
\v Vertical tab

\u and \x are used to specify any Unicode character 
via its four-digit hex code 
*/

//String
//String represents an immutable sequence of unicode characters

string a = "Hello";
Console.WriteLine(a);

// String with escape sequence
string escaped = "First Line\r\nSecond Line";
// @ is used to ignore escape sequence.
string verbatim = @"First Line\n\\\t
Second Line";
// We can include  " character by including it twice
string xml = @"<customer id=""123""></customer>";

// String Concatenation
string c = xml + verbatim;
Console.WriteLine(c);

//String interpolation
// We have to prefix $ for string interpolation
int age = 18;
Console.WriteLine($"I'm {age} years old ");
bool b = true;
Console.WriteLine($"The answer in binary is {(b ? 1 : 0)}");

//Interpolated strings must complete on a single line, 
//unless we also specify the verbatim string operator:
int x = 2;
string s = $@"this spans {x} 
lines";
