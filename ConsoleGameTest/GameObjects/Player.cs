using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.GameObjects
{
    internal class Player : DungeonEntity
    {
        public Inventory Inventory { get; private set; }

        public Player() 
        {
            Inventory = new Inventory();
        }
    }
}
