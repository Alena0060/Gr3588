// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2 3 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("maximum number: " + firstNumber);
    }
    else
    {
        Console.WriteLine("maximum number: " + thirdNumber);
        
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("maximum number: " + secondNumber);
}
else
{
    Console.WriteLine("maximum number: " + thirdNumber);
}