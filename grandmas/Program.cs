Console.WriteLine("Введите количество старушек в очереди:");
uint grandmas = Convert.ToUInt32(Console.ReadLine());
uint expectation = 10;
uint totalTime = 0;
totalTime = grandmas * expectation;
uint hourLength = 60;
uint waitingTimeInHours = totalTime / hourLength;
uint waitingTimeInMinutes = totalTime % hourLength;
Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeInHours} ч. {waitingTimeInMinutes} минут");