using System;

namespace Lab_8___Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\tLet's Get to Know Your Cartoon Character Classmates!\t\n");

            GetToKknowYourClassmates();
        }

        public static void GetToKknowYourClassmates()
        {
            //Next time, see if you could split this method into 2 seperate methods. Ask for help on this.
            
            //I used a 2D array because I wanted to take out all the if-else statements and instead print just one line depending on the user's choice;
            //I thought with the 2D array I would be able to access everything easier instead of using multiple arrays.
            string[,] cartoonClassmates = new string[,] {
                { "Timmy Turner", "pizza", "Dimmsdale", "purple", "hanging out with the fairy odd parents"},
                { "Danny Phantom", "spaghetti", "Amity Park", "white", "beating the evil ghosts" },
                { "Kim Possible", "nachos from Buenos Nachos", "Middleton", "red", "fighting the bad guys with her best friend Ron" },
                { "Katsumi Jun", "black bean noodle", "Korea", "blue", "fencing" },
                { "Buttercup", "steak", "Townsville", "green", "boxing, so she could fight the bad guys" },
                { "Naruto Uzumaki", "ramen", "the Hidden Leaf Village", "orange", "graffiting the Hokage rock"}
            };

            //The reason I entered a seperate array for the user to pick a characteristic to learn is because it would be easier to update
            //but also it would display in the final statement depending on user choice.
            string[] thingsToLearn = { "Favorite Food", "Hometown", "Favorite Color", "Favorite Activity" };

            do
            {
                try
                {

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Here are you Cartoon Character Classmates: ");
                    DisplayCharacters(cartoonClassmates); 
                    int characterChoice = GetInput("\nWhich Cartoon Classmate would you like to learn more about? \nPlease enter a number 1-6: ");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"\nNice Choice! Here are their Characteristics: ");
                    DisplayCharacteristics(thingsToLearn);
                    int characteristicToLearn = GetInput($"\nWhat did you like to learn from {cartoonClassmates[characterChoice - 1, 0]}? \nPlease enter a number 1-4: ");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    //Make the final statement print at the top of the console.
                    Console.WriteLine($"\n{cartoonClassmates[characterChoice - 1, 0]}'s {thingsToLearn[characteristicToLearn - 1]} is {cartoonClassmates[characterChoice - 1, characteristicToLearn]}.");

                }
                catch (FormatException)
                {
                    //added this so that it displays an error that is not a number input
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\nInvalid Entry! Please enter a number from the selected options. Thank you.\n");
                    GetToKknowYourClassmates();

                }
                catch (OverflowException)
                {
                    //added this so it displays error if the user enters a number too high
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("Selected number is too high, please enter a number from the selected options. Thank you.\n");
                    GetToKknowYourClassmates();

                }
                catch (IndexOutOfRangeException)
                {
                    //added this so that it displays this error if the user inserts a number that might exceed what is offered
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\nInvalid Entry! Please enter a number from the selected options. Thank you. ~~\n");
                    GetToKknowYourClassmates();

                }
            } while (GetAnotherCharacterInfo());

        }

        public static int GetInput(string input)
        {
            Console.Write(input);
            return int.Parse(Console.ReadLine());
        }

        public static void DisplayCharacters(string[,] character)
        {
            for (int i = 0; i < character.Length; i++)
            {
                //find a better solution for this! 
                //I added this part because while debugging, it would print out the characters but would break immediatley after it displayed the 6th character's name.
                if (i < 6)
                {
                    Console.WriteLine($"{i + 1}. {character[i, 0]}");
                }
            }
        }

        public static void DisplayCharacteristics(string[] thingsToLearn)
        {
            //this is the loop that displays thingsToLearn in GetToKnowYourClassmates();
            for (int i = 0; i < thingsToLearn.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {thingsToLearn[i]}");
            }
        }

        public static bool GetAnotherCharacterInfo()
        {
            //I kept this as a string instead of using an int because I wanted to be a little lenient on the user's anwer. If they entered yes or no
            //it would still accept their answer.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\nWould you like to learn something new about Another Cartoon Classmate ? \n1.Yes \n2.No \nPlease select a number: ");
            string anotherCharacter = Console.ReadLine().ToLower();

            if (anotherCharacter == "1" || anotherCharacter == "y" || anotherCharacter == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (anotherCharacter == "2" || anotherCharacter == "n" || anotherCharacter == "no")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nThank you for checking out your Cartoon Classmates. HAGS! (Have a great day!)");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nInvalid Entry! Please choose a number to indicate if you'd like to continue.");
                return GetAnotherCharacterInfo();
            }
        }
    }
}

