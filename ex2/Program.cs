System.Console.Write("Введите первое число: ");
int firsNum = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int secNum = int.Parse(Console.ReadLine()!);

if ( firsNum ==  secNum * secNum)
{
    System.Console.WriteLine(firsNum + " является квадратом " + secNum);
}
else 
{
    System.Console.WriteLine(firsNum + " не является квадратом " + secNum);
}