namespace LeetCode
{
    public class LRUCache
    {
        // Time Complexity: O(1)
        // Space Complexity: O(capacity)

        private LinkedList<LRUCacheItem> _head = new();
        private Dictionary<int, LinkedListNode<LRUCacheItem>> _dic = new();
        private int _capacity = 0;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if (_dic.TryGetValue(key, out var LRUCacheItem))
            {
                _head.Remove(LRUCacheItem);
                _head.AddFirst(LRUCacheItem);
                return LRUCacheItem.Value.Value;
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if (_dic.TryGetValue(key, out var LRUCacheItem))
            {
                LRUCacheItem.Value.Value = value;
                _head.Remove(LRUCacheItem);
                _head.AddFirst(LRUCacheItem);
            }
            else
            {
                if (_dic.Count >= _capacity)
                {
                    var lastNode = _head.Last;
                    _dic.Remove(lastNode.Value.Key);
                    _head.RemoveLast();
                }

                var newNode = new LinkedListNode<LRUCacheItem>(new LRUCacheItem(key, value));
                _dic.Add(key, newNode);
                _head.AddFirst(newNode);
            }
        }

        private class LRUCacheItem
        {
            public int Key { get; }
            public int Value { get; set; }

            public LRUCacheItem(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}
