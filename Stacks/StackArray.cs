using System;
using System.Collections.Generic;
namespace Stack.Array
{
        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick */
        
        //Array
        /*
        Pros: 
        - performance improvements
        
        Cons: 
       
        */


        /// <summary>
        /// As Last In First Out (LIFO) collection implemented as an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Stack<T> : IEnumerable<T>{

            //the array of items contained in the stack. Initialize to 0 length
            T[] _items = new T[0];

            //the current number of items in the stack
            int _size;

       
            /// <summary>
            /// Add the item to the stack
            /// </summary>
            /// <param name="item"></param>
            public void Push(T item){
               //_size = 0 ... fist push
               //_size == length ... growth boundary
               if(_size == _items.Length){
                   //initalize size of 4, otherwise double the current length
                   int newLength = _size == 0 ? 4: _size *2;

                   //allocate, copy and assign the new array
                   T[] newArray = new T[newLength];
                   _items.CopyTo(newArray, 0);
                   _items = newArray;
               }

               //add the item to the stack array and increase the size
               _items[_size] = item;
               _size++;
            }

            /// <summary>
            /// Removes and returns the top item from the stack
            /// </summary>
            /// <returns></returns>
             public T Pop(){
                if(_size == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                _size--;
                return _items[_size];
               
            }


            /// <summary>
            /// Returns the top item from the stack without removing it from the stack
            /// </summary>
            /// <returns></returns>
             public T Peek(){
                if(_size == 0){
                    throw new InvalidOperationException("The Stack is empty");
                }
                return _items[_size - 1];
             
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
            /// Removes all items from the stack
            /// </summary>
            public void Clear(){
                _size = 0;//doesn't actually clear out array

                //if implementing production stack, deal with disposing
            }

            /// <summary>
            /// Enumerates each item in the stack in LIFO order. The stack remains unaltered
            /// </summary>
            /// <returns></returns>
            public IEnumerator<T> GetEnumerator(){
                for(int i = _size - 1; i >= 0; i--){
                    yield return _items[i];
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