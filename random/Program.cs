Random rand = new Random();
int randomNumber;

    randomNumber = rand.Next(0,100);    
    Console.WriteLine(randomNumber);
    Console.ReadKey();
    int sumOfNumbers = 0;



for (int i = 1; i <= randomNumber; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sumOfNumbers += i;
    }
}
    Console.WriteLine(sumOfNumbers);
