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
    for(int i = 0; i < array.Length - 1; i++)
    {
         int maxPosition = i; 
        for(int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;                            
    }
}
PrintArray(arr);
selectionSort(arr);
Console.WriteLine();
PrintArray(arr);