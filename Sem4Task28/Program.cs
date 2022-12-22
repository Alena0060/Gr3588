// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

long CalcFactor(int num)
{
    long count = 1;
    for(int i=1;i<=num;i++)
    {
        count *= i;
    }
    return count;
}

int number = ReadData("input number:");

long length1 = CalcFactor(number);

PrintData("the factorial is equal to " + length1);