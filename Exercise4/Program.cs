/*1.Write a program that reads from the console three numbers of type int
and prints their sum.
Ans */
Console.WriteLine("Enter any three number of your choice");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The sum of {a}, {b}, and {c} is {a + b + c}");

/*2. Write a program that reads from the console the radius "r" of a circle 
and prints its perimeter and area
Ans */
Console.WriteLine("Enter the radius: ");
double r = double.Parse(Console.ReadLine()!);
Console.WriteLine("The perimeter of the circle is {0}", 2 * Math.PI * r);
Console.WriteLine("The area of the circle is {0}", Math.PI * r * r);

/*3. A given company has name, address, phone number, fax number, web 
site and manager. The manager has name, surname and phone number.
Write a program that reads information about the company and its 
manager and then prints it on the console.
Ans */
Console.Write("Enter the company's name: ");
string companyName = Console.ReadLine()!;
Console.Write("Enter the company's address: ");
string address = Console.ReadLine()!;
Console.Write("Enter the company's phone number: ");
string phoneNumber = Console.ReadLine()!;
Console.Write("Enter the company's fax number: ");
string faxNumber = Console.ReadLine()!;
Console.Write("Enter the company's web site: ");
string companyWebsite = Console.ReadLine()!;
Console.Write("Enter the manager name:");
string manager = Console.ReadLine()!;
Console.Write("Enter your firstname: ");
string firstName = Console.ReadLine()!;
Console.Write("Enter youe second name: ");
string secondName = Console.ReadLine()!;
Console.Write("Enter your phone number:");
string number = Console.ReadLine()!;

Console.WriteLine($"The name of this company is {companyName},it is located at {address},You can reach our company by dailing {phoneNumber}. \nYou can also visit our website at {companyWebsite},The manager incharge of this branch is {manager}.\nIf you wish to join our company kindly fill in this form with the correct information:\nMy name is {firstName} {secondName}\nPhone Number:{number}");

/*4.Write a program that prints three numbers in three virtual columns
on the console. Each column should have a width of 10 characters and 
the numbers should be left aligned. The first number should be an 
integer in hexadecimal; the second should be fractional positive; and 
the third – a negative fraction. The last two numbers have to be 
rounded to the second decimal place.
Ans : */
Console.WriteLine(" ");
Console.WriteLine("{0:X2}", 123456);
Console.WriteLine("{0:F2}", 0.111111);
Console.WriteLine("{0:F2}", -0.111111);

/*5.Write a program that reads from the console two integer numbers (int)
and prints how many numbers between them exist, such that the 
remainder of their division by 5 is 0. Example: in the range (14, 25) 
there are 3 such numbers: 15, 20 and 25.
Ans
Console.WriteLine("Enter two numbers: ");
int start = int.Parse(Console.ReadLine()!);
int end = int.Parse(Console.ReadLine()!);
int count = 0;
for (int i = start; i <= end; i++)
{
    if (i % 5 == 0)
        count++;
}  */

/*6.Write a program that reads two numbers from the console and prints the 
greater of them. Solve the problem without using conditional 
statements.
Ans */
Console.WriteLine("Enter two numbers: ");
a = int.Parse(Console.ReadLine()!);
b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(a);
}
/*7.Write a program that reads five integer numbers and prints their 
sum. If an invalid number is entered the program should prompt the user 
to enter another number.
Ans */
Console.WriteLine("Enter any three number of your choice");
int e = int.Parse(Console.ReadLine()!);
int f = int.Parse(Console.ReadLine()!);
int g = int.Parse(Console.ReadLine()!);
int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The sum of {e}, {f}, {g}, {i} and {j} is {e + f + g + i + j}");
/*8.Write a program that reads five numbers from the console and prints the 
greatest of them
Ans 
int max = 0;
int num4, num2, num3, num4, num5;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Enter number {0}: ", i);
    num1 = int.Parse(Console.ReadLine());
}
if (num1 > max)
{
    max = num1;
}
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
} */

/*9.Write a program that reads an integer number n from the console. After 
that reads n numbers from the console and prints their sum
Ans 
int n = 0;
int sum = 0;
Console.WriteLine("Enter an integer: ");
n = int.Parse(Console.ReadLine()!);
for (int i = 0; i < n; i++)
{
sum += int.Parse(Console.ReadLine()!);
}
Console.WriteLine($"The sum of the numbers is {sum}.");  */

/*10.Write a program that reads an integer number n from the console and 
prints all numbers in the range [1…n], each on a separate line.
Ans 
int n, i = 1;
Console.WriteLine("Enter a number: ");
n = int.Parse(Console.ReadLine()!);
for (i = 1; i <= n; i++)
{
Console.WriteLine($"{i}");
}  */

/*11.Write a program that prints on the console the first 100 numbers in the 
Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
Ans */
int fibo = 0, nextFibo = 1, currFibo = 1, n = 0;
for (n = 1; n <= 100; n++)
{
currFibo = fibo + nextFibo;
nextFibo = fibo;
fibo = currFibo;
Console.WriteLine($"{n}: {fibo}");
}
/*12. Write a program that calculates the sum (with precision of 0.001) of 
the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
Ans */