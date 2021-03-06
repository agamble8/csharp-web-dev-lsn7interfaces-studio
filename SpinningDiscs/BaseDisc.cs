﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc 
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Contents { get; set; }
        public string DiscType { get; set; }
        public int Rpm { get; set; }


        public BaseDisc(string name, string contents)
        {
            Name = name;
            Contents = contents;
        }

        public void ReportInfo()
        {
            Console.WriteLine("Disc Name: " + Name + "\nContents: " + Contents);
        }

    }
}
