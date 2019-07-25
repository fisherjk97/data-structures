using System;
using System.Collections.Generic;
namespace Stack.List
{
        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick */
        
        //Linked List
        /*
        Pros: 
        - No hard size (depth) limit than array
        - Easy to implement, no bounds checking
        
        Cons: 
        - Memory allocation on push
        - per-node memory overhead
        - potential performance issues
        - data fragmentation
        */


        /// <summary>
        /// As Last In First Out (LIFO) collection implemented as a linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Stack<T> : IEnumerable<T>{

            //allocate the list
            private LinkedList<T> _list = new LinkedList<T>();
        
            /// <summary>
            /// Add the item to the stack
            /// </summary>
            /// <param name="item"></param>
            public void Push(T item){
                _list.AddFirst(item);
            }

            /// <summary>
            /// Removes and returns the top item from the stack
            /// </summary>
            /// <returns></returns>
             public T Pop(){
                if(_list.Count == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                T value = _list.First.Value;
                _list.RemoveFirst();

                return value;
            }


            /// <summary>
            /// Returns the top item from the stack without removing it from the stack
            /// </summary>
            /// <returns></returns>
             public T Peek(){
                if(_list.Count == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                return _list.First.Value;
             
            }

            /// <summary>
            /// The current number of items in the stack
            /// </summary>
            /// <returns></returns>
            public int Count {
                get {
                        return _list.Count;
                }
             
            }

            /// <summary>
            /// Removes all items from the stack
            /// </summary>
            public void Clear(){
                _list.Clear();
            }

            /// <summary>
            /// Enumerates each item in the stack in LIFO order. The stack remains unaltered
            /// </summary>
            /// <returns></returns>
            public IEnumerator<T> GetEnumerator(){
                return _list.GetEnumerator();
            }


             /// <summary>
            /// Enumerates each item in the stack in LIFO order. The stack remains unaltered
            /// </summary>
            /// <returns></returns>
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(){
                return _list.GetEnumerator();
            }



        
        }
    
}