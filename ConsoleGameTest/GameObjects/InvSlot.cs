using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTest.GameObjects
{
    internal class InvSlot
    {
        private string _itemCode = string.Empty;
        public string ItemCode 
        { 
            get
            {
                return _itemCode;
            }
            set
            {
                if (Count == 0)
                {
                    _itemCode = value;
                }
                else
                {
                    throw new InvSlotAlreadyPopulatedException(
                        string.Format("Slot already contains an item ({0}), cannot set to {1}", ItemCode)
                    );
                }
            }
        }

        public int Count { get; private set; }

        public InvSlot()
        {
            ItemCode = string.Empty;
            Count = 0;
        }

        public void IncreaseItems(int amount)
        {
            if (_itemCode == string.Empty)
            {
                throw new InvSlotItemCodeNotSetException("Cannot add items to slot - no item code has been set");
            }
            Count += amount;
        }

        public void RemoveItems(int amount)
        {
            if (Count - amount < 0)
            {
                throw new InvSlotNegativeCountException(
                    string.Format("Slot only contains {0} items, cannot remove {1}", Count, amount)
                );
            }
            Count -= amount;
        }

        public void RemoveAllItems()
        {
            Count = 0; 
        }
    }

    [Serializable]
    public class InvSlotAlreadyPopulatedException : Exception
    {
        public InvSlotAlreadyPopulatedException() { }
        public InvSlotAlreadyPopulatedException(string message)
      : base(message) { }

        public InvSlotAlreadyPopulatedException(string message, Exception inner)
            : base(message, inner) { }
    }

    [Serializable]
    public class InvSlotNegativeCountException : Exception
    {
        public InvSlotNegativeCountException() { }
        public InvSlotNegativeCountException(string message)
      : base(message) { }

        public InvSlotNegativeCountException(string message, Exception inner)
            : base(message, inner) { }
    }

    [Serializable]
    public class InvSlotItemCodeNotSetException : Exception
    {
        public InvSlotItemCodeNotSetException() { }
        public InvSlotItemCodeNotSetException(string message)
      : base(message) { }

        public InvSlotItemCodeNotSetException(string message, Exception inner)
            : base(message, inner) { }
    }
}
