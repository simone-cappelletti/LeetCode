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

        [HttpPost]
        public int BestTimeToBuyAndSellStock(int[] prices)
        {
            _logger.LogInformation("{method} - {arg}", nameof(BestTimeToBuyAndSellStock), prices);

            var result = _leetCodeBusiness.BestTimeToBuyAndSellStock(prices);

            return result;
        }

        [HttpPost]
        public ListNode MergeTwoSortedListsRecursive(ListNode list1, ListNode list2)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(MergeTwoSortedListsRecursive), list1, list2);

            var result = _leetCodeBusiness.MergeTwoSortedListsRecursive(list1, list2);

            return result;
        }

        [HttpPost]
        public ListNode MergeTwoSortedListsIterative(ListNode list1, ListNode list2)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(MergeTwoSortedListsIterative), list1, list2);

            var result = _leetCodeBusiness.MergeTwoSortedListsIterative(list1, list2);

            return result;
        }

        [HttpPost]
        public bool ValidPalindromeString(string s)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ValidPalindromeString), s);

            var result = _leetCodeBusiness.ValidPalindromeString(s);

            return result;
        }

        [HttpPost]
        public int[][] InsertInterval(int[][] intervals, int[] newInterval)
        {
            _logger.LogInformation("{method} - {arg1}, {args2}", nameof(InsertInterval), intervals, newInterval);

            var result = _leetCodeBusiness.InsertInterval(intervals, newInterval);

            return result;
        }

        [HttpPost]
        public int LongestSubstringWithoutRepeatingCharacters(string s)
        {
            _logger.LogInformation("{method} - {arg}", nameof(LongestSubstringWithoutRepeatingCharacters), s);

            var result = _leetCodeBusiness.LongestSubstringWithoutRepeatingCharacters(s);

            return result;
        }
    }
}
