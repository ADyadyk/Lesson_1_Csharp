int numberA = new Random().Next(1, 10); //добавил случаное число от 1 до 9
Console.WriteLine($"Первое число: {numberA}");
int numberB = new Random().Next(1, 10); //добавил случаное число от 1 до 9
Console.WriteLine($"Второе число: {numberB}");
int result = numberA + numberB;
Console.WriteLine($"Сумма двух чисел: {result}");