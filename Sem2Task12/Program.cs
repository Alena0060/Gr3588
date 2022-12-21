// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
//кратным первому. Если второе число некратно первому, то программа выводит о статок от деления.
//34, 5 -> некратно, остаток 4
//16, 4 -> кратно

int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

int result = number2%number1;

if (result == 0)
{
    Console.WriteLine("The second number is divided by the first one without remainder");
}
else
{
    Console.WriteLine("The second number is not a multiple of the first. The remainder of the division " + result);
}
//Console.WriteLine(number1);
