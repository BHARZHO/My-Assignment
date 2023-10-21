/* 1. Write an expression that checks whether an integer is odd or even.
Ans 1
bool isOddOrEven(int num) 
{
if (num % 2 == 0) 
{
Console.WriteLine("true");
} else 
{
Console.WriteLine("false");
}
} */

/*2.Write a Boolean expression that checks whether a given integer is 
divisible by both 5 and 7, without a remainder.
Ans 2
int x = 5;
int y = 7;
Console.WriteLine("Enter your num");
int num = int.Parse(Console.ReadLine()!);
if ((num % 5 == 0) && (num % 7 == 0))
{
    Console.WriteLine("True");
} */

/*3.Write an expression that looks for a given integer if its third digit (right 
to left) is 7.
Ans =
int hasThirdDigitOf7(int num) 
{
return num % 100 == 7;
} */

/*4. Write an expression that checks whether the third bit in a given integer 
is 1 or 0.
Ans = 
int hasThirdBitOf1(int num) 
{
return (num & 0b00001110) == 0b00001110;
} */

/*5. Write an expression that calculates the area of a trapezoid by given 
sides a, b and height h.
Ans 5
double trapezoidArea(double a, double b, double h) 
{
return (a + b) * h / 2;
} */

/*6. Write a program that prints on the console the perimeter and the area 
of a rectangle by given side and height entered by the user.
Ans 6
Console.Write("Enter the length of the rectangle: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Enter the height of the rectangle: ");
int height = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The perimeter of the rectangle is {2 * (length + height)}");
Console.WriteLine($"The area of the rectangle is {length * height}."); */

/*7.The gravitational field of the Moon is approximately 17% of that on the 
Earth. Write a program that calculates the weight of a man on the 
moon by a given weight on the Earth.
Ans 7 
Console.Write("Enter your weight on Earth: ");
double weightOnEarth = double.Parse(Console.ReadLine()!);
Console.WriteLine("Your weight on the Moon is approximately {0} lb.",
weightOnEarth * 0.17); */

/*8. Write an expression that checks for a given point {x, y} if it is within 
the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
the circle and 5 is the radius.
Ans
x^2 + y^2 <= 25 //This expression can uses the Pythagorean theorem to check whether the distance between the given point and the center of the circle is less than or equal to the radius. */

/*9.Write an expression that checks for given point {x, y} if it is within the 
circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
Clarification: for the rectangle the lower left and the upper right corners 
are given.
Ans */

/* 10.Write a program that takes as input a four-digit number in format abcd
(e.g. 2011) and performs the following actions:
- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
- Prints on the console the number in reversed order: dcba (in our 
example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example 
2101)
Ans 
Console.WriteLine("Enter a four-digit number: ");
int number = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = number - 1; i >= 0; i--) 
{
sum += (number - '0');
}
Console.WriteLine($"Sum of digits: {sum}"); */

/*11. We are given a number n and a position p. Write a sequence of 
operations that prints the value of the bit on the position p in the 
number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
p=6 -> 0.
Ans 
int n = 35; // 00100011
int p = 6;
int i = 1; // 00000001
int mask = i << p; // Move the 1-st bit left by p positions
// If i & mask are positive then the p-th bit of n is 1
Console.WriteLine((n & mask) != 0 ? 1 : 0); */

/* 12.Write a Boolean expression that checks if the bit on position p in the 
integer v has the value 1. Example v=5, p=1 -> false.
Ans 
(v & (1 << p)) != 0 */

/*13We are given the number n, the value v (v = 0 or 1) and the position p. 
write a sequence of operations that changes the value of n, so the bit on 
the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
Another example: n=35, p=2, v=1 -> n=39.
Ans
1. Convert n to a binary number using BitConvert then you Set the bit at position p to v using the bitwise OR operator (|). After that Convert the binary number back to a decimal number using BitConvert.And you can then Set n to the result of the conversion. */

/*14.Write a console program that checks if a given number n (1 < n < 100) is a 
prime number (i.e. it is divisible without remainder only to itself and 1).
Ans 
bool IsPrime(int n)
{
    if (n <= 1) return false;
    {
        return false;
    }
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0) return false;
        return true;
    }
}
Console.WriteLine("Enter an integer (1 < n < 100): ");
int n = int.Parse(Console.ReadLine()!);
if (IsPrime(n))
{
    Console.WriteLine("{0} is a prime number", n);
}
else
{
    Console.WriteLine("Sorry this is not a prime number");
} */

/*15.* Write a program that exchanges the values of the bits on positions 
3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
integer.
Ans */

/*16.* Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
q+1, …, q+k-1} of a given 32-bit unsigned integer.
Ans */
