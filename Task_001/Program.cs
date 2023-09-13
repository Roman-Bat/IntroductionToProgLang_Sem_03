/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта точка.*/

// выводим пользователю предложение и принимаем ввод числа 
int Promt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

// проверяем полученные числа на неравенство с нулём, иначе четверть будет не определить
bool CheckZero (int x, int y)
{
    if (x == 0 || y == 0) return false; 
    else return true;
}
// находим четверть в которой находятся числа
int QuarterCircle (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else return 4;
}

int x = Promt ("Введите число Х не равное нулю: ");
int y = Promt ("Введите число Y не равное нулю: ");
if (CheckZero(x, y) == true) Console.Write("Вы ввели числа" + " х = " + x + " y = " + y + " Четверть координат: " + QuarterCircle(x, y));
else Console.Write("Одно из чисел равно нулю");