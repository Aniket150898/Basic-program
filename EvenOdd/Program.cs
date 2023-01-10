namespace EvenOdd
{
    internal class EvenOdd
    {
        static void Main(string[]arg)
        {
            Console.WriteLine(" Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an Even number");
            }
            else
            {
                Console.WriteLine(num + " is an Odd number");
            }
        }
    }
}