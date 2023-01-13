Console.WriteLine("Введите первое число ");

double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");

double numberB = Convert.ToDouble(Console.ReadLine());
double result = numberA / numberB;
Console.Write($"{numberA}/{numberB}={result}");