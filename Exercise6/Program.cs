/*Write a program that prints on the console the numbers from 1 to N. 
The number N should be read from the standard input.
Ans  
int N;
int i;
Console.WriteLine("Enter the any number of your choice from (1 - 999): ");
N = int.Parse(Console.ReadLine()!);
for(i = 1;i <=N;i++)
{
    Console.WriteLine(i);
}  */

/*2.Write a program that prints on the console the numbers from 1 to N, 
which are not divisible by 3 and 7 simultaneously. The number N 
should be read from the standard input.
Ans  
{
    int N, i;
    Console.WriteLine("Enter a number (1-999): ");
    N = int.Parse(Console.ReadLine()!);
    for (i = 1; i <= N; i++)
    {
        if (i % 3 == 0 || i % 7 == 0)
        {
            continue;
        }
        else
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}      */  
/*3.Write a program that reads from the console a series of integers and 
prints the smallest and largest of them.
Ans   
{
int numbers;
int min = int.MaxValue;
int max = int.MinValue;

Console.WriteLine("Enter numbers: ");
numbers = int.Parse(Console.ReadLine()!);
for (int i = 0; i < numbers; i++)
{
numbers  = int.Parse(Console.ReadLine()!);
}
if (numbers < min)
{
min = numbers;
}
if (numbers > max)
{
max = numbers;
}
Console.WriteLine($"The smallest number is {min} and the largest is {max}.");
}     /

/*4.Write a program that prints all possible cards from a standard deck
of cards, without jokers (there are 52 cards: 4 suits of 13 cards)
Ans  

int suit;
int card;
string cardName;
int numCards = 52;
Console.WriteLine("Printing the cards in a standard deck, suit by suit:");
for (suit = 1; suit <= 4; suit++)
{
Console.WriteLine($"Printing the {suit} suit:");
numCards--;
}
for (card = 1; card <= 13; card++)
{
cardName = "$" + suit + card.ToString();
Console.WriteLine($"{cardName}");
}
Console.WriteLine();
numCards = 52; */

/*5.Write a program that reads from the console number N and print the sum 
of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
13, 21, 34, 55, 89, 144, 233, 377, …
Ans      */
Console.WriteLine("Enter your n: ");

long n = long.Parse(Console.ReadLine()!);
long result = Question5(n);
Console.WriteLine(result);

