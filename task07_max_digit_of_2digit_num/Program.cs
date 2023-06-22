Console.Write("Enter a 2-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9 && number < 100)
{
    int digit1 = number / 10;
    int digit2 = number % 10;
    if (digit1 > digit2)
    {
        Console.WriteLine(digit1 + " is bigger than " + digit2);
    }
    else if (digit2 > digit1)
    {
        Console.WriteLine(digit2 + " is bigger than " + digit1);
    }
    else Console.WriteLine("The digits of the number " + number + " are equal");
}
else
{
    Console.WriteLine("You were asked for a two-digit number");
}