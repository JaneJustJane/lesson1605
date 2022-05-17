Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
while ((a/10)>0)
{
    count = count + 1;
    a=a/10;
}
Console.WriteLine($"количество цифр в числе = {count}");