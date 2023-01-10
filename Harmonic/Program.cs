namespace Harmonic
{
    internal class Harmonic
    {
        static void Main(string[] args)
        {
            double num = 0, result = 0, i;

            Console.WriteLine(" Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                num = num + (1 / i);
                result = num;
            }
            Console.WriteLine("The value of harmonic no. " + n + " is: " + result);
        }
    }
}