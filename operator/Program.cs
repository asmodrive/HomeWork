string trueWord = "exit";
string userInputWord = "";

while (userInputWord != trueWord)
{ 
    Console.WriteLine("Напишите слово выход на английском языке");
    userInputWord = Console.ReadLine();
    if (userInputWord == trueWord)
    {
        Console.WriteLine("Вы угадали слово.");
    }
    else
    {
        Console.WriteLine("Попробуйте еще раз.");
    }
}