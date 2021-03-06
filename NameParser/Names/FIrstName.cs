﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class FirstName : NameBase
    {
        public FirstName() : base("first")
        {}

        public override void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
