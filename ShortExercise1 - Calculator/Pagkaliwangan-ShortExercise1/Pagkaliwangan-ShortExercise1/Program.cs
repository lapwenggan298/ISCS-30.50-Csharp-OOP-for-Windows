class Calculator
{
    static void Main(string[] args)
    {
        bool continueApp = true;
        short timesUsed = 0;
        double result;
        double num1;
        double num2;
        string operation;
        string contApp;
        string verify;
        do
        {
            if (timesUsed == 0)
            {
                Console.WriteLine("Hello! Welcome to my simple calculator written in C#!");
                Console.WriteLine("This will calculate 2 numbers at a time. (e.g., 1+ 2 = 3 or 5*5 = 25)");
                timesUsed += 1;
            }
            Console.Write("Please enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Please choose the operation you wish to perform. '+' for addition, '-' for subtraction, '*' for multiplication, '/' for division. ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Answer for {num1} + {num2} is {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Answer for {num1} - {num2} is {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Answer for {num1} + {num2} is {result}");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Answer for {num1} + {num2} is {result}");
                    break;
                default:
                    Console.WriteLine("Wrong input for Operation.");
                    break;
            }

            Console.Write("Do you wish to continue using the calculator? Input Y for yes, or N for no. ");
            contApp = Console.ReadLine();
            if (contApp == "Y" || contApp == "y")
            {
                continueApp = true;
            }
            else if (contApp == "N" || contApp == "n")
            {
                Console.Write("Are you sure? Input Y for yes, or N for no. ");
                verify = Console.ReadLine();
                if (verify == "Y" || verify == "y")
                {
                    continueApp = false;
                    Console.WriteLine("Quitting Application... Thank you for using my simple calculator!");
                }
                else
                {
                    continueApp = true;
                }
            }

        } while (continueApp);
    }
}