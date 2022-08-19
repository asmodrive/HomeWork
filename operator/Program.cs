string trueWord = "exit";
string userInputWord;

while (true)
{
    Console.WriteLine("Напишите слово выход на английском языке");
    userInputWord = Console.ReadLine();

    if (userInputWord == "exit")
    {
        Console.WriteLine("Вы угадали слово.");
        break;
    }
    else
    {
        Console.WriteLine("Попробуйте еще раз.");
    }
}