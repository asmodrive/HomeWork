string name = "Vasilev";
string surname = "Petr";
Console.WriteLine($"Ваше имя - {name}, ваша фамилия - {surname}");
string clipboard;
clipboard = name;
name = surname;
surname = clipboard;
Console.WriteLine($"Ваше имя - {name}, ваша фамилия - {surname}");
