using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName : NameBase
    {
        FirstName _firstName;

        public MiddleName(FirstName firstName) : base("middle")
        {
            Name = "";
            _firstName = firstName;
        }

        bool UserHasMiddleName()
        {
            Console.WriteLine("Do You Have a Middle Name? (y/n)");
            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public override void GetName()
        {
            if (UserHasMiddleName())
            {
                base.GetName();
            }
            else
            {
                Console.WriteLine($@" {_firstName.Name}, that's fine.");
            }
        }

        public override void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}
