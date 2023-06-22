Console.Write("Enter a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 9999) && (number < 100000))
{
    int digit1 = number / 10000;
    int digit2 = number % 10000 / 1000;
    int digit4 = number % 100 / 10;
    int digit5 = number % 10;
    if ((digit1 == digit5) && (digit2 == digit4))
    {
        Console.WriteLine("Number " + number + " is a palindrome");
    }
    else
    {
        Console.WriteLine("Number " + number + " isn't a palindrome");
    }
}
else
{
    Console.WriteLine("You were asked for a five-digit number");
}
