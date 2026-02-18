namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 432432;
            int firstThree = 0;
            int endThree = 0;
            int copyNumber = number;
            for (int i = 0; i <= number; i++)
            {          
                if (i <= 2)
                {
                    endThree += (copyNumber % 10);
                    copyNumber /= 10;
                }
                else
                {
                    firstThree += (copyNumber % 10);
                    copyNumber /= 10;
                }
            }
            if(firstThree==endThree)
            {
                Console.WriteLine("The number " + number + " is happy!");
            }
            else
            {
                Console.WriteLine("The number " + number + " is not happy!");
            }
        }
    }
}
