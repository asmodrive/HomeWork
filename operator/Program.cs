string exitCommand = "exit";
string userInputWord = "";

while (userInputWord != exitCommand)
{ 
    Console.WriteLine("Напишите слово выход на английском языке");
    userInputWord = Console.ReadLine();

    if (userInputWord == exitCommand)
    {
        Console.WriteLine("Вы угадали слово.");
    }
    else
    {
        Console.WriteLine("Попробуйте еще раз.");
    }

}