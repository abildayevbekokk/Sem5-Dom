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
int[] massive = FillArray(12, -9, 9);
string result = String.Join(" ", massive);
Console.WriteLine($"[{result}]");
int SumPos = 0;
int SumNeg = 0;
foreach (int element in massive)
{
    if (element < 0)
    {
        SumNeg += element;
    }
    else
    {
        SumPos += element;
    }
}
Console.WriteLine($"Сумма положительных элементов = {SumPos} \nСумма отрицательных элементов = {SumNeg}");

