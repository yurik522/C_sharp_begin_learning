// ЗАДАЧА НА ПОИСК И ВЫВОД ИНДЕКСА ЭЛЕМЕНТА С ЗАДАННЫМ ЗНАЧЕНИЕМ

int[] array = {1, 32, 41, 6, 5, 9, 12, 9, 32, 58, 9}; //Задаём массив и сразу вручную его заполняем

int n = array.Length; //определяем длину массива с помощью оператора Length
int find = 9;

int index = 0;

while (index < n)
{
  if(array[index] == find)
  {
      Console.WriteLine(index);
      break;
  }
  //index = index +1;
  index +=1;
  //index++;   
}
