//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int dayNumber = ReadInt("Enter a number from 1 to 7: ");
Console.WriteLine(WorkHoliday(dayNumber));


// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("The number " + a + " - Weekend");
        }
        else
        {
            Console.Write("The number " + a + " - Working ");
        }
    }
    else
    {
        Console.Write("the number is not in the range from 1 to 7");
    }
    return " day.";
}
