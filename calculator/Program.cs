namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                Console.Write("Enter operation (+, -, *, /): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid operation.");
                    return;
                }

                char operation = input[0];

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return;
                        }

                        result = num1 / num2;
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want another calculation? (y/n): ");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'n')
                {
                    break;
                }
            }
        }
    }
}
