using System.Diagnostics;
using System;

namespace DataStructures
{
    /*Benefits:
    - Efficient Insertion

    */
    public class LinkedList
    {
        private Node head;
        private Node tail;

        public void Print(){
            Node current = head;
            if(current != null){
                while(current != null){
                    Console.Write("[" + current.Value);
                    if(current.Next != null){
                        Console.Write("|*]-->");
                    }else{
                        Console.Write("|null]");
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
            Node temp = head;

            //point head to the new node
            head = node;

            //insert the rest of the linked list behind the head
            head.Next = temp;

            if(head.Next == null){
                //if the list was empty then the head and tail should both point to new node
                tail = head;
            }
        }

        public void AddToFront(int value){
            Node node = new Node(value);
            AddToFront(node);
        }

        public void AddToEnd(Node node){
          
            if(head == null){
                //if the list was empty then set the head to be the new node
                head = node;
                tail = node;
            }else{
                Node current = head;
                while(current.Next != null){
                    current = current.Next;
                }
                current.Next = node;
            }
        }

         public void AddToEnd(int value){
            Node node = new Node(value);
            AddToEnd(node);
        }

        public void RemoveFirst(){
            //if list size > 0
            if(head != null){
                head = head.Next;
                //if list size = 0
                if(head == null){
                    tail = null;
                }
            }
        }

        public void RemoveLast(){
            //if list size > 0
            if(head != null){
                //if list size = 1
                if(head.Next == null){
                    head = null;
                }else{
                    //need to fix this
                    Node current = head;
                    Node last = current;

                    while(current.Next != null){
                        last = current;
                        current = current.Next;
                    }

                    last.Next = null;
                   
                }
            }
        
        }

    

    }



}