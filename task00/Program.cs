Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int index = 1;

while (index <= n) 
{
    Console.WriteLine (index*index);
    index++;
}