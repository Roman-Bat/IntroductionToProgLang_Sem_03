/* Напишите программу, которая по заданному номеру четверти, показывает
диапазон возможных координат точек в этой четверти (x и y). */

// Дилог с пользователем и получение номера четверти
int TalkUser (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
// Проверка на существование введённой четверти
bool CheckRange (int number)
{
    if (number < 1 || number > 4) return false;
    else return true;
}

string RangeNumber (int quarter, string num)
{
    if (quarter == 1 && num == "x") return "+"; 
    else if (quarter == 1 && num == "y") return "+";
    else if (quarter == 2 && num == "x") return "-";
    else if (quarter == 2 && num == "y") return "+";
    else if (quarter == 3 && num == "x") return "-";
    else if (quarter == 3 && num == "y") return "-";
    else if (quarter == 4 && num == "x") return "+";
    else if (quarter == 4 && num == "y") return "-";
    else return "0";
}

int quarter = TalkUser("Введите четверть: ");
if (CheckRange(quarter) == true)
{
    Console.Write("Диапазон чисел Х = " + RangeNumber(quarter, "x") + " бесконечность, до " + " Y = " +  RangeNumber(quarter, "y") + " бесконечность");
}
else Console.Write("Нет такой четверти");

