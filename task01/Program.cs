Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int index = 1;
int b = 0;
int sum=0;
while (index <= a) 
{
    b = b+1;
    sum = sum + b;
    index++;
}
Console.WriteLine($"Сумма чисел от 1 до {a} равна {sum}");