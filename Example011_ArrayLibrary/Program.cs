// int[] array = new int[10]; - создание нового массива с 10 элементамиж
// пол умолчанию массив будет наполнен нулями.
// Создаем новый метод по заполнению массива рандомными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

//Метод для того, чтобы программа напечатала массив

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+ " ");
        position++;
    }
}

//Метод для нахождения индекса элемента

int IndexOf(int[] collect, int find)
{
    int count = collect.Length;
    int index = 0;
    int position = -1; // Если возвращается -1, то это интерпритируется как элемент не найден
    while (index < count)
    {
        if (collect[index] == find)
        {
            position = index;
            break;
        }
        index = index+1;
    }
    return position;
}

int[] array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 3);
Console.WriteLine(pos);