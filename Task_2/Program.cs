// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine ("Введите первое число: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int y = int.Parse (Console.ReadLine());

if (x == y * y)
{
    Console.WriteLine ("Да! Первое число является квадратом второго");
}
else if (y == x * x)
{
     Console.WriteLine ("Да! Второе число является квадратом первого");
}
else
{
    Console.WriteLine ("Нет, числа не является квадратами друг-друга");
}