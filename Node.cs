namespace DataStructures
{
    public class Node
    {
        public int Value {get; set;}
        public Node Next {get;set;}

        public Node Previous {get;set;}

        public Node(int value){
            Value = value;
            Next = null;
            Previous = null;
        }

        public Node(int value, Node next){
            Value = value;
            Next = next;
        }

        public Node(int value, Node next, Node previous){
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}