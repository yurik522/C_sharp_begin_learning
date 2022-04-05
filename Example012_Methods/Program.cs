// Вид 1
void Method1()
{
    Console.WriteLine("Автор: Юрий");
}

//Method1();

//Вид 2

void Method2(string msg, int arg)
{
   int i = 0;
    while (i < arg)
    {
      Console.WriteLine(msg);
      i++;  
    }
    
} 

// 1-Й СПОСОБ ВЫЗОВА МЕТОДА:

// string text = "1-й способ вызова метода";
// int count = 4;
//Method2(text, count);

//2-Й СПОСОБ ВЫЗОВА МЕТОДА:

//Method2("2-й способ вызова метода", 3);

//3-Й СПОСОБ ВЫЗОВА МЕТОДА:

//Method2(arg: 2, msg: "3-й способ вызова метода");

//Method1();

// 3-Й ВИД

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
//Console.WriteLine(year);

// 4-Й ВИД

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = text;
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "Я желаю всем счастья!");
// Console.WriteLine(res);


// string Method4(int count, string text)
// {
//     string result = text;
//     for (int i = 0; i < 10; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "Я желаю всем счастья!");
// Console.WriteLine(res);

// СОЗДАДИМ ТАБЛИЦУ УМНОЖЕНИЯ.

// for(int i =2; i < 10; i++)
// {
//     for(int j =2; j < 10; j++)
//     {
//        Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
//     }
//     Console.WriteLine();
// }
// ЗАДАЧА. РАБОТА НАД ТЕКСТОМ

// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие
// "С" заменить маленькими "с"

string Method5(string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";        
    }
    return result;
}

string OldText = "- Я думаю, - сказал князь , улыбаясь, - что, "
            +"ежели бы Вас послали вместо нашего милого Винценгероде, "
            +"Вы бы взяли приступом согласие прусского короля. "
            +"Вы так красноречивы. Вы дадите мне чаю?";
string NewText = Method5(OldText, OldValue: ' ', NewValue: '|');
Console.WriteLine(NewText);
NewText = Method5(NewText, OldValue: 'к', NewValue: 'К');
Console.WriteLine(NewText);
Console.WriteLine();
NewText = Method5(NewText, OldValue: 'с', NewValue: 'С');
Console.WriteLine(NewText);