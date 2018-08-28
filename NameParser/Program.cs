using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            firstName.GetName();
            firstName.PrintName();

            var lastName = new LastName();
            lastName.GetName();
            lastName.PrintName();

            var middleName = new MiddleName();
            middleName.GetName(firstName.Name);
            middleName.PrintName();

            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}. Press Enter to Exist.");
            Console.ReadLine();
        }
    }
}
