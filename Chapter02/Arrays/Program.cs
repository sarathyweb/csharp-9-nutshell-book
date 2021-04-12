using System;

// Array represents a fixed number of variables
// Once an array is created, we cannot change its length
char[] vowels = new char[5];

vowels[0] = 'A';
vowels[1] = 'E';
vowels[2] = 'I';
vowels[3] = 'O';
vowels[4] = 'U';

Console.WriteLine(vowels);
// Using for loop to iterate through an array
for (int i = 0; i < vowels.Length; i++)
{
    Console.WriteLine(vowels[i]);
}
Index first = 0;
Index last = ^1; // ^1 refers the last element of an array
char firstElement = vowels[first];   // 'a'
char lastElement = vowels[last];     // 'u'
Range firstTwoRange = 0..2;
char[] firstTwo = vowels[firstTwoRange];   // 'a', 'e'
char[] lastThree = vowels[2..];    // 'i', 'o', 'u'
char[] middleOne = vowels[2..3];   // 'i'
char[] lastTwo = vowels[^2..];     // 'o', 'u'



char[] name = new char[] { 's', 'a', 'r', 'a', 't', 'h', 'y' };
// Same as above
char[] name1 = { 's', 'a', 'r', 'a', 't', 'h', 'y' };

// Zero values
// When an array is created, the array is pre-initialized with the
// zero values of the type
// for example, the zero value for int is 0. So the elements of a int array 
// will contain the value 0

int[] intArray = new int[10];
Console.WriteLine(intArray[5]); // 0
char[] charArray = new char[10];
Console.WriteLine(charArray[5]); // empty char

// Rectangular arrays
// Reactangular arrays use commas to separate each dimension
int[,] matrix2x2 = new int[2, 2];
// we can also initialize like below
int[,] matrix3x3 = new int[,]{
    {1,2,3},
    {4,5,6},
    {7,8,9},
};

for (int i = 0; i < matrix2x2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2x2.GetLength(1); j++)
    {
        matrix2x2[i, j] = i * j;
        // Console.WriteLine(i.ToString(), j.ToString());
    }
}
for (int i = 0; i < matrix2x2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2x2.GetLength(1); j++)
    {
        Console.WriteLine(matrix2x2[i, j]);
    }
}

// Jagged array
// Jagged array is an array of array. Each array is of different length
// Jagged array are represented using successive square brackets
// to represent each dimension

// Jagged array with outermost dimesion 3
int[][] matrix = new int[][3];
for (int i = 0; i < matrix.Length; i++)
{
    matrix[i] = new int[3]; // Create inner array  
    for (int j = 0; j < matrix[i].Length; j++)
        matrix[i][j] = i * 3 + j;
}