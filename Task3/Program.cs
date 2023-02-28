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
int min = Prompt("Введите минимальное значение для элемента массива: ");
int max = Prompt("Введите максимальное значение для элемента массива: ");
int FindNumber = Prompt("Ваше число");
int[] massive = FillArray(length,min,max);
int count = 0;
string index = String.Empty;
PrintArray(massive);
bool Founded = false;
for (int i = 0; i < length; i++)
{
    if (massive[i] == FindNumber)
    {
        count++;
        index += $"{i}; ";
        Founded = true;
    }
}
if (Founded == false)
Console.WriteLine($"Число {FindNumber} не найдено в массиве");
else 
Console.WriteLine($"Число {FindNumber} найдено в массиве {count} раз, на позициях {index}");
