Console.WriteLine("Enter x coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("(" + x + "," + y + ") is in I quadrant");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("(" + x + "," + y + ") is in II quadrant");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("(" + x + "," + y + ") is in III quadrant");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("(" + x + "," + y + ") is in IV quadrant");
}
else Console.WriteLine("Can't define a quadrant, because either x or y is equal to zero");