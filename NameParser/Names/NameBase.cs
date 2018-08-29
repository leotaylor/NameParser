using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    abstract class NameBase
    {
        private readonly string _whichName;

        public string Name { get; protected set; }

        public NameBase(string whichName)
        {
            _whichName = whichName;
        }

        public virtual void GetName()
        {
            Console.WriteLine($"Enter Your {_whichName} Name");
            Name = Console.ReadLine();
        }

        public abstract void PrintName();

    }
}
