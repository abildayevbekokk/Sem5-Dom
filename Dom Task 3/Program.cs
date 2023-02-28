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
int[] massive = FillArray(length, 1, 99);
int max = massive[0];
int min = massive[0];
PrintArray(massive);
for (int i = 0; i < length - 1; i++)
{
    if (min > massive[i + 1])
        min = massive[i+1];
    if (max < massive[i+1])
        max = massive[i+1];

}
Console.WriteLine(max - min);