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

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void PrintArray(int[] array)
{
    string Print = String.Join(" ", array);
    Console.WriteLine($"[{Print}]");
}
int length = Prompt("Введите длину массива: ");
int[] massive = FillArray(length, -99, 99);
PrintArray(massive);
int sum = 0;
for (int i = 0; i < length; i++)
{
    if (i % 2 == 1)
    sum += massive[i];
}
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях = {sum}");