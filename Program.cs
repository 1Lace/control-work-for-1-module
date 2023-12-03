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