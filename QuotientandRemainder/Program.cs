namespace QuotientandRemainder
{
    internal class QuotientRemainder
    {
        static void Main(string[] args)
        {
            int num1, num2, quotient, remainder;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("Quotient is num1 is divide by num2 : " + quotient);
            Console.WriteLine("Remainder is num1 is divide by num2 : " + remainder);
        }
    }
}