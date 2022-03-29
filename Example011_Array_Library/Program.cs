// НОВЫЙ СПОСОБ СОЗДАНИЯ И НАПОЛНЕНИЯ МАССИВА

void FillArray(int[] collection)//Даём наименование методу, внутри скобок указываем, 
  //что будет применятся в качестве аргумента
{
    int length = collection.Length;//Получаем длинну нашего массива
    int index = 0;//Определили начальную позицию индекса
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//обращаемся к аргументу на позицию "index"
          //и ложим туда число с помощью генератора сл. чисел 
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
   
}

int[] array = new int[10];//Определили массив из 10-ти элементов.

FillArray(array);//Вызвали метод, который заполнил массив.
PrintArray(array);// Вызвали метод, который вывел значения элементов массива на экран.
Console.WriteLine();


int pos = IndexOf(array, 4);
Console.WriteLine(pos);