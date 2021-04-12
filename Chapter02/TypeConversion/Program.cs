
/*
================================================
================ Type Conversion ===============
================================================

* Type conversion always creates a new value from existing one
* The conversion can be either implicit or explicit.
    * Implicit conversions happens automatically
    * Explicit conversions requires a cast
*/

/*
Implicit conversion of a type is allowed if 
    1) The compiler can guarantee that the conversion will always succeed.
    2) No data loss during conversion.

Explicit conversion of a type is allowed if 
    1) The compiler cannot guarantee that conversion will always succeed.
    2) Informaton might be lost during conversion.
*/

// Example for implicit and explicit type conversion
// The size of int is 32 bytes
int xq = 12345;
// Implicit conversion
// long is  2X the size of an int
long yq = x;
// Explicit type conversion
// short is 1/2 the size of int 
short zq = (short)xq;
