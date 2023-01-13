Console.WriteLine("Введите первое число ");

double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");

double numberB = Convert.ToInt32(Console.ReadLine());
double result = numberA / numberB;
Console.Write($"{numberA}/{numberB}={result}");