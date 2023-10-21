/*1.Write an if-statement that takes two integer variables and exchanges
their values if the first one is greater than the second one.
Ans 
int a = 23;
int b = 40;

if(a > b)
{
   Console.WriteLine($"a = {b}");
   Console.WriteLine($"b = {a}");
} */

/*2.Write a program that shows the sign (+ or -) of the product of three real 
numbers, without calculating it. Use a sequence of if operators.
Ans */

/*3.Write a program that finds the biggest of three integers, using nested 
if statements.
Ans 
int max = 0;
int number1 = 5;
int number2 = 7;
int number3 = 9;
if (number1 > number2)

if (number1 > number3)
{
max = number1;
}
else
{
if (number2 > number3)
max = number2;
}
else
{
max = number3;
}
Console.WriteLine("The biggest number is {0}", max);  */

/*4.Sort 3 real numbers in descending order. Use nested if statements.
Ans 
int num1 = 20, num2 = 30, num3 = 50;
int max = 100;
int min = 0;
if (num1 > num2)
{
if (num1 > num3)
max = num1;
else
min = num1;
}
else
{
if (num2 > num3)
max = num2;
else
min = num2;
}
Console.WriteLine($"Numbers sorted in descending order: {max}, {min}, {num3}");   */

/*5. Write a program that asks for a digit (0-9), and depending on the input, 
shows the digit as a word (in English). Use a switch statement
Ans  
int digit;
Console.WriteLine("Please enter a digit (0-9): ");
digit = int.Parse(Console.ReadLine()!);
switch (digit)
{
case 0:
Console.WriteLine("You entered zero.");
break;
case 1:
Console.WriteLine("You entered one.");
break;
case 2:
Console.WriteLine("You entered two.");
break;
case 3:
Console.WriteLine("You entered three.");
break;
case 4:
Console.WriteLine("You entered four.");
break;
case 5:
Console.WriteLine("You entered five.");
break;
case 6:
Console.WriteLine("You entered six.");
break;
case 7:
Console.WriteLine("You entered seven.");
break;
case 8:
Console.WriteLine("You entered eight.");
break;
case 9:
Console.WriteLine("You entered nine.");
break;
default:
Console.WriteLine("You didnt enterd the correct number");
break;
} */

/*6.Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
Quadratic equations may have 0, 1 or 2 real roots.
Ans  
double a , b, c, d , e;
double x1 = 2, x2 = 3;
Console.WriteLine("Enter the coefficient a: ");
a = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the coefficient b: ");
b = double.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the coefficient c: ");
c = double.Parse(Console.ReadLine()!);

if (b * b - 4 * a * c < 0)
Console.WriteLine("The equation has no real roots.");
else
{
d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
e = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
x1 = (-b + d) / (2 * a);
x2 = (-b - d) / (2 * a);
}

if (x1 < 0)
Console.WriteLine("The equation has one real root: {0}", x2);
else
{
Console.WriteLine("The equation has two real roots: {0} and {1}", x1, x2);
}    */

/*7.Write a program that finds the greatest of given 5 numbers.
Ans   */

/*8.Write a program that, depending on the user’s choice, inputs int, double
or string variable. If the variable is int or double, the program 
increases it by 1. If the variable is a string, the program appends "*" at 
the end. Print the result at the console. Use switch statement.
Ans    
Console.WriteLine("Please choose what to input: ");
string userChoice = Console.ReadLine()!;
switch (userChoice)
{
case "int":
int num = int.Parse(Console.ReadLine()!);
num++;
Console.WriteLine($"The number is now {num}.");
break;
case "double":
double value = double.Parse(Console.ReadLine()!);
value++;
Console.WriteLine($"The value is now {value}.");
break;
case "string":
string word = Console.ReadLine()!;
Console.WriteLine($"You enter the word {word}");
break;
}     */

/*9.We are given 5 integer numbers. Write a program that finds those 
subsets whose sum is 0. Examples:
- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
is 0.
- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
with sum 0
Ans */

/*10. Write a program that applies bonus points to given scores in the range 
[1…9] by the following rules:
- If the score is between 1 and 3, the program multiplies it by 10.
- If the score is between 4 and 6, the program multiplies it by 100.
- If the score is between 7 and 9, the program multiplies it by 1000.
- If the score is 0 or more than 9, the program prints an error 
message.
Ans  
int score;
Console.WriteLine("Enter a score (1-9): ");
score = int.Parse(Console.ReadLine()!);
if (score <= 0 || score >= 10)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Invalid score");
    Console.ResetColor();
    return;
}
switch (score)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine($"Your score was {score * 10} points.");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine($"Your score was {score * 100} points.");
        break;
    case 7:
    case 8:
    case 9:
        Console.WriteLine($"Your score was {score * 1000} points.");
        break;

}  */

/*11.* Write a program that converts a number in the range [0…999] to 
words, corresponding to the English pronunciation. Examples:
- 0 --> "Zero"
- 12 --> "Twelve"
- 98 --> "Ninety eight"
- 273 --> "Two hundred seventy three"
- 400 --> "Four hundred"
- 501 --> "Five hundred and one"
- 711 --> "Seven hundred and eleven"
Ans     */