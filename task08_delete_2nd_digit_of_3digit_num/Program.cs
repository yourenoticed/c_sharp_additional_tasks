Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int digit1 = number / 100;
    int digit3 = number % 10;
    int result = digit1 * 10 + digit3;
    Console.WriteLine("The number " + number + " without the second digit is " + result);
}
else
{
    Console.WriteLine("You were asked for a three-digit number");
}