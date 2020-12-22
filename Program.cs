using System;

namespace SimpleHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleHashTable hashTable = new SimpleHashTable();
            hashTable.Add(1, 2);
            hashTable.Add(2, 3);
            hashTable.Add(3, 4);
            hashTable.Add(5, 6);
            hashTable.Add(122, 7);
            hashTable.Add(120, 8);
            hashTable.Add(237, 9);
        }
    }
}
