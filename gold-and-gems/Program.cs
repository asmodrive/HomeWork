Console.WriteLine("Добрый день, сколько у вас денег?");
uint goldCount = Convert.ToUInt32(Console.ReadLine());
uint gemsCount = 0;
uint gemsPrice = 36;

Console.WriteLine($"Сколько криссталов вы хотите приобрести? Цена за 1 кристалл - {gemsPrice} золотых");
uint gemsToBuy = Convert.ToUInt32(Console.ReadLine());
gemsCount += gemsToBuy;
goldCount -= gemsToBuy*gemsPrice;
Console.WriteLine($"Вы приобрели {gemsToBuy} штук, у вас суммарно {gemsCount} штук, у вас осталось {goldCount} золотых.");


