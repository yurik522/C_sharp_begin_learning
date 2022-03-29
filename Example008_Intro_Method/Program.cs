// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Max(int arg1, int arg2, int arg3) //Придумали название фукции(желательно, чтобы оно было интуитвно понятным)
{
    int result = arg1;
    if (arg2 > result) result = arg2; //Описываем, какие данные ф-ция принимает и какие операции с ними делает
    if (arg3 > result) result = arg3;
    return result; //Возврат результата
}
int a1 = 45;
int b1 = 4;
int c1 = 15;
int a2 = 24;
int b2 = 41;
int c2 = 10;
int a3 = 90;
int b3 = -119;
int c3 = 84;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); //Передача ф-ции внутри аргумента. Отсылка к 
//функциональному прораммированию.
Console.WriteLine(max);