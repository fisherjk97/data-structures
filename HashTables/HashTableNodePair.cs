namespace HashTable

/*Examples from Pluralsight course "Algorithms and Data Structures - Part 1 by Robert Horvick*/

{

    /// <summary>
    /// A node in the hash table array
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class HashTableNodePair<TKey, TValue>
    {
        /// <summary>
        /// Constructs a key/value for the storage in the hash table
        /// </summary>
        /// <param name="key">The key of the key/value pair</param>
        /// <param name="value">The value of the key/value pair</param>
        public HashTableNodePair(TKey key, TValue value){
            Key = key;
            Value = value;
        }

        /// <summary>
        /// The key.
        /// The key cannot be changed because it would affect the indexing in the hash table
        /// </summary>
        /// <value></value>
        public TKey Key { get; private set; }

        /// <summary>
        /// The value
        /// </summary>
        /// <value></value>
        public TValue Value {get; set;}
    }
}