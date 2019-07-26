using System;
using System.Collections.Generic;
namespace Queue.List
{
        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick*/

        /// <summary>
        /// A First In First Out (FIFO) collection implemented as a linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Queue<T> : IEnumerable<T>{

            //allocate the list
            private LinkedList<T> _list = new LinkedList<T>();
        
            /// <summary>
            /// Add the item to the back of the queue
            /// </summary>
            /// <param name="item"></param>
            public void Enqueue(T item){
                _list.AddLast(item);
            }

            /// <summary>
            /// Removes and returns the front item from the queue
            /// </summary>
            /// <returns></returns>
             public T Dequeue(){
                if(_list.Count == 0){
                    throw new InvalidOperationException("The queue is empty");
                }

                //store the laSt value in the temp variable
                T value = _list.First.Value;

                //remove the last item
                _list.RemoveFirst();

                //return the stored last value
                return value;
            }


            /// <summary>
            /// Returns the top item from the queue without removing it from the queue
            /// </summary>
            /// <returns></returns>
             public T Peek(){
                if(_list.Count == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                return _list.First.Value;
             
            }

            /// <summary>
            /// The current number of items in the queue
            /// </summary>
            /// <returns></returns>
            public int Count {
                get {
                        return _list.Count;
                }
             
            }

            /// <summary>
            /// Removes all items from the queue
            /// </summary>
            public void Clear(){
                _list.Clear();
            }

            /// <summary>
            /// Returns an enumerator that enumerates the queue
            /// </summary>
            /// <returns></returns>
            public IEnumerator<T> GetEnumerator(){
                return _list.GetEnumerator();
            }


            /// <summary>
            /// Returns an enumerator that enumerates the queue
            /// </summary>
            /// <returns></returns>
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(){
                return _list.GetEnumerator();
            }



        
        }
    
}