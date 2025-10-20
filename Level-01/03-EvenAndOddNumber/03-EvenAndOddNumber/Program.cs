namespace _03_EvenAndOddNumber
{
/*EvenOrOddChecker*/

    internal class Program
    {
        enum enEvenOdd
        {
            Even,
            Odd
        }

        static int ReadNumber()
        {
            int number;

            //number = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("Enter an integer number: ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            }
        }

        static enEvenOdd EvenOddCheck(int Number)
        {
            if (Number % 2 == 0)
            {
                return enEvenOdd.Even;
            }
            else
            {
                return enEvenOdd.Odd;
            }
        }
        
        static void PrintResult(enEvenOdd EvenOddNumber)
        {
            Console.WriteLine($"\nThe number is {EvenOddNumber}");
        }

        static void Main(string[] args)
        {

            //Program program = new Program(); // because EvenOddCheck is not static
            //enEvenOdd result = program.EvenOddCheck(number);

            PrintResult(EvenOddCheck(ReadNumber()));
        }
    }
}
