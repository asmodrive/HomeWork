Console.WriteLine("Введите количество старушек в очереди:");
uint grandmas = Convert.ToUInt32(Console.ReadLine());
uint expectation = 10;
uint totalTime = 0;
totalTime = grandmas * expectation;
uint HourLength = 60;
uint waitingTimeInHours = totalTime / HourLength;
uint waitingTimeInMinutes = totalTime % HourLength;
Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeInHours} ч. {waitingTimeInMinutes} минут");