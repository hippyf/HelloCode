//Найти индекс заданного элемента массива

int[] array = {1, 12, 31, 4, 5, 6, 17, 18, 18};
int n = array.Length; //количество элементов в массиве
int find = 18;
int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}