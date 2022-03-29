
int Max(int arg1, int arg2, int arg3) //Придумали название фукции(желательно, чтобы оно было интуитвно понятным)
{
    int result = arg1;
    if (arg2 > result) result = arg2; //Описываем, какие данные ф-ция принимает и какие операции с ними делает
    if (arg3 > result) result = arg3;
    return result; //Возврат результата
}
int[] array = {2, 45, 32, 12, 43, 21, 56, 78, 41};
array[1] = 124;

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])); //Передача ф-ции внутри аргумента. Отсылка к 
//функциональному прораммированию.
Console.WriteLine(result);