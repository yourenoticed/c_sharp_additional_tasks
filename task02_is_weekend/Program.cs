Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Invalid numeric representation of a day of the week");
}
else if (1 <= number && number <= 5)
{
    Console.WriteLine("Number " + number + " represents weekday");
}
if (5 < number && number < 8)
{
    Console.WriteLine("Number " + number + " represents weekend");
}
