namespace BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            BasicMath calculation = new BasicMath(firstNum, secondNum);

            Console.WriteLine("Sum is: " + calculation.GetAdd());
            Console.WriteLine("Difference is: " + calculation.GetSubstract());
            Console.WriteLine("Quotient is: " + calculation.GetDivide());
            Console.WriteLine("Product is: " + calculation.GetMultiply());
        }
    }
}