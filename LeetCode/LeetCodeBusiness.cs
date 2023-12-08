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
            for (var i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                var index = nums.LastOrDefault(x => x + value == target, -1);

                if (index != -1)
                {
                    var ii = Array.LastIndexOf(nums, index, i + 1);

                    if (ii != i)
                    {
                        return new int[2] { i, ii };
                    }
                }
            }

            return new int[2];
        }
    }
}
