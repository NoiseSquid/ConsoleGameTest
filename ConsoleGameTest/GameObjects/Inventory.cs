using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.GameObjects
{
    internal class Inventory
    {
        public List<InvSlot> Slots { get; private set; }
        public Inventory() 
        {
            Slots = new List<InvSlot>();
        }

        public void AddItem(string itemCode)
        {
            AddItems(itemCode, 1);
        }

        public void AddItems(string itemCode, int amount)
        {
            int slot = IndexSlotOfItem(itemCode);
            if (slot >= 0)
            {
                Slots[slot].IncreaseItems(amount);
            }
            else
            {
                var newSlot = new InvSlot();
                newSlot.ItemCode = itemCode;
                newSlot.IncreaseItems(amount);
                Slots.Add(newSlot);
            }
        }

        public int CountItem(string itemCode)
        {
            int slot = IndexSlotOfItem(itemCode);
            if (slot >= 0)
            {
                return Slots[slot].Count;
            }
            else
            {
                return 0;
            }
        }

        private int IndexSlotOfItem(string itemCode)
        {
            for (int i = 0; i < Slots.Count; i++)
            {
                if (Slots[i].ItemCode == itemCode) return i;
            }
            return -1;
        }
    }

    [Serializable]
    public class InvalidItemException : Exception { }
}
