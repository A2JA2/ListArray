using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new Linkedlist.
            LinkedList<String> ll = new LinkedList<String>();

            //create a new LinkedlistNode of type String
            LinkedListNode<String> lln = new LinkedListNode<String>("Basil");

            // Add the "Basil" node to the emty linked list
            ll.AddLast(lln);
            // Add more nodes to the linked list, but specify where ...
            ll.AddFirst("Ethel");
            ll.AddLast("Bertie");
            ll.AddFirst("Norman");
            // As you can see, c# will insert each node into the requested locaiton in the list.
            // It is also possible to insert a new node between existing nodes.

            // display the linked list using a for loop
            Console.WriteLine("We currently have {0} student(s) stored.", ll.Count);
            foreach (var student in ll)
            {
                Console.WriteLine("Node's data is {0}", student);
            }
            // The logical order of the data items does not have to match its physical order in the RAM.
            // Linked lists are fast, flexible alternatives to using an array.

            Console.ReadKey();
        }
    }
}
