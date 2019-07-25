using System.Diagnostics;
using System;
using DataStructures;
namespace LinkedList
{
    /*Benefits:
    - Efficient Insertion

    */
    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

       public void Print(){
            Node current = Head;
            if(current != null){
                while(current != null){
                    if(current.Previous == null){
                        Console.Write("head<--[" + current.Value);
                    }else{

                        Console.Write("<--[" + current.Value);
                    }
                    if(current.Next != null){
                        Console.Write("|*]-->");
                    }else{
                        Console.Write("|null]-->tail");
                    }
                    current = current.Next;
                    
                }
                Console.WriteLine();
            }else{
                Console.WriteLine("Empty");
            }
        }

        public void AddToFront(Node node){
            //save the existing linked list head so we don't lose it
            Node temp = Head;

            //point head to the new node
            Head = node;

            //insert the rest of the linked list behind the head
            Head.Next = temp;

            if(Head.Next == null){
                //if the list was empty then the head and tail should both point to new node
                Tail = Head;
            }else{
                temp.Previous = Head;
            }
        }

        public void AddToFront(int value){
            Console.WriteLine("Adding Node: " + value + " to Front");
            Node node = new Node(value);
            AddToFront(node);
        }

        public void AddToEnd(Node node){
            if(Head == null){
                //if the list was empty then set the head to be the new node
                Head = node;
                Tail = node;
            }else{
                Tail.Next = node;
                node.Previous = Tail;
            }

            Tail = node;
        }

         public void AddToEnd(int value){
            Console.WriteLine("Adding Node: " + value + " to End");
            Node node = new Node(value);
            AddToEnd(node);
        }

        public void RemoveFirst(){
            Console.WriteLine("Removing Front Node");

            //if list size > 0
            if(Head != null){
                Head = Head.Next;
                //if list size = 0
                if(Head == null){
                    Tail = null;
                }else{
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast(){
             Console.WriteLine("Removing Last Node");
            //if list size > 0
            if(Head != null){
                //if list size = 1
                if(Head.Next == null){
                    Head = null;
                    Tail = null;
                }else{

                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                    /* Node last = current.Previous;
                    tail = current;
                    tail = last;*/
                    
                   
                }
            }
        
        }


        public Node RemoveNode(Node head, int value){
            Console.WriteLine("Removing Node: " + value);
            Node n = head;

            if(n.Value == value){
                head =  head.Next;//moved head
            }

            while (n.Next != null){
                if(n.Next.Value == value){
                    n.Next = n.Next.Next;
                    return head;
                }
                n = n.Next;
                n.Next.Previous = n.Previous;
            }

            return head;
        }

       
    

    

    }



}