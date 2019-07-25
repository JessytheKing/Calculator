using System;

namespace Calculator
{
    class Calculator
    {
        static void UserInput()


        {
            bool TermApp = false;

            while (!TermApp)
            {
                string input1 = "";
                string input2 = "";

                Console.WriteLine("Enter a number then press Enter");
                input1 = Console.ReadLine();

                double newNum = 0;
                while (!double.TryParse(input1, out newNum))
                {
                    Console.WriteLine("Enter a vaild Number");
                    input1 = Console.ReadLine();
                }

                Console.WriteLine("Enter a second number");
                input2 = Console.ReadLine();

                double newNum2 = 0;
                while (!double.TryParse(input2, out newNum2))
                {
                    Console.WriteLine("Enter a vaild number");
                    input2 = Console.ReadLine();
                }



                Console.WriteLine("What are we going to be doing...");
                Console.WriteLine("\t 1. Addidtion");
                Console.WriteLine("\t 2. Multiplication");
                Console.WriteLine("\t 3. Subtraction");
                Console.WriteLine("\t 4. Division");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine($"{newNum} + {newNum2} = " + (
                            newNum + newNum2));
                        break;
                    case "2":
                        Console.WriteLine($"{newNum} * {newNum2} = " + (newNum * newNum2));
                        break;
                    case "3":
                        Console.WriteLine($"{newNum} - {newNum2} = " + (newNum - newNum2));
                        break;
                    case "4":
                        if (newNum == 0 || newNum2 == 0)
                        {
                            throw new System.DivideByZeroException("You can't divide by zero");

                        }
                        else
                            Console.WriteLine($"{newNum} / {newNum2} = " + (newNum / newNum2));
                        break;
                }

                Console.WriteLine("To exit Press W.");

                if
                   (Console.ReadLine() == "W") TermApp = true;
            }
        
}
        static void Main(string[] args)
        {
            Console.WriteLine("Lets do some Math...");
            UserInput();    
        }
    }
}
