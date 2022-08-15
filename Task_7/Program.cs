// Определить количество цифр в числе
Console.WriteLine ("Введите число для определения количества цифр в нем: ");
int x = int.Parse (Console.ReadLine ());
int count = 1;

while (x / 10 > 0)
{   x = x/10;
    count++;}
Console.WriteLine (count);
