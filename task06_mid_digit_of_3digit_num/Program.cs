Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int result = number % 100 / 10;
    Console.WriteLine("The second digit of the number " + number + " is " + result);
}
else
{
    Console.WriteLine("You were asked for a three-digit one");
}
