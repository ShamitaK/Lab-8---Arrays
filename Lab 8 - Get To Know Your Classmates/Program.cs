using System;

namespace Lab_8___Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\tLet's Get to Know Some Cartoon Characters!\t\n");

            string[] cartoons = { "Timmy Turner", "Danny Phantom", "Kim Possible", "Katsumi Jun", "Buttercup" };
            string[] food = { "pizza", "spaghetti", "nachos from Buenos Nachos", "black bean noodles", "steak" };
            string[] hometown = { "Dimmsdale", "Amity Park", "Middleton", "Japan", "Townsville" };
            string[] color = { "purple", "white", "red", "blue", "green" };
            string[] activity = { "hanging out with his fairy odd parents", "beating the evil ghosts", "fighting the bad guys with her best friend Ron",
                    "fencing", "boxing, so she could fight the bad guys" };

            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Here are the Cartoon Characters: ");
                    DisplayCharacters(cartoons);
                    int input = GetInput("\nWhich cartoon character would you like to learn about? \nPlease enter a number from 1-5: ");

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    int input2 = GetInput($"\nNice Choice! What did you want to learn about {cartoons[input - 1]}?\n1. Favorite Food \n2. Hometown \n3. Favorite Color " +
                        $"\n4. Favorite Activity  \nPlease Enter a number from 1-4: ");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (input2 == 1)
                    {
                      
                       Console.WriteLine($"\n{cartoons[input - 1]}'s favorite food is {food[input - 1]}.\n");
                    }
                    else if (input2 == 2)
                    {
                        Console.WriteLine($"\n{cartoons[input - 1]}'s hometown is in {hometown[input - 1]}.\n");
                    }
                    else if (input2 == 3)
                    {
                        Console.WriteLine($"\n{cartoons[input - 1]}'s favorite color is {color[input - 1]}.\n");
                    }
                    else if (input2 == 4)
                    {
                        Console.WriteLine($"\n{cartoons[input - 1]}'s favorite activity is {activity[input - 1]}.\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid Entry. Please try again, what did you want to learn from the {cartoons[input - 1]}? \n");
                    }
                }
                while (GetAnotherCartoonInfo());
            }
            catch(IndexOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! Please Try Again!");
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid Entry. Please Try Again! \n");
            }

        }
        public static void DisplayCharacters(string[] character)
        {
            for (int i = 0; i < character.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {character[i]}");
            }
        }

        public static int GetInput(string input)
        {
            Console.Write(input);
            return int.Parse(Console.ReadLine());
        }

        public static bool GetAnotherCartoonInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Would you like to learn about another cartoon character? Please enter y/n: \n");
            string anotherCharacter = Console.ReadLine().ToLower();

            if (anotherCharacter == "y" || anotherCharacter == "yes")
            {
                return true;
            }
            else if (anotherCharacter == "n" || anotherCharacter == "no")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid Entry, please enter either 'y' or 'n': ");
                return GetAnotherCartoonInfo();
            }
        }
    }
}
