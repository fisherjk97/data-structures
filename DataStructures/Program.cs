using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddToFront(1);
            myList1.AddToFront(2);
            myList1.AddToFront(3);
            myList1.Print();
            Console.WriteLine("Removing First:");
            myList1.RemoveFirst();
            myList1.Print();
            Console.WriteLine("Removing First:");
            myList1.RemoveFirst();
            myList1.Print();
            Console.WriteLine("Removing First:");
            myList1.RemoveFirst();
            myList1.Print();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddToEnd(1);
            myList2.AddToEnd(2);
            myList2.AddToEnd(3);
            myList2.Print();
            Console.WriteLine("Removing Last:");
            myList2.RemoveLast();
            myList2.Print();
            Console.WriteLine("Removing Last:");
            myList2.RemoveLast();
            myList2.Print();
            Console.WriteLine("Removing Last:");
            myList2.RemoveLast();
            myList2.Print();
        }
    }
}
