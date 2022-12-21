// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Считываем даннфе с консоли
string? inputLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
//Создаем массив с днями недели
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Monday";
dayOfWeek[1] = "Tuesday";
dayOfWeek[2] = "Wednesday";
dayOfWeek[3] = "Thursday";
dayOfWeek[4] = "Friday";
dayOfWeek[5] = "Saturday";
dayOfWeek[6] = "Sunday";

//Парсим введеное число
int inputNumber = int.Parse(inputLine);

//находим название дня недели по введеному номеру
string outDayOfWeek = dayOfWeek[inputNumber-1];

//Выводим данные в консоль
Console.WriteLine(outDayOfWeek);
}
