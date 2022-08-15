// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели: ");
int x =int.Parse(Console.ReadLine());

if (x ==1) Console.WriteLine("понедельник - работай");
if (x ==2) Console.WriteLine("вторник - работай");
if (x ==3) Console.WriteLine("среда - работай");
if (x ==4) Console.WriteLine("четверг - работай");
if (x ==5) Console.WriteLine("пятница - работай");
if (x ==6) Console.WriteLine("суббота - УРА, ВЫХОДНОЙ!");
if (x ==7) Console.WriteLine("воскресенье - УРА, ВЫХОДНОЙ!");