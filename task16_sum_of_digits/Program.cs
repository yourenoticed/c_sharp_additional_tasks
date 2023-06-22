Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digits_sum = 0;
int dividing_number = Convert.ToInt32(number);
while (dividing_number > 0)
{
    digits_sum += dividing_number % 10;
    dividing_number /= 10;
}
Console.WriteLine("The sum of digits of number " + number + " is " + digits_sum);