namespace LeetCode
{
    public class LeetCodeBusiness : ILeetCodeBusiness
    {
        private readonly ILogger<LeetCodeBusiness> _logger;

        public LeetCodeBusiness(ILogger<LeetCodeBusiness> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public int[] TwoSum(int[] nums, int target)
        {
            // O(n)
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                // target = x + y;
                var x = nums[i];
                var y = target - x;

                if (dic.TryGetValue(y, out var yIndex))
                {
                    return new int[2] { yIndex, i };
                }
                else
                {
                    if (!dic.ContainsKey(x))
                        dic.Add(x, i);
                }
            }

            throw new ArgumentException("No solution found");
        }

        /// <inheritdoc/>
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            if (x < 10) return true;

            var value = x.ToString();

            return value == new string(value.Reverse().ToArray());
        }

        /// <inheritdoc/>
        public int RemoveElement(int[] nums, int val)
        {
            var result = 0;

            foreach (var num in nums)
            {
                if (num != val)
                {
                    nums[result++] = num;
                }
            }

            return result;
        }
    }
}
