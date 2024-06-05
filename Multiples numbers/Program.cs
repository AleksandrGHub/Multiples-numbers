namespace Multiples_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 100;
            int maxNumber = 999;
            int minRandomNumber = 50;
            int maxRandomNumber = 150;
            int quantityNaturalNumber = 0;
            int reduced;
            int randomNumber;
            Random random = new Random();

            randomNumber = random.Next(minRandomNumber, maxRandomNumber);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                for (reduced = i; reduced >= randomNumber; reduced -= randomNumber)
                {
                    if (reduced == randomNumber)
                    {
                        quantityNaturalNumber++;
                    }
                }
            }

            Console.WriteLine(quantityNaturalNumber);
        }
    }
}