Console.Write("Enter a 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (100 <= number && number < 1000)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("You were asked for a three-digit one");
}
