//Eric Malmström

using System.ComponentModel;

namespace funfeaturesspace
{
    class FunFeatures
    {
        private string? email;
        private string? name;
        public FunFeatures()
         //constructor for Funfeatures, sets email and name to the default variables
        {
            this.email = "impossible@superfakeemailaddress.fakenet";
            this.name = "James Bond";
        }

        public void Start()
        {
        //FunFeatures main, all methods are run from this method
            Introduce();
            
            bool done = false;
            do
            {
                PredictTheDay();

                CalculateStrengthLength();

                done = RunAgain();
            }
            while (!done);
            Console.WriteLine("Welcome back, " + this.name);
            
        }

        public void CalculateStrengthLength()
        {
            //User inputs a string and we print it uppercase along with printing the length of it
            string? stringInput = null;

            Console.WriteLine("\nLength of a text: Write a text with any number of characters and press Enter");
            Console.WriteLine("I will then calculate the number of chars included in the text");
            Console.WriteLine("Give me a text of any length, or press Enter to exit\n");

            stringInput = Console.ReadLine();

            if(stringInput.Length != 0)
            {
                Console.WriteLine(stringInput.ToUpper());
                Console.WriteLine("Number of chars = " + stringInput.Length);
            }
            else
            {
                Console.WriteLine("Empty string..skipping calculations!");
            }
        }

        private void Introduce()
        {
        //Introduces the user to the program

            Console.WriteLine("My name is: Eric Malmström and I am a student of the 2022 Hösttermin semster");
            Console.WriteLine("\nLet me know about yourself!");

            ReadNames();

            Console.WriteLine("\nHere is your full name and your email.");
            Console.WriteLine(this.name + " " + this.email);

        }

        public void PredictTheDay()
        {
            //Asks the user for a number 1-7 which corresponds to the day. For example 1 is Monday 2 is Tuesday and so on
            int? numChoice = 9000;
            
            Console.WriteLine("\n\nI am a fortune teller.");
            Console.Write("Select a number between 1 and 7: ");
            numChoice = Convert.ToInt16(Console.ReadLine());

            switch (numChoice)
            {
                case 1:
                    Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday, the day of weddings");
                    break;
                case 4:
                    Console.WriteLine("Thursday, OMG, still one day to Friday!");
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("To start, press the any key. Where's the ANY key? -Homer Simpson");
                    break;
            }
        }

        public void ReadNames()
        {
        //Sets the email and name attributes to the users input
            string firstName = "", lastName = "";

            Console.Write("Your first name please: ");
            firstName = Console.ReadLine().Trim();

            Console.Write("Your last name please: ");
            lastName = Console.ReadLine().Trim();

            Console.WriteLine("Nice to meet you " + firstName + "!");

            Console.Write("Give me your email please: ");
            this.email = Console.ReadLine();

            this.name = lastName.ToUpper() + ", " + firstName;
        }

        private bool RunAgain()
        {
        //Asks if the user wants to run the program again through a yes or no choice
            char? userInput = 'm';

            Console.WriteLine("Run again? (y/n)");
            userInput = Console.ReadKey().KeyChar;

            if(userInput == 'y')
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return false;
            }
            else if(userInput == 'n')
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return true;
            }
            else
            {
                //had to add a newline to make the format as readkey was not giving a newline making the outputs "out of place"
                Console.WriteLine("\n");
                return true;
            }
        }
    }
}