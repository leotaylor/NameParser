using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            var lastName = new LastName();
            var middleName = new MiddleName(firstName);

            firstName.GetName();
            firstName.PrintName();

            lastName.GetName();
            lastName.PrintName();

            middleName.GetName();
            middleName.PrintName();

            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}. Press Enter to Exist.");
            Console.ReadLine();
        }
    }
}
