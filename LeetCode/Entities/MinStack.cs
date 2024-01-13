namespace LeetCode
{
    public class MinStack
    {
        private int _size = 0;
        private Tuple<int, int>[] _array = new Tuple<int, int>[20];

        public MinStack()
        {

        }

        public void Push(int val)
        {
            if (_size == _array.Length)
            {
                var newArray = new Tuple<int, int>[_array.Length * 2];
                Array.Copy(_array, newArray, _size);
                _array = newArray;
            }

            var minValue = _size == 0 ?
                val :
                Math.Min(val, _array[_size - 1].Item2);

            _array[_size++] = new Tuple<int, int>(val, minValue);
        }

        public void Pop()
        {
            if (_size >= 0)
                _array[--_size] = new Tuple<int, int>(0, 0);
        }

        public int Top()
        {
            if (_size >= 0)
                return _array[_size - 1].Item1;
            else
                return 0;
        }

        public int GetMin()
        {
            return _array[_size - 1].Item2;
        }
    }
}
