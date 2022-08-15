// Найти кубы чисел от 1 до N
Console.WriteLine ("Введите число N до которого мы покажем вам кубы чисел: ");
int N = int.Parse (Console.ReadLine ());
int count = 1;
int x = 0;

while (count <=N)
{
x = count * count * count;
Console.WriteLine (x);
count++;
}