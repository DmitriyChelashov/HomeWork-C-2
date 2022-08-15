// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine ("Введите число N до которого мы покажем вам кубы чисел: ");
int N = int.Parse (Console.ReadLine ());
int count = 1;
int x = 0;

while (count <=N)
{
x = count * count * count;
if (x%2 == 0)
Console.WriteLine (x);
count++;
}