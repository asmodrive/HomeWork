float rubBalance;
float usdBalance;
float eurBalance;
float rubToUSD = 60;
float rubToEUR = 55;
float usdToRUB = 0.016f;
float usdToEUR = 0.9f;
float eurToUSD = 1.09f;
float eurToRUB = 0.018f;
string userInput = "";
float currencyCount;
string exitCommand = "0";

    Console.WriteLine("Доброе пожаловать в обменник,введите, что вы хотите сделать.");
    Console.WriteLine("Введите баланс в рублях.");
    rubBalance = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Введите баланс в долларах.");
    usdBalance = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Введите баланс в евро");
    eurBalance = Convert.ToSingle(Console.ReadLine());

while (userInput != exitCommand)
    {
    Console.WriteLine("1 - обменять рубли на доллары");
    Console.WriteLine("2 - обменять доллары на рубли");
    Console.WriteLine("3 - обменять доллары на евро");
    Console.WriteLine("4 - обменять евро на доллары");
    Console.WriteLine("5 - обменять рубли на евро");
    Console.WriteLine("6 - обменять евро на рубли");
    Console.WriteLine($"{exitCommand} - выход.");
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.WriteLine("Обмен рублей на доллары, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());

            if (rubBalance >= currencyCount)
            {
                rubBalance -= currencyCount;
                usdBalance += currencyCount * rubToUSD;
            }
            else
            {
                Console.WriteLine("Недопустимое количество");
            }
            break;
        case "2":
            Console.WriteLine("Обмен долларов на рубли, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            
            if (usdBalance >= currencyCount)
            {
                usdBalance -= currencyCount;
                rubBalance = currencyCount * usdToRUB;
            }
            break;
        case "3":
            Console.WriteLine("Обмен долларов на евро, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            
            if (usdBalance >= currencyCount)
            {
                usdBalance -= currencyCount;
                eurBalance = currencyCount * eurToUSD;
            }
            break;
        case "4":
            Console.WriteLine("Обмен евро на доллары, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            
            if (eurBalance >= currencyCount)
            {
                eurBalance -= currencyCount;
                usdBalance += currencyCount * eurToUSD;
            }
            break;
        case "5":
            Console.WriteLine("Обмен рубли на евро, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
           
            if (rubBalance >= currencyCount)
            {
                rubBalance -= currencyCount;
                eurBalance += currencyCount * eurToRUB;
            }
            break;
        case "6":
            Console.WriteLine("Обмен евро на рубли, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
           
            if (eurBalance >= currencyCount)
            {
                eurBalance -= currencyCount;
                rubBalance = currencyCount * rubToEUR;
            }
            break;
    }
    Console.WriteLine($"Ваш баланс:{rubBalance} рублей, {usdBalance} долларов, {eurBalance} евро.");
}