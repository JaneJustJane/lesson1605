Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int index = 1;
int comp=1;
while (index <= a) 
{
    comp = comp * index;
    index++;
}
Console.WriteLine($"Произведение чисел от 1 до {a} = {comp}");