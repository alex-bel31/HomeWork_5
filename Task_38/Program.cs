// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 
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

int DifferenceMaxMin(int[] input)
{
int max = input[0];   
int min = input[0];
for (int i = 0; i < input.Length; i++)
    {
        if (input[i] > max) 
        max = input[i];
        if(input[i] < min) 
        min = input[i];
    }
    int difference = max-min;
return difference;
}  
int difference = DifferenceMaxMin(input);
string inputString = string.Join(", ", input);
Console.WriteLine($"[{inputString}] -> {(difference)}");
