// //Собрать строку с числами от a до b, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for(int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if(a<=b) return $"{a} " + NumbersRec(a+1, b);
//     else return string.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

//Сумма чисел от 1 д n
// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// // вычислить a в степени n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     //return n == 0 ? 1 : PowerRec(a, n - 1);
//     if(n == 0) return 1;
//     else return PowerRec(a, n-1)*a;
// }

// int PowerRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if(n%2 == 0) return PowerRecMath(a*a, n/2);
//     else return PowerRec(a, n-1)*a;
// }
// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));


//==========================================
// Перебор слов
//В некотором машинном алфавите имеются четыре буквы
//"а", "и", "с", "в". Покажите все слова состоящие из Т букв, которые можно построить из этих букв

// char [] s = {'a', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 for (int m = 0; m < count; m++)
//                 {
//                     Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// } 

int n = 0;  
void FindWords(string alphabet, char[] word, int length = 0)
{
    if(length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word) }"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length +1);
    }
}

FindWords("аисв", new char[2]);
