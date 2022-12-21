// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if (inputLine != null)
{

    // Парсим введеное число
    int inputNumber = int.Parse(inputLine);

    int starNumber = inputNumber * (-1);

    //Выходное значение
    string outLine = string.Empty;

    while(starNumber<inputNumber)
    {
        outLine = outLine + starNumber + ",";
        starNumber++;
        // starNumber = starNumber+1;
    }
    outLine = outLine + inputNumber;

    //выводим данные в консоль
    Console.WriteLine(outLine);
}