using ConsoleGameTest.GameObjects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.Lookups
{
    internal class ItemLookup
    {
        public static Item GetByCode(string code)
        {
            return __HardcodedLookupByCode(code);
        }

        private static Item __HardcodedLookupByCode(string code)
        {
            if (code == "sword")
            {
                return new Item("sword", "Sword");
            }
            else if (code == "apple")
            {
                return new Item("apple", "Apple");
            }
            throw new NoItemInLookupException(string.Format("No item with code {0} found in lookup", code));
        }
    }

    [Serializable]
    public class NoItemInLookupException : Exception 
    {
        public NoItemInLookupException() { }
        public NoItemInLookupException(string message)
      : base(message) { }

        public NoItemInLookupException(string message, Exception inner)
            : base(message, inner) { }
    }
}
