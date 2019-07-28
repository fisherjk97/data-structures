using System;
using System.Collections.Generic;

        /*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick*/


namespace HashTable
{

    /// <summary>
    /// The hash table data chain
    /// </summary>
    /// <typeparam name="TKey">The key type of the hash table</typeparam>
    /// <typeparam name="TValue">The value type of hash table</typeparam>
    public class HashTableArrayNode<TKey, TValue>
    {
        /*
        This list contains the actual data in the hash table. 
        It chains together data collisions. 
        It would be possible to use a list only when there is a collision to avoid
        allocating the list unncessarily but this approach makes the implementation easier to follow for this example
         */

        LinkedList<HashTableNodePair<TKey, TValue>> _items;

        /// <summary>
        /// Adds the key/value pair to the node.
        /// If the key already exists in the list an ArgumentException will be thrown
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
         public void Add(TKey key, TValue value){
            //lazy init the linked list
            if(_items == null){
                _items = new LinkedList<HashTableNodePair<TKey, TValue>>();
            } else{
                //Multiple items might collide and exist in this list - but each key should only be in the list once
                foreach(HashTableNodePair<TKey, TValue> pair in _items){
                    if(pair.Key.Equals(key)){
                        throw new ArgumentException("The collection already contains the key");
                    }
                } 
            }

            //if we made it this far, then add the item
            _items.AddFirst(new HashTableNodePair<TKey, TValue>(key, value));
         }


        /// <summary>
        /// Updates the value of the existng key/value pair in the list
        /// If the key does not exist in the list an ArgumentException will be thrown
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Update(TKey key, TValue value){
            bool updated = false;

            if(_items != null){
                //check each item in the list for the specified key
                foreach (HashTableNodePair<TKey, TValue> pair in _items){
                    if(pair.Key.Equals(key)){
                        //update the value
                        pair.Value = value;
                        updated = true;
                        break;
                    }
                }
            }

            if(!updated){
                throw new ArgumentException("The collection does not contain the key");
            }
        }

        /// <summary>
        /// Finds and returns the value for the specified key
        /// </summary>
        /// <param name="key">The key whose value is sought</param>
        /// <param name="value">The value associated with the specified key</param>
        /// <returns>True if the value was found, false otherwise</returns>
        public bool TryGetValue(TKey key, out TValue value){
            value = default(TValue);

            bool found = false;

            if(_items != null){
                foreach (HashTableNodePair<TKey, TValue> pair in _items){
                    if(pair.Key.Equals(key)){
                        //update the value
                        value = pair.Value;
                        found = true;
                        break;
                    }
                }
            }

            return found;
        }

        /// <summary>
        /// Removes the item from the list whose key matches
        /// </summary>
        /// <param name="key">The key of the item to remove</param>
        /// <returns>True if the item was removed, false otherwise</returns>
        public bool Remove(TKey key){
            bool removed = false;

            if(_items != null){

                //start at the front of the linked list
                LinkedListNode<HashTableNodePair<TKey, TValue>> current = _items.First;

                while(current != null){
               
                    //if we found the item to remove
                    if(current.Value.Key.Equals(key)){
                        //update the value
                        _items.Remove(current);
                        removed = true;
                        break;
                    }
                    //move on to the next item in the list
                    current = current.Next;
                }
            }

            return removed;

        }

        /// <summary>
        /// Removes all items from the list
        /// </summary>
        public void Clear(){
            if(_items != null){
                _items.Clear();
            }
        }


        /// <summary>
        /// Returns an enumerator for all the values in the list
        /// </summary>
        /// <value></value>
        public IEnumerable<TValue> Values{
            get {
                if(_items != null){
                    foreach(HashTableNodePair<TKey, TValue> node in _items){
                        yield return node.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Returns an enumerator for all the keys in the list
        /// </summary>
        /// <value></value>
        public IEnumerable<TKey> Keys{
            get {
                if(_items != null){
                    foreach(HashTableNodePair<TKey, TValue> node in _items){
                        yield return node.Key;
                    }
                }
            }
            
        }

        /// <summary>
        /// Returns an enumerator for all the key/value pairs in the list
        /// </summary>
        /// <value></value>
        public IEnumerable<HashTableNodePair<TKey, TValue>> Items{
             get {
                if(_items != null){
                    foreach(HashTableNodePair<TKey, TValue> node in _items){
                        yield return node;
                    }
                }
            }
        }

    }
}