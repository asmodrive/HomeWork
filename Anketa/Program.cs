Console.WriteLine("Напишите ваше имя");
string name = Console.ReadLine();

Console.WriteLine("Напишите ваш знак зодиака");
string zodiacSign = Console.ReadLine();

Console.WriteLine("Напишите ваш возраст");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите ваше место работы");
string workPlace = Console.ReadLine();

Console.WriteLine($"Вас зовут {name}. Ваш знак зодиака {zodiacSign}. Ваш возраст - {age}. Ваше место работы - {workPlace}.");
