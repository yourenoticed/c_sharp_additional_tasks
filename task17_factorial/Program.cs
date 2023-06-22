Console.Write("Enter a number you want to find a factorial with: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
if (number >= 1)
{
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("Factorial of " + number + " is " + factorial);
}
else Console.WriteLine("Enter a valid number for finding factorial");