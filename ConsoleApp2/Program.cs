using System.Xml.Serialization;
namespace ConsoleApp2
{
    public class Logic
    {
        public static string HappyOrNot(int number)
        {
            String message = "";

            int firstThree = 0;
            int endThree = 0;
            int copyNumber = number;

            if (Math.Log10(number) < 6 & Math.Log10(number) > 5)
            {
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
                if (firstThree == endThree)
                {
                    return "The number " + number + " is happy!";
                }
                else
                {
                    return "The number " + number + " is not happy!";
                }
            }
            else
            {
                return "The number " + number + " will never be happy :(!";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            string message = Logic.HappyOrNot(numberInput);
            Console.WriteLine(message);
        }
    }
}
