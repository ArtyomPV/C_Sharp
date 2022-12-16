//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.


// int [] CreateArray(int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void ShowArray(int [] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }


// int FindPosSumm(int [] array){
//     int summ = 0;
//     for(int i = 0; i< array.Length; i++){
//         if(array[i]>0)
//             summ += array[i];
//     }
//     return summ;
// }

// int FindNegSumm(int [] array){
//     int summ = 0;
//     for(int i = 0; i< array.Length; i++){
//         if(array[i]<0)
//             summ += array[i];
//     }
//     return summ;
// }

// bool FindNumber(int [] array, int numb){
//     bool flag = false;
//     for(int i = 0; i< array.Length; i++)
//         if(array[i] == numb)
//             flag = true;
//     return flag;
// }

// int size = 8;
// int min = -9;
// int max = 9;
// int numb = 4;
// int [] createdArray = CreateArray(size, min, max);
// ShowArray(createdArray);
// bool flag = FindNumber(createdArray, numb);
// if(flag == true) Console.Write("Yes");
// else Console.Write("No");
// Console.WriteLine($"Summ of positive numbers is {FindPosSumm(createdArray)}");
// Console.WriteLine($"Summ of negative numbers is {FindNegSumm(createdArray)}");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21