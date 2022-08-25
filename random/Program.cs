Random random = new Random();
int randomNumber;
int randomMin = 1;
int randomMax = 100;

    randomNumber = random.Next(randomMin,randomMax);    
    Console.WriteLine(randomNumber);
    Console.ReadKey();
    int sumOfNumbers = 0;
    int multipleNumber1 = 3;
    int multipleNumber2 = 5;

for (int i = 1; i <= randomNumber; i++)
{
    if (i % multipleNumber1 == 0 || i % multipleNumber2 == 0)
    {
        sumOfNumbers += i;
    }
}
    Console.WriteLine(sumOfNumbers);
