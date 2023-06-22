Console.Write("Enter a number you want to check if it's a divisor: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number you want to check if it's divible by " + number1 + ": ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 % number1 == 0)
{
    Console.WriteLine("Number " + number2 + " is divisible by " + number1);
}
else
{
    int remainder = number2 % number1;
    Console.WriteLine(number2 + " is not divisible by " + number1);
    Console.WriteLine("The remainder of division " + number2 + "/" + number1 + " is equal to " + remainder);
}
