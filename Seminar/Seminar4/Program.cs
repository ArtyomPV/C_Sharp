/*
1. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
*/

/*
2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

// int[] CreateArray (int size, int minValue, int maxValue){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
        
//     }
//     return array;
// }

// int[] ChangeSing(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         //array[i] = array[i]*-1;
//         array[i] *= (-1);
//     }
//     return array;
// } 

// void Showarray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int size = 12;
// int min = -9;
// int max = 9;
// int [] array = CreateArray(size, min, max);
// Showarray(array);
// ChangeSing(array);
// Showarray(array);

/*
2. Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] CreateArray (int size, int minValue, int maxValue){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
        
    }
    return array;
}



bool SeekNumber(int[] array, int number){
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number){
            return true;
        }
        
    }
    return false;
}

void Showarray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//int size = 12;
int min = -9;
int max = 9;
Console.WriteLine("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

//int number = 5;
int [] array = CreateArray(size, min, max);
Showarray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"The number {number} is here? - ");
if(SeekNumber(array, number)){
    Console.Write("Yes");
}
else{
    Console.Write("No");
}