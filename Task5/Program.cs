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
int length = Prompt("Введите длину массива");
int[] massive = FillArray(length, 1, 9);
PrintArray(massive);
int NewLength = 0;
if (length % 2 == 0)
NewLength = length/2;
else
NewLength = length/2 +1;
int[] NewMassive = new int [NewLength];
for (int i = 0; i < NewLength; i++)
{
    NewMassive[i] = massive[i]*massive[length-1-i];
    if (length % 2 == 1)
    NewMassive[NewLength-1] = massive[(length-1)/2];
}
PrintArray(NewMassive);