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
int countOddNumbers = 0;
int countEvenNumbers = 0;
int sumOddNumbers = 0;
int sumEvenNumbers = 0;
for(int i = 0; i <array.Length; i++)
{
   if(array[i] % 2 == 0)
   {
    sumEvenNumbers += array[i];
    countEvenNumbers++;
   }
   else
   {
    sumOddNumbers += array[i];
    countOddNumbers++;
   }
}
Console.Write("Среднее арифметическое четных чисел: ");
Console.WriteLine(sumEvenNumbers / countEvenNumbers);
Console.Write("Среднее арифметическое нечетных чисел: ");
Console.WriteLine(sumOddNumbers / countOddNumbers);
if((sumEvenNumbers / countEvenNumbers) > (sumOddNumbers / countOddNumbers))
{
    Console.Write("Среднее арифметическое четных чисел больше нечетного");
}
else
{
    Console.Write("Среднее арифметическое нечетных чисел больше четного");
}