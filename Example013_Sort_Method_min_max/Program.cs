// int[] arr = {1, 4, 3, 8, 2, 4, 7, 9, 11, 3, 2, 1};
// void PrintArray(int[] array) // метод вывода массива в консоль
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
    
// }
// void selectionSort(int[] array) //метод сортировки массива
// {
//     for(int i = 0; i < array.Length-1; i++)
//     {
//          int minPosition = i; //определяем рабочую позицию элемента
//                                 //над которым в дальнейшем будем производить
//                                 //какие-либо действия
//         for(int j = i + 1; j < array.Length; j++ )//мы не касаемся первого элемента массива,
//                                                   //поскольку он уже отсортирован
//         {
//             if(array[j] < array[minPosition]) minPosition = j;//ищем минимальный элемент
//         }
//         int temporary =   array[i];
//         array[i] = array[minPosition];//в i-ю позицию ложим элемент, который будет найден в процессе
//                                     //работы кода. Простой обмен двух переменных местами
//         array[minPosition] = temporary;                            
//     }
// }
// PrintArray(arr);
// selectionSort(arr);
// Console.WriteLine();
// PrintArray(arr);
int[] arr = {1, 4, 3, 8, 2, 4, 7, 9, 11, 3, 2, 1};
void PrintArray(int[] array) 
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();    
}
void selectionSort(int[] array) 
{
    for(int i = 0; i < array.Length-1; i++)
    {
         int minPosition = i; 
        for(int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary =   array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;                            
    }
}
PrintArray(arr);
selectionSort(arr);
Console.WriteLine();
PrintArray(arr);