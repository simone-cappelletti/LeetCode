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
            _logger.LogInformation(nameof(TwoSum), nums, target);

            var result = _leetCodeBusiness.TwoSum(nums, target);

            return result;
        }

        [HttpPost]
        public bool IsPalindrome(int x)
        {
            _logger.LogInformation(nameof(IsPalindrome), x);

            var result = _leetCodeBusiness.IsPalindrome(x);

            return result;
        }

        [HttpPost]
        public int RemoveElement(int[] nums, int val)
        {
            _logger.LogInformation(nameof(RemoveElement), nums, val);

            var result = _leetCodeBusiness.RemoveElement(nums, val);

            return result;
        }

        [HttpPost]
        public int RemoveDuplicates(int[] nums)
        {
            _logger.LogInformation(nameof(RemoveDuplicates), nums);

            var result = _leetCodeBusiness.RemoveDuplicates(nums);

            return result;
        }

        [HttpPost]
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            _logger.LogInformation(nameof(LengthOfLongestSubstringTwoDistinct), s);

            var result = _leetCodeBusiness.LengthOfLongestSubstringTwoDistinct(s);

            return result;
        }
    }
}
