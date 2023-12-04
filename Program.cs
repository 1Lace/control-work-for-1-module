

int Len (string message) // ф-я ввода кол-ва строк которые будет вводит П(пользователь)
{
    Console.WriteLine(message); // Здесь мы можем написать сообщение перед тем как П сможет что то ввести
    int result = Convert.ToInt32(Console.ReadLine()); // считывает с ввод с консоли и преобразует строку в int
    return result;
}

string EnteringLines (string message) // ф-я ввода самих строк
{
    Console.WriteLine(message);
    string result = Console.ReadLine(); // считывает ввод с консоли
    return result;
}

string[] InputArray(int length) // ф-я заполнения пользовательского массива
{
    string[] array = new string[length]; // создаём массив куда будем кидать то что ввёл П
    for (int i = 0; i < array.Length; i++) // цикл ввода для каждого индекса
    {
        array[i] = EnteringLines($"Введите {i + 1}-й элемент: ");
    }
    return array; // возвр-м П массив
}


void PrintArray(string[] array) //ф-я вывода массива на экран
{
    string result = "["; // создаём пер-нную куда будем кидать визуально карсивый массив. Сначала добавляем левую квадратную скобку
    for (int i = 0; i < array.Length; i++) // цикл на добавление Двойных ковычек
    {
        result += "\"" + array[i] + "\"";
        if (i != array.Length - 1) // проверка на конец массива. Если массив еще не закончился, то мы добавляем еще 1 запятую
        {
            result += ", "; // доб-ем запятую
        }
    }
    result += "]"; // если массив проверку не прошёл значит он закончился и мы можем добавить правую квадратную скобку
    Console.Write(result); // выводим П массив на экран
}


string[] СheckingForThreeCharacters(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] FixedArray = new string[count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            FixedArray[index++] = array[i];
        }
    }
    return FixedArray;
}

int length = Len("Введите кол-во элементов: ");
string[] array;
array = InputArray(length);

PrintArray(array);
Console.Write(" → ");
СheckingForThreeCharacters(array);
PrintArray(СheckingForThreeCharacters(array));
