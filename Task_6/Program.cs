// Найти сумму чисел от 1 до А
Console.WriteLine ("Введите число A до которого мы покажем вам сумму натуральных чисел: ");
int A = int.Parse (Console.ReadLine ());
int count = 1;
int sum = 0;

while (count <=A)
{
sum = sum + count ;
count++;
}
Console.WriteLine (sum);