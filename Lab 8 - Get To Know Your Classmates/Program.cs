using System;

namespace Lab_8___Get_To_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Let's Get to Know Your Classmates!");
                string userChoice = GetUserInput("Which student would you like to learn about? Please enter 1-3: ");

                string[] students = { "Jimmy", "Kim", "Kobe Bryant" };
                string[] food = { "Pizza", "Ramen", "Hamburger" };
                string[] hometown = { "Novi", "Phoenix", "Los Angeles", };
                string[] sports = { "Hockey", "Football", "Basketball" };

                DisplayNames(students);

                //enter try/catch to make sure there are no exception errors. Must tie in your methods together here.
                {
                    try
                    {
                        int input = GetInput();
                        GetStudentInfo(input - 1, students, hometown, food, sports);

                        Console.WriteLine($"Nice selection, what will you like to learn about {students[1]}");
                    }
                    catch
                    {
                        Console.WriteLine("Looks like there is something went wrong. ");
                    }
                }
                
                // Console.WriteLine($"Nice selection, what will you like to learn about {students[1]}");

                    userChoice = GetUserInput("Would you like to learn about their hometown or favorite food or their favorite sport? Enter food/ hometown/ sports:").ToLower();
                    // GetStudentInfo(students, food, hometown, sports
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter a number 1 - 3 to indicate which student you would like to learn about");
                }
            }
            while (GetAnotherStudentInfo());

        }
        public static void DisplayNames(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[1]}");
            }
        }
        public static void DisplayStudentFood(int input, string[] food)
        {
            Console.WriteLine($"Looks like you picked {food[input]}: ");
        }

        public static void DisplayStudentSport(int input, string sports)
        {
            Console.WriteLine($"Looks like you picked {sports[input]}: ");
        }
        //create a method where you convert a string to an int and connect it to the userchoices.
        public static int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int GetSecondInput() //use this to ask the user for hometown or food or sports.
        {
            return int.Parse(Console.ReadLine());
        }

        public static string GetStudentInfo(int input, string[] students, string[] hometown, string[] food, string[] sports) //Maybe break this method down?
        {
            try
            {
                if (userChoice == food)
                {
                    Console.WriteLine($"{students[input - 1]} likes {food[input - 1]}");
                }
                else if (userChoice == hometown)
                {
                    Console.WriteLine($"{ students}[index - 1] likes {hometown[input - 1] }");
                }
                else if (userChoice == sports)
                {
                    Console.WriteLine($"{students[input - 1]} likes {sports[input - 1]}");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Entry. Please try again, what did you want to learn from the student? ");
            }

            return GetStudentInfo(input, students, hometown, food, sports);
        }


        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static bool GetAnotherStudentInfo()
        {
            Console.WriteLine("Would you like to learn about another student? Please enter y/n");
            string anotherStudent = Console.ReadLine().ToLower();

            if (anotherStudent == "y" || anotherStudent == "yes")
            {
                return true;
            }
            else if (anotherStudent == "n" || anotherStudent == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry, please enter either y or n");
                return GetAnotherStudentInfo();
            }

        }
    }
}
