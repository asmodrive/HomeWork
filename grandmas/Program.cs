Console.WriteLine("Введите количество старушек в очереди:");
uint grandmas = Convert.ToUInt32(Console.ReadLine());
uint expectation = 10;
uint totalTime = 0;
totalTime = grandmas * expectation;
Console.WriteLine($"Вы должны отстоять в очереди {totalTime/60} ч. {totalTime%60} минут");