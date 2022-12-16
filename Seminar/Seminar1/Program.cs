//===================== task 1 ========================================

// Console.Write("Enter your name: ");
// string test = Console.ReadLine();

// Console.Write("How old are you: ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("after 6 years you will be "+ (age+6) + " years old");

//===================== task 2 ========================================

// Console.Write("Enter your number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Square of number {numb} is {numb * numb}");
// // Console.WriteLine("Square of number" + numb + " is " + (numb*numb));

//====================== task 3 ========================================
//Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.

// Console.Write("Enter 1st number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2d number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2) Console.WriteLine("1st number is Square of 2d number");
// else Console.WriteLine("1st number is not  Square of 2d number");

//====================== task 4 ========================================
//Напишите программу, котороая будет вызывать название
// дня недели по заданному номеру

// Console.Write("Enter number of week: ");
// int numberOfWeek = Convert.ToInt32(Console.ReadLine());

// if     (numberOfWeek == 1) Console.Write("Today is Monday");
// else if(numberOfWeek == 2) Console.Write("Today is Tuesday");
// else if(numberOfWeek == 3) Console.Write("Today is Wednesday");
// else if(numberOfWeek == 4) Console.Write("Today is Thursday");
// else if(numberOfWeek == 5) Console.Write("Today is Friday");
// else if(numberOfWeek == 6) Console.Write("Today is Saturday");
// else if(numberOfWeek == 6) Console.Write("Today is Suday");
// else Console.Write("Entered number is wrong");


//======================== task 5 ===================================
//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int negativNum = num*(-1);

// while(negativNum <= num){
//     Console.Write($"{negativNum} ");
//     negativNum ++;
// }

//======================== task 6 ===================================
// Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("Enter a three-digit number: ");
// int num = Convert.ToInt32(Console.Read());
// if(num > 100 && num < 1000)  Console.Write(Convert.ToString(num%10));
// else Console.Write("The entered number is not a three-digit number!");
