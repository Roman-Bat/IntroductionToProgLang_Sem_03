/*
 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
int[] TalkUser(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    string[] number_arr = number.Split();
    int[] Vector = new int[] { int.Parse(number_arr[0]), int.Parse(number_arr[1]) } ;
    return Vector ;
}

double LenghtLine(int[] Vector_A, int[] Vector_B)
{
    int catet_A = Vector_B[0] - Vector_A[0];
    int catet_B = Vector_B[1] - Vector_A[1];
    double gepotenuza_C = Math.Sqrt((catet_A * catet_A) + (catet_B * catet_B));
    return gepotenuza_C;

}

int[] Vector_A = TalkUser("Введите координаты числа A через пробел: ");
int[] Vector_B = TalkUser("Введите координаты числа B через пробел: ");
double gepotenuza_C = LenghtLine(Vector_A, Vector_B);
Console.WriteLine("Найдем расстояние между точками A (" + Vector_A[0] + "," + Vector_A[1] + ") и B (" + Vector_B[0] + "," + Vector_B[1] + ")");
Console.WriteLine("Для этого воспользуемся правилом прямоугольного треугольника и теоремой Пифогора: ");
Console.WriteLine("Получим длины катетов вычтя из координат точки B координаты точки А по правилу вычитания векторов: (" + Vector_B[0] + ") - (" + Vector_A[0] + ") и (" + Vector_B[1] + ") - (" + Vector_A[1] + ")");
Console.WriteLine("Возведём полученные координаты в квадрат, сложим и вычислим корень получив расстояние между точками: ");
Console.Write(gepotenuza_C);