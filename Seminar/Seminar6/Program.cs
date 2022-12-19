// //напишите программу, которая перевернет одномерный массив
// // (Последний будет на первом местеб а первый на последнем и т.д.)


// int[] CreateArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         //создание массива с запятой
//         //array[i] = new Random().NextDouble()*100;
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// // void ShowArray(int[] array){
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write($"{array[i]} ");
// //     }
// //     Console.Write();
// //}
//  void ShowArray(int[] array)
// {
//     int size = array.Length;
//     Console.Write("{");
//     for(int i = 0; i < size; i++)
//     {
//         if (i == size-1) Console.Write($"{array[i]} ");
//         else Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine("}");
// }

// int[] ReverseArray(int[] array){
//     int l = array.Length;
//     for (int i = 0; i < l/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[l-1-i];
//         array[l-1-i] = temp;
//     }
//     return array;
// }

// Console.Write("Enter array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter array min element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter array max element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// ShowArray(array);
// int[] reverse = ReverseArray(array);
// ShowArray(array);
int num = 45;
Console.Write(num%2);