using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a linked list
            LinkedList<int> linkedList = new LinkedList<int>();

            // Add elements to the linked list
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            // Iterate through the list and print the elements
            foreach (int element in linkedList)
            {
                Console.WriteLine("Element in the list: " + element);
            }
        }
    }
}
