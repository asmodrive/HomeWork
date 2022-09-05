float RUB, USD, EUR;
float rubToUSD = 60, rubToEUR = 55, usdToRUB = 0.016f, usdToEUR = 0.9f, eurToUSD = 1.09f, eurToRUB = 0.018f;
string userInput = "";
float currencyCount;
string exitCommand = "0";
    Console.WriteLine("Доброе пожаловать в обменник,введите, что вы хотите сделать.");
    Console.WriteLine("Введите баланс в рублях.");
    RUB = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Введите баланс в долларах.");
    USD = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Введите баланс в евро");
    EUR = Convert.ToSingle(Console.ReadLine());

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
            if (RUB >= currencyCount)
            {
                RUB -= currencyCount;
                USD += currencyCount / rubToUSD;
            }
            else
            {
                Console.WriteLine("Недопустимое количество");
            }
            break;

        case "2":
            Console.WriteLine("Обмен долларов на рубли, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            if (USD >= currencyCount)
            {
                USD -= currencyCount;
                RUB = currencyCount * usdToRUB;
            }
            break;

        case "3":
            Console.WriteLine("Обмен долларов на евро, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            if (USD >= currencyCount)
            {
                USD -= currencyCount;
                EUR = currencyCount * eurToUSD;

            }
            break;

        case "4":
            Console.WriteLine("Обмен евро на доллары, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            if (EUR >= currencyCount)
            {
                EUR -= currencyCount;
                USD += currencyCount / eurToUSD;
            }
            break;

        case "5":
            Console.WriteLine("Обмен рубли на евро, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            if (RUB >= currencyCount)
            {
                RUB -= currencyCount;
                EUR += currencyCount * eurToRUB;
            }
            break;

        case "6":
            Console.WriteLine("Обмен евро на рубли, сколько вы хотите обменять?");
            currencyCount = Convert.ToSingle(Console.ReadLine());
            if (EUR >= currencyCount)
            {
                EUR -= currencyCount;
                RUB = currencyCount * rubToEUR;
            }
            break;
    }
    Console.WriteLine($"Ваш баланс:{RUB} рублей, {USD} долларов, {EUR} евро.");
}