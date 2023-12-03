int Len (string message) // ф-я ввода кол-ва строк которые будет вводит П(пользователь)
{
    Console.WriteLine(message); // Здесь мы можем гапистаь сообщение перед тем как П сможет что то ввести
    string value = Console.ReadLine(); // считывает с ввод с консоли
    int result = Convert.ToInt32(value); // преобразует строку в int
    return result;
}

string Str (string message) // ф-я ввода самих строк
{
    Console.WriteLine(message);
    string result = Console.ReadLine(); // считывает с ввод с консоли
    return result;
}

string[] InputArray(int length) // ф-я заполнения пользовательского массива
{
    string[] array = new string[length]; // создаём массив куда будем кидать то что ввёл П
    for (int i = 0; i < array.Length; i++) // цикл ввода для каждого индекса
    {
        array[i] = Str($"Введите {i + 1}-й элемент: ");
    }
    return array; // возвр-м П массив
}


void PrintArray(string[] array) //ф-я вывода П массива на экран
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
    Console.WriteLine(result); // выводим П массив на экран
}

int length = Len("Введите кол-во элементов: ");
string[] array;
array = InputArray(length);

Console.Write("Пользовательский массив - ");
PrintArray(array);