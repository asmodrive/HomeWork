string name = "";
string password;
string exitCommand = "esc";
string userInput = "";

while (userInput != exitCommand)
{
    Console.WriteLine("Добро пожаловать, введите, что вы хотите сделать:");
    Console.WriteLine("Setname - установить имя.");
    Console.WriteLine("ChangeConsoleColor - изменить цвет консоли.");
    Console.WriteLine("SetPassword – установить пароль.");
    Console.WriteLine("WriteName - вывести ваше имя.");
    Console.WriteLine("Esc - выход из программы.");
    userInput = Console.ReadLine().ToLower();

    switch (userInput)
    {
        case "setname":
            {
                Console.WriteLine("Введите ваше имя.");
                name = Console.ReadLine();
                Console.WriteLine($"Ваше имя - {name}.");
            }
            break;
        case "changeconsolecolor":
            {
                Console.WriteLine("Выберите цвет:\n 1 - синий,\n 2 - красный,\n 3 - зеленый.");
                string color = Console.ReadLine();
                switch (color)
                {
                    case "1":
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Вы выбрали синий цвет.");
                        }
                        break;
                    case "2":
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы выбрали красный цвет.");
                        }
                        break;
                    case "3":
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Вы выбрали зеленый цвет.");
                        }
                        break;
                }
            }
            break;
        case "setpassword":
            {
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                Console.WriteLine($"Пароль от программы - {password}");
            }
            break;
        case "writename":
            {
                Console.WriteLine($"Ваше имя - {name}.");
            }
            break;
    }
}