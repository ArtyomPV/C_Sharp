//================== task 1 =====================
/*
Напишите программу, которая принимает 
на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 
 и выдаёт номер четверти плоскости, 
 в которой находится эта точка.
*/

// void SearchQuater(int x, int y)
// {
//     if(x == 0 || y == 0)
//         Console.WriteLine("Error");
//     else if (x > 0 && y > 0)
//         Console.WriteLine("Точка находится в первой четверти");
//     else if (x < 0 && y > 0)
//         Console.WriteLine("Точка находится во второй четверти");
//     else if (x < 0 && y <  0)
//         Console.WriteLine("Точка находится в третьей четверти");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("Точка находится в четвертой четверти");
// }

// Console.Write ("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write ("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// SearchQuater(x, y);

//===================== task 2 =======================
/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).

*/

//  void SearchCoordinata(int quater){
//     if(quater == 1) Console.WriteLine("X > 0 and Y > 0");   
//     else if(quater == 2) Console.WriteLine("X < 0 and Y > 0");
//     else if(quater == 3) Console.WriteLine("X < 0 and Y > 0");
//     else if(quater == 4) Console.WriteLine("X > 0 and Y < 0");
//     else Console.WriteLine("Error");
//  }

//  Console.WriteLine("Введите номер четверти - ");
//  int number  = Convert.ToInt32(Console.ReadLine());

//  SearchCoordinata(number);
 
//======================= task 3 =========================
 /*
 Напишите программу, которая принимает на вход число (N) 
 и выдаёт таблицу квадратов чисел от 1 до N

 */

//  Console.Write("Введите  число - ");
//  int number  = Convert.ToInt32(Console.ReadLine());

// void ShowTable(int num){
//     //int count = 0;
//     for(int i = 0; i<= num; i++){
//         int count=i*i;
//         Console.Write($"{count} ");
//     }
// }

// ShowTable(number);


//======================== task 4 ===========================
/*
Напишите программу, которая принимает 
на вход координаты двух точек и находит
 расстояние между ними в 2D пространстве.
Быстрый ответ
l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2
*/

double CalcDistance(int x1, int x2, int y1, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
    return distance; 
}

Console.Write("Введите координату x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());

double dis = CalcDistance(x1, x2, y1, y2);
Console.WriteLine($"distance is {Math.Round(dis, 2)}");