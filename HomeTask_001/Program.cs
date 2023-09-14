/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
using System;
public class Answer
{
    static bool IsPalindrome(int number){
     int LengthNumber = number.ToString().Length;
     if (LengthNumber == 5)
     {
     int[] massiveNumber = new int[LengthNumber];
     int index = 0; 
     while (number != 0)
    {
        massiveNumber[index] =  number % 10;
        number /= 10;
        index ++;
    }
    index = 0;
    while (index < LengthNumber / 2)
    {
        if (massiveNumber[index] == massiveNumber[LengthNumber-(index+1)]) 
        {
            index ++;
            continue;
        }
        else return false; 
    }   
     return true; 
     }
     else 
     {
            Console.WriteLine("Число не пятизначное");
            return false;
     }
    }
  
       static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}