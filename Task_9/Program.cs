// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine ("Введите число N до которого мы покажем вам произведение натуральных чисел: ");
int N = int.Parse (Console.ReadLine ());
int count = 1;
int sum = 1;

while (count <=N)
{
sum = sum * count ;
count++;
}
Console.WriteLine (sum);