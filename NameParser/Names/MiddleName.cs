using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName
    {
        private readonly FirstName _firstName;

        public string Name { get; private set; } = "";

        public MiddleName(FirstName firstName)
        {
            Name = "";
            _firstName = firstName;
        }

        bool ConfirmMiddleName()
        {
            Console.WriteLine("Do You Have a Middle Name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void GetName()
        {
            if (ConfirmMiddleName())
            {
                Console.WriteLine("What is your Middle Name?");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@" {_firstName}, that's fine.");
            }
        }

        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
