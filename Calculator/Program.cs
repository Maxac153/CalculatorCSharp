namespace Calculator
{
    class Calculator {
        static double Calc(char operation, double number_one, double number_two) {
            double result = 0;
            switch (operation) {
                case '/':
                    if (number_two == 0)
                        Console.WriteLine("Error: Divide by zero!!!");
                    else
                        result = number_one / number_two;
                    break;
                case '*':
                    result = number_one * number_two;
                    break;
                case '+':
                    result = number_one + number_two;
                    break;
                case '-':
                    result = number_one - number_two;
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator!!!");
                    break;
            }
            return result;
        }   

        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter the operation (/, *, +, -) (q -> exit):");
                char operation = Convert.ToChar(Console.ReadLine());

                if (operation == 'q')
                    break;

                Console.WriteLine("Enter the number one:");
                double number_one = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the number tow:");
                double number_two = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Result: " + Calc(operation, number_one, number_two));
            }
        }
    }
}
