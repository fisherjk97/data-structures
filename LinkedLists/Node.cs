namespace DataStructures
{
    public class Node
    {
        public int Value {get; set;}
        public Node Next {get;set;}

        public Node Previous {get;set;}

        public int Priority {get; set;}

        public Node(int value){
            Value = value;
            Next = null;
            Previous = null;
        }
         public Node(int value, int priority){
            Value = value;
            Next = null;
            Previous = null;
            Priority = priority;
        }

        public Node(int value, Node next){
            Value = value;
            Next = next;
            Priority = 0;
        }
        public Node(int value, Node next, int priority){
            Value = value;
            Next = next;
            Priority = priority;
        }

        public Node(int value, Node next, Node previous){
            Value = value;
            Next = next;
            Previous = previous;
            Priority = 0;
        }

           public Node(int value, Node next, Node previous, int priority){
            Value = value;
            Next = next;
            Previous = previous;
            Priority = priority;
        }

   
    }
}