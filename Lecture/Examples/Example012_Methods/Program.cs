//string username = Console.ReadLine();
// type 1
// void Method1()
// {
//     Console.WriteLine("Hello ...");
// }

// Method1();

//type 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("text of message");
// Method2(msg:"message's text");

//type 21
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21("text", 4);
// Method21(count:4, msg:"TEXT");

// //type 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//type 4
// string Method4(int count, string text)
// {
//     int i = 0;
//     //string result = "";
//     string result = string.Empty;
//     while(i <= count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(4, "c");
// Console.WriteLine(res);

//цикл for

// string Method41(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method41(10, "c");
// Console.WriteLine(res);

// //таблица умножения
// for (int i = 0; i < 10; i++)
// {
//     for(int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine("");
// }

/*
Задача:
    Дан текст. В тексте нужно заменить все пробелы черточками, маленькие буквы "к" 
    заменить большими "К", а большие "С" заменить на маленькие "с"

    вопросы:
    Что значит дан текст (где взять)
    Что значит черточки
    Какой алфавит (с буквами  К есть различия в английском)
*/

string text = "- Я думаю - сказал князь, улыбаясь, - что,"
            + "ежели бы вы послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;

    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + newValue;
        else result = result + text[i];
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
