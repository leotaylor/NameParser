﻿using System;
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

            var names = new NameBase[] { firstName, lastName, middleName };

            foreach(var name in names)
            {
                name.GetName();
                name.PrintName();
            }

            Console.WriteLine($"Goodbye {firstName.Name} {middleName.Name} {lastName.Name}. Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
