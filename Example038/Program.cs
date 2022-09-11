Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, 1, 100);

int [] GetArray(int size, int min, int max)
{
   int [] result = new int[size];
   for (int i = 0; i < size; i++)
   {
    result[i] = new Random().Next(min, max + 1);
   }
   return result;
}
Console.WriteLine(String.Join(" ", array));
int indexMax = 0;
int indexMin = 0;
for(int i = 0; i <array.Length; i++)
{
    if(array[i] > array[indexMax]) indexMax = i;
    else if(array[i] < array[indexMin]) indexMin = i;
}
Console.WriteLine("Максимальное число: " + array[indexMax] + " , Минимальное число: " + array[indexMin]);
Console.Write("Разница: ");
Console.Write(array[indexMax] - array[indexMin]);