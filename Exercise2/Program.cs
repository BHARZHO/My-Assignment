/*1. Declare several variables by selecting for each one of them the most 
appropriate of the types sbyte, byte, short, ushort, int, uint, long
and ulong in order to assign them the following values: 52,130; -115; 
4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
1990; 123456789123456789
Ans 1
short myShort = 52130;
sbyte mySbyte = -115;
int myInt = 4825932; 
uint myUnit = 97;
ushort myUshort = -10000;
long myLong = 20000;
ulong myUlong = 224;
int mySecondNum = 970700000;
short myShort = 112;
ushort mySecondUshort = -44;
uint myUInt = -1000000;
long mySecondLong = 1990;
ulong mySecondULong = 123456789123456789;
*/

/*2. Which of the following values can be assigned to variables of type float, 
double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
3456.091124875956542151256683467?
Ans 2
5 can be assign to data type float and double but not decimal
5.01 can be assign to the three data types thats given
34.567839023 can also be assign to the three data types given
12.345 can be assign to float and double but not decimal
8923.1234857 can also be assign to the three data types given
3456.091124875956542151256683467 can also be assign to the three data types given
*/

/*3. Write a program, which compares correctly two real numbers with 
accuracy at least 0.000001.
Ans 3 
float number1 = 3.1415F;
double number2 = 3.1415;
if (number1 - number2 < 0.000001)
{
Console.WriteLine("The two numbers are equal.");
}
else
{
Console.WriteLine("The two numbers are not equal.");
}
*/

/*4. Initialize a variable of type int with a value of 256 in
hexadecimal format (256 is 100 in a numeral system with base 16).
int n = 0x100; // n is now initialized with 256 in hex.The "0x" prefix tells the compiler that the following number which is 100 is in hexadecimal format
*/

/*5.Declare a variable of type char and assign it as a value the character, 
which has Unicode code, 72 (use the Windows calculator in order to find 
hexadecimal representation of 72).
Ans 5
char c = 0x48; // c is now the character with Unicode code 72
*/

/*6.Declare a variable isMale of type bool and assign a value to it depending 
on your gender.
Ans 6
bool isMale = true; // isMale is now set to true
*/

/*7.Declare two variables of type string with values "Hello" and "World". 
Declare a variable of type object. Assign the value obtained of 
concatenation of the two string variables (add space if necessary) to this 
variable. Print the variable of type object.
Ans 7 
string firstWord = "Hello";
string secondWord = "World";
object combineOfTheBothWord;
combineOfTheBothWord = firstWord + " " + secondWord;
*/

/*8.Declare two variables of type string and give them values "Hello" and 
"World". Assign the value obtained by the concatenation of the two 
variables of type string (do not miss the space in the middle) to a 
variable of type object. Declare a third variable of type string and 
initialize it with the value of the variable of type object (you should use 
type casting)
Ans 8
string s1 = "Hello";
string s2 = "World";
object o = string(s1 + " " + s2); // o is now "Hello World"
string s3 = strimg(o); // s3 is now "Hello World"
*/

/*9.Declare two variables of type string and assign them a value “The 
"use" of quotations causes difficulties.” (without the outer quotes). 
In one of the variables use quoted string and in the other do not use it.
Ans 9
string s1("\"My \"name\" is Abdulbasit.\"");
string s2("My "Name" is Abdulbasit.");
*/

/*10.Write a program to print a figure in the shape of a heart by the sign "o"
*/

/*11.Write a program that prints on the console isosceles triangle which 
sides consist of the copyright character "©".
*/

/*12.A company dealing with marketing wants to keep a data record of its 
employees. Each record should have the following characteristic – first 
name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
(27560000 to 27569999). Declare appropriate variables needed to 
maintain the information for an employee by using the appropriate data 
types and attribute names.
Ans 12
string firstName;
string lastName;
int age;
char gender;
int employeeNumber;
*/

/*13.Declare two variables of type int. Assign to them values 5 and 10 
respectively. Exchange (swap) their values and print them
Ans 13
int a = 5;
int b = 10;

int temp = a;
a = b;
b = temp;
// print the values of the variables
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
*/





