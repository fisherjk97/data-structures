using System;
using System.Collections.Generic;
using DataStructures;
namespace Queue.Priority
{
        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick*/

        /// <summary>
        /// A collection that returns the highest priority item first and lowest priority item last
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class PriorityQueue<T> : IEnumerable<T> where T: IComparable<T>{

            //allocate the list
            private LinkedList<T> _list = new LinkedList<T>();
        
            /// <summary>
            /// Add the item  to the queue in priority order
            /// </summary>
            /// <param name="item"></param>
            public void Enqueue(T item){
                if(_list.Count == 0){
                    _list.AddLast(item);

                }else{
                    //find the proper insert point
                    var current = _list.First;

                    //while we're not at the end of the list and current value
                    //is larger than the value being inserted...
                    while(current != null && current.Value.CompareTo(item) > 0){
                        current = current.Next;
                    }
                    if(current == null){
                        //we made it to the end of the list
                        _list.AddLast(item);
                    }else{
                        //the current item is <= to the one being added
                        //so add the item before it
                        _list.AddBefore(current, item);
                    }
                }
            }

            /// <summary>
            /// Removes and returns the highest priority item from the queue
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

            // Compares by Length, Height, and W<idth.

        public int CompareTo(DataStructures.Node a, DataStructures.Node b){
            if(a.Value > b.Value){
                return 1;
            }else if (a.Value < b.Value){
                return -1;
            }else{
                return 0;
            }
            
        }



        
        }
    
}