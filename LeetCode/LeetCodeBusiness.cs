namespace LeetCode
{
    public class LeetCodeBusiness : ILeetCodeBusiness
    {
        private readonly ILogger<LeetCodeBusiness> _logger;

        public LeetCodeBusiness(ILogger<LeetCodeBusiness> logger)
        {
            _logger = logger;
        }

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
    }
}
