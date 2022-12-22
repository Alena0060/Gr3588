// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("input number: ");
//string number = Console.ReadLine();
//int len = number.Length;

//if (len == 5)
//{
//    if (number[0] == number[4] && number[1] == number[3])
//    {
//        Console.WriteLine($"{number} - Palindrome");
//    }
//    else
//    {
//        Console.WriteLine($"{number} - not a palindrome");
//    }
//}
//else
//{
//    Console.WriteLine($"mistake: {number} - is not a five - digit");
//}


Console.Clear();
 
void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Yes");
            }
            else 
            Console.WriteLine("No");
            
    }
    else
    Console.WriteLine("Invalid number!");
}
 
Console.WriteLine("Enter a five-digit number:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);
