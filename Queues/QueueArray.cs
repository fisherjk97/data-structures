using System;
using System.Collections.Generic;
namespace Queue.Array
{
        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick */
        
        //Array
        /*
        Pros: 
        - performance improvements
        - closer in memory
        - data locality
        - fast enqueue/dequeue when no growing
        Cons: 
        - difficult to setup
        */


        /// <summary>
        /// As First In First Out (FIFO) collection implemented as an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Queue<T> : IEnumerable<T>{

            //the array of items contained in the queue. Initialize to 0 length
            T[] _items = new T[0];

            //the current number of items in the queue
            int _size;

            //the index of the first (oldest) item in the queue
            int _head = 0;

            //the index of the last (newest) item in the queue
            int _tail = -1;
       
            /// <summary>
            /// Add the item to the back of the queue
            /// </summary>
            /// <param name="item"></param>
            public void Enqueue(T item){
               //_size = 0 ... fist push
               //_size == length ... growth boundary
               if(_size == _items.Length){
                   //initalize size of 4, otherwise double the current length
                   int newLength = _size == 0 ? 4: _size *2;

                   //allocate, copy and assign the new array
                   T[] newArray = new T[newLength];

                   if(_size > 0){
                       //copy contents
                       /*
                       if the array has no wrapping, just copy the valid range
                       else copy from head to end of the array and then from 0 to the tail
                       if tail is less than head we've wrapped
                       */

                       int targetIndex = 0;

                       //check for wrapping
                       if(_tail < _head){

                           //copy the _items[head]..._items[end] -> newArray[0]..newArray[n]
                           for (int index = _head; index < _items.Length; index++){
                               newArray[targetIndex] = _items[index];
                               targetIndex++;
                           }

                           //copy _items[0].._items[tail] - > newArray[n+1]..
                           for(int index = 0; index <= _tail; index++){
                               newArray[targetIndex] = _items[index];
                               targetIndex++;
                           }
                       }else{
                           //didn't need to wrap around
                           //copy the _items[head].._items[tail] - > newArray[0]...newArray[n]
                            for(int index = _head; index <= _tail; index++){
                               newArray[targetIndex] = _items[index];
                               targetIndex++;
                           }
                       }

                       _head = 0;
                       _tail = targetIndex - 1;//compensate for extra bump

                   }else{
                       _head = 0;
                       _tail = -1;
                   }
        
                    _items = newArray;
               }

               //now we have a properly resized array and can focus on wrapping issues

               //if _tail is at the end of the array we need to wrap arround
               if(_tail == _items.Length-1){
                   _tail = 0;
               }else{
                   _tail++;
               }

               _items[_tail] = item;
               _size++;
            }

            /// <summary>
            /// Removes and returns the front item from the queue
            /// </summary>
            /// <returns></returns>
             public T Dequeue(){
                if(_size == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }


                T value = _items[_head];

                if(_head == _items.Length - 1){
                    //if the head is at the last index in the array - wrap around
                    _head = 0;
                }else{
                    //move to the next value
                    _head++;
                }

                _size--;
                return value;
               
            }


            /// <summary>
            /// Returns the front item from the queue without removing it from the queue
            /// </summary>
            /// <returns></returns>
             public T Peek(){
                if(_size == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                return _items[_head];
             
            }

            /// <summary>
            /// The current number of items in the stack
            /// </summary>
            /// <returns></returns>
            public int Count {
                get {
                        return _size;
                }
             
            }

            /// <summary>
            /// Removes all items from the queue
            /// </summary>
            public void Clear(){
                _size = 0;//doesn't actually clear out array
                _head = 0;
                _tail = -1;
                //if implementing production queue, deal with disposing
            }

            /// <summary>
            /// Enumerates each item in the queue in FIFO order. The stack remains unaltered
            /// </summary>
            /// <returns></returns>
            public IEnumerator<T> GetEnumerator(){
                if(_size > 0){
                    //if the queue wraps then handle that case
                    if(_tail < _head){
                        
                        //head -> head
                        for(int index = _head; index < _items.Length; index++){
                            yield return _items[index];
                        }

                        //0 -> tail
                        for(int index = 0; index < _tail; index++){
                            yield return _items[index];
                        }

                    }else{
                        //head -> tail
                        for(int index = _head; index < _tail; index++){
                            yield return _items[index];
                        }
                    }
                }
            }


             /// <summary>
            /// Enumerates each item in the stack in LIFO order. The stack remains unaltered
            /// </summary>
            /// <returns></returns>
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator(){
                return GetEnumerator();
            }



        
        }
    
}