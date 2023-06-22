Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}
else
{
    for (int i = 1; i >= number; i--)
    {
        Console.Write(Math.Pow(i, 2) + " ");
    }
}
