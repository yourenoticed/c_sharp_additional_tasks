Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
}
else
{
    for (int i = number; i <= 1; i++)
    {
        sum += i;
    }
}
Console.WriteLine("Sum from 1 to " + number + " is " + sum);