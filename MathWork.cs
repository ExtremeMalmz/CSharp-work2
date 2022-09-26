using System;

namespace MathWorkspace
{
    class MathWorks
    {
        public void Start()
        {
            //The main of MathWorks, runs the number programs and at the end asks if the user would like to start over or exit
            bool done = false;
            
            do
            {
                SumNumbers();
                PrintMultiplicationTable();
                done = ExitCalculations();
            }
            while (!done);
            
        }

        public void CalculateSquareRoots()
        {
            //Included due to it being in the Class Diagram but not done due to it not being in the grade specification

        }

        private bool ExitCalculations()
        {
            char? userInput = 'm';

            Console.WriteLine("\nExit calculations? (y/n)");
            userInput = Console.ReadKey().KeyChar;

            if (userInput == 'y')
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return true;
            }
            else if (userInput == 'n')
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return false;
            }
            else
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return false;
            }
        }

        public void ListLeapYears()
        {
            //Included due to it being in the Class Diagram but not done due to it not being in the grade specification
        }

        private void PrintEvenNumbers(int number1, int number2)
        {

            Console.WriteLine("Even numbers between " + number1 + " och " + number2);

            if (number1%2 != 0)
            {
                //Console.WriteLine(number1 + " is NOT even + add a 1");
                
                number1++;
            }
            
            for(int i = number1;i <= number2; i+=2)
            {
                Console.Write(i + " ");
                //Console.WriteLine(number1);
            }
        }

        public void PrintMultiplicationTable()
        {
            //prints a multiplication table from 1 to 12

            Console.WriteLine("\n\n" + new string(' ', 13) + "*** Multiplication table ***");
            
            for(int col = 1;col < 13; col++)
            {
                Console.WriteLine();
                for (int row = 1; row <= 12; row++)
                {
                    Console.Write(string.Format("{0,4:d} ", row * col));
                }
            }
            
        }

        public void SumNumbers()
        {
            int startInt = 0, endInt = 0, placeholderInt = 0;
            Console.WriteLine("Sum numbers between any two numbers");

            Console.Write("Give start number: ");
            startInt =  Convert.ToInt16(Console.ReadLine());

            Console.Write("Give end number: ");
            endInt = Convert.ToInt16(Console.ReadLine());

            if(startInt > endInt)
            {
                placeholderInt = startInt;
                startInt = endInt;
                endInt = placeholderInt;
            }
            
            
            int sum = SumNumbers(startInt, endInt);
            Console.WriteLine("Sum is: " + sum);

            PrintEvenNumbers(startInt, endInt);
            
        }

        private int SumNumbers(int start,int end)
        {
            int totalSum = 0;

            for(int i = start; i < end+1; i++)
            {
                totalSum = start + totalSum;
                start++;
            }
            return totalSum;
        }
    }
}