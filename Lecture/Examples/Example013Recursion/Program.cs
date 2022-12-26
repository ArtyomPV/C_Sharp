// int[,] matrix = new int[3,4];
// string[,] table = new string[2,5];

// table[1,2] = "word";
// for (int row = 0; row < 2; row++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//             Console.WriteLine($"-{table[row, columns]}-");
//     }
// }

// for(int i = 0; i<3; i++){
//     for(int j = 0; j < 4; j++){
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// for(int i = 0; i < matrix.GetLength(0); i++){
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// void PrintArray(int[,] matr){
//     for(int i = 0; i < matr.GetLength(0); i++){
//         for(int j = 0; j < matr.GetLength(1); j++){
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr){
//     for(int i = 0; i < matr.GetLength(0); i++){
//         for(int j = 0; j <matr.GetLength(1); j++){
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix1 = new int[3,4];
// PrintArray(matrix1);
// Console.WriteLine();
// FillArray(matrix1);
// PrintArray(matrix1);

//================= next step ========================
// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };


// void PrintImage(int[,] image){
//     for(int i = 0; i < image.GetLength(0); i++){
//         for(int j = 0; j < image.GetLength(1); j++){
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int column){
//     if(pic[row, column] == 0){
//         pic[row, column] = 1;
//         FillImage(row-1, column);
//         FillImage(row, column-1);
//         FillImage(row+1, column);
//         FillImage(row, column+1);
//     }

// }

// PrintImage(pic);
// FillImage(8,11);
// PrintImage(pic);


// int[,,] mas = { { { 1, 2 },{ 3, 4 } }, 
//                 { { 4, 5 }, { 6, 7 } }, 
//                 { { 7, 8 }, { 9, 10 } }, 
//                 { { 10, 11 }, { 12, 13 } }
//               };

// for(int i = 0; i < mas.GetLength(0); i++)
// {
//     Console.Write("{");
//     for(int j = 0; j < mas.GetLength(1); j++)
//     {
//         Console.Write("{");
//         for(int k = 0; k < mas.GetLength(2); k++)
//         {
//             Console.Write(mas[i,j,k]);
//             if(k < mas.GetLength(2)-1) Console.Write(" , ");
//         }    
//         Console.Write("}");
//         if(j < mas.GetLength(1)-1) Console.Write(" , ");
//     }
//     Console.Write("}");
//     if(i < mas.GetLength(0)-1) Console.Write(" , ");
// }

// //===============================================================
// double Factorial(int n){
//     // 1! = 0;
//     // 0! = 1;
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);

// }
// Console.Write(Factorial(10));

// for(int i = 1; i < 40; i++){
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

//===============================================================
//f(1) = 1
//f(2) = 2
//f(3) = f(1) + f(2)

int Fibonacci(int n){
    if(n == 1 || n == 0) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for(int i = 0; i<40; i++){
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}