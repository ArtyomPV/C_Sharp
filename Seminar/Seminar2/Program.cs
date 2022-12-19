/*
Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
 элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] CreateArray (int size, int minValue, int maxValue){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
        
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindPosSumm(int[] array){
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i] > 0) summ += array[i];   
    }
    return summ;
}

int FindNegSumm(int[] array){
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if(array[i] < 0) summ += array[i];   
    }
    return summ;
}

int size = 5;
int min = -9;
int max = 9;
int[] array = CreateArray(size, min, max);
ShowArray(array);
Console.WriteLine($"Summ of positive numbers is {FindPosSumm(array)}");
Console.WriteLine($"Summ of negative numbers is {FindNegSumm(array)}");