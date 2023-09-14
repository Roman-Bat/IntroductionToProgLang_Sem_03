/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      int qadro = 0;
     for (int i = 1; i <= N; i ++)
     {
        qadro = (i*i);
        Console.WriteLine(qadro);
     }

    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}