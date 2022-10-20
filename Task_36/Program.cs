// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] input = CreateRandomArray(5, 10, 100);
int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    if (i % 2 != 0) sum = sum + input[i];
}
string inputString = string.Join(", ", input);
Console.WriteLine($"[{inputString}] -> {sum}");
