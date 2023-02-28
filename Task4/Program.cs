// See https://aka.ms/new-console-template for more information
int[] FillArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}
void PrintArray(int[] array)
{
    string Print = String.Join(" ", array);
    Console.WriteLine($"[{Print}]");
}
int[] massive = FillArray(123, 1, 123);
int count = 0;
foreach (int element in massive)
{
    if (element >= 10 && element <=99)
    {
        count += 1;
    }
}
PrintArray(massive);
Console.WriteLine(count);

