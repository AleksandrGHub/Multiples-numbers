namespace Multiples_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 50;
            int maxNumber = 150;
            int minRandomNumber = 10;
            int maxRandomNumber = 25;
            int quantityNaturalNumber = 0;
            int randomNumber;
            int number = 0;
            Random random = new Random();

            randomNumber = random.Next(minRandomNumber, maxRandomNumber);

            for (int i = 0; i <= maxNumber; i++)
            {
                number += randomNumber;

                if (number >= minNumber && number <= maxNumber)
                {
                    quantityNaturalNumber++;
                }
            }

            Console.WriteLine(quantityNaturalNumber);
        }
    }
}