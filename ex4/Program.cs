System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

for (int firsNum = -num; firsNum <= num; firsNum++)
{
    System.Console.Write(firsNum + " ");
}