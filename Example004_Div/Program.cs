double numberA = new Random().Next(1, 10); //добавил случаное число от 1 до 9
Console.WriteLine($"Первое число: {numberA}");
double numberB = new Random().Next(1, 10); //добавил случаное число от 1 до 9
Console.WriteLine($"Второе число: {numberB}");
double result = numberA / numberB;
Console.WriteLine($"Частное двух чисел: {result}");
