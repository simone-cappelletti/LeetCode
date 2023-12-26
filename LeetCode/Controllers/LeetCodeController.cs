using Microsoft.AspNetCore.Mvc;

namespace LeetCode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeetCodeController : ControllerBase
    {
        private readonly ILogger<LeetCodeController> _logger;
        private readonly ILeetCodeBusiness _leetCodeBusiness;

        public LeetCodeController(
            ILogger<LeetCodeController> logger,
            ILeetCodeBusiness leetCodeBusiness)
        {
            _logger = logger;
            _leetCodeBusiness = leetCodeBusiness;
        }

        [HttpPost]
        public int[] TwoSum(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg}", nameof(TwoSum), nums, target);

            var result = _leetCodeBusiness.TwoSum(nums, target);

            return result;
        }

        [HttpPost]
        public bool IsPalindrome(int x)
        {
            _logger.LogInformation("{method} - {arg}", nameof(IsPalindrome), x);

            var result = _leetCodeBusiness.PalindromeNumber(x);

            return result;
        }

        [HttpPost]
        public int RemoveElement(int[] nums, int val)
        {
            _logger.LogInformation("{method} - {arg}", nameof(RemoveElement), nums, val);

            var result = _leetCodeBusiness.RemoveElement(nums, val);

            return result;
        }

        [HttpPost]
        public int RemoveDuplicates(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(RemoveDuplicates), nums);

            var result = _leetCodeBusiness.RemoveDuplicatesFromSortedArray(nums);

            return result;
        }

        [HttpPost]
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            _logger.LogInformation("{method} - {arg}", nameof(LengthOfLongestSubstringTwoDistinct), s);

            var result = _leetCodeBusiness.LengthOfLongestSubstringTwoDistinct(s);

            return result;
        }

        [HttpPost]
        public bool ValidParentheses(string s)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ValidParentheses), s);

            var result = _leetCodeBusiness.ValidParentheses(s);

            return result;
        }
    }
}
