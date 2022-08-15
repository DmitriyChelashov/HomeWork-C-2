// Подсчитать сумму цифр в числе
Console.WriteLine ("Введите число для определения суммы цифр в нем: ");
int x = int.Parse (Console.ReadLine ());
int count = 1;
int sum = 0;

while (x / 10 > 0)
{   sum = sum + x%10;
    x = x/10;
    count++;
    }
sum = sum + x;
Console.WriteLine (sum);