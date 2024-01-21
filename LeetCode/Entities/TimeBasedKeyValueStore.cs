namespace LeetCode
{
    public class TimeBasedKeyValueStore
    {
        private Dictionary<string, List<Tuple<string, int>>> _keys = new();

        public TimeBasedKeyValueStore()
        {
            // M is the number of set function calls, N is the number of get function calls, and L is average length of key and value strings.
            // Time Complexity: Set: O(ML) - Get: 0(N(L + logM))
            // Space Complexity: Set: O(ML) - Get: O(1)
        }

        public void Set(string key, string value, int timestamp)
        {
            if (_keys.TryGetValue(key, out var keyValue))
                keyValue.Add(new Tuple<string, int>(value, timestamp));
            else
                _keys[key] = new List<Tuple<string, int>>() { new Tuple<string, int>(value, timestamp) };
        }

        public string Get(string key, int timestamp)
        {
            var result = string.Empty;

            if (_keys.TryGetValue(key, out var keyValue))
            {
                if (timestamp < keyValue[0].Item2)
                    return result;

                var start = 0;
                var end = keyValue.Count() - 1;

                while (start <= end)
                {
                    var midIndex = start + (end - start) / 2;
                    var midValue = keyValue[midIndex];

                    if (midValue.Item2 > timestamp)
                        end = midIndex - 1;
                    else if (midValue.Item2 < timestamp)
                        start = midIndex + 1;
                    else if (midValue.Item2 == timestamp)
                        return midValue.Item1;
                }

                if (result == string.Empty)
                    if (end < 0)
                        result = keyValue[0].Item1;
                    else if (end > keyValue.Count())
                        result = keyValue[keyValue.Count() - 1].Item1;
                    else if (end >= 0 && end < keyValue.Count())
                        result = keyValue[end].Item1;
            }

            return result;
        }
    }
}
