Console.WriteLine("Напишите выражение");

string message = Console.ReadLine();

Console.WriteLine("Установите количество раз которое выражение будет выводиться на экран.");

int repeatCount = Convert.ToInt32(Console.ReadLine());

for (int i =0; i<repeatCount; i++)
{
    Console.WriteLine(message);
}