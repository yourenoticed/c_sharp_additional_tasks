Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int divisible_num = number;
int count = 0;
while (divisible_num > 0)
{
    divisible_num /= 10;
    count += 1;
}
Console.WriteLine("Amout of digits in " + number + " is " + count);