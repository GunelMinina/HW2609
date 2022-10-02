// Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i]=int.Parse(Console.ReadLine());
}

Console.WriteLine("Введен массив:");
for (int i = 0; i < N; i++)
{
    Console.Write($"{array[i]} ");
}
