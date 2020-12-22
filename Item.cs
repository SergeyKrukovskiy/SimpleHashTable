using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleHashTable
{
    class Item
    {
        public int Value { get; set; }
        public int Key { get; set; }

        public Item (int Key, int Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
