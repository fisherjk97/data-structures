using System;
using  LinkedList;
using Calculator;
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singly Linked List");
            SinglyLinkedList myList1 = new SinglyLinkedList();

            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);

            myList1.AddToFront(n1);
            myList1.AddToEnd(n2);
            myList1.AddToFront(n3);
            myList1.AddToEnd(n4);
            myList1.Print();
            myList1.RemoveNode(myList1.Head, n2.Value);
            myList1.Print();
            myList1.RemoveFirst();
            myList1.Print();
            myList1.RemoveLast();
            myList1.Print();
            myList1.RemoveLast();
            myList1.Print();
   
            Console.WriteLine("Doubly Linked List");
            DoublyLinkedList myList2 = new DoublyLinkedList();


            myList2.AddToFront(n1);
            myList2.AddToEnd(n2);
            myList2.AddToFront(n3);
            myList2.AddToEnd(n4);
            myList2.Print();
            myList2.RemoveNode(myList2.Head, n2.Value);
            myList2.Print();
            myList2.RemoveFirst();
            myList2.Print();
            myList2.RemoveLast();
            myList2.Print();
            myList2.RemoveLast();
            myList2.Print();
            myList2.RemoveFirst();
            myList2.Print();


            //Post Fix Calculator

            string[] expression = new string[] {
                "5", "6", "7", "*", "+", "1", "-" 
            };

            Console.WriteLine("Postfix calculator");
            PostfixCalculator.Print(expression);
            Console.WriteLine("Result: " + PostfixCalculator.Calculate(expression));
        }
    }
}
