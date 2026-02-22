using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.GameObjects
{
    internal class Item
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        public Item(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
