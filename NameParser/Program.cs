using System;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name");
            var firstName = Console.ReadLine();

            foreach (var letter in firstName)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("Enter Your Last Name");
            var lastName = Console.ReadLine();
            var lastNameWithSpaces = "";

            foreach (var letter in lastName.ToUpper())
            {
                lastNameWithSpaces += letter + " ";
            }

            Console.WriteLine(lastNameWithSpaces.Trim());

            Console.WriteLine("Do You Have a Middle Name? (y/n)");
            var hasMiddleName = Console.ReadLine();
            var middleName = "";

            if (hasMiddleName == "y")
            {
                Console.WriteLine("What is your Middle Name?");
                middleName = Console.ReadLine();
                var i = 0; 

                foreach(var letter in middleName)
                {
                    Console.WriteLine(letter.ToString().PadLeft(++i));
                }
            }
            else
            {
                Console.WriteLine($@" {firstName}, You are dumb.


                    And no one likes you.");
            }

            Console.WriteLine($"Goodbye {firstName} {middleName} {lastName}. Press Enter to Exist.");
            Console.ReadLine();
        }
    }
}
