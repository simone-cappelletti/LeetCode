namespace LeetCode
{
    public class StockSpanner
    {
        private Stack<(int, int)> _prices = new();

        public StockSpanner()
        {

        }

        public int Next(int price)
        {
            var counter = 1;

            while (_prices.Count > 0 && _prices.Peek().Item1 <= price)
                counter += _prices.Pop().Item2;

            _prices.Push((price, counter));

            return counter;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }
    }
}
