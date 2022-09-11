Console.Clear();
Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size, -10, 99);

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
int sum = 0;
for(int i = 1; i <array.Length; i++)
{
    if(i % 2 == 0) sum = sum + array[i];
}
Console.WriteLine(sum);