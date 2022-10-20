// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] input = CreateRandomArray(4, 99, 999);

int Calculate(int[] input)
{
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] % 2 == 0) count += 1;
}
return count;
}
int count = Calculate(input);
string inputString = string.Join(", ", input);
Console.WriteLine($"[{inputString}] ->{count}");
