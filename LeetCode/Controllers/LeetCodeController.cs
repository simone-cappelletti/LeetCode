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
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(TwoSum), nums, target);

            var result = _leetCodeBusiness.TwoSum(nums, target);

            return result;
        }

        [HttpPost]
        public int[] TwoSumII(int[] numbers, int target)
        {
            _logger.LogInformation("{method} - {arg}", nameof(TwoSumII), numbers, target);

            var result = _leetCodeBusiness.TwoSumII(numbers, target);

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
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(InsertInterval), intervals, newInterval);

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

        [HttpPost]
        public int EvaluateReversePolishNotation(string[] tokens)
        {
            _logger.LogInformation("{method} - {arg}", nameof(EvaluateReversePolishNotation), tokens);

            var result = _leetCodeBusiness.EvaluateReversePolishNotation(tokens);

            return result;
        }

        [HttpPost]
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ThreeSum), nums);

            var result = _leetCodeBusiness.ThreeSum(nums);

            return result;
        }

        [HttpPost]
        public int BinarySearch(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(BinarySearch), nums, target);

            var result = _leetCodeBusiness.BinarySearch(nums, target);

            return result;
        }

        [HttpPost]
        public string MinimumWindowSubstring(string s, string t)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(MinimumWindowSubstring), s, t);

            var result = _leetCodeBusiness.MinimumWindowSubstring(s, t);

            return result;
        }

        [HttpPost]
        public int[] ProductOfArrayExceptSelf(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ProductOfArrayExceptSelf), nums);

            var result = _leetCodeBusiness.ProductOfArrayExceptSelf(nums);

            return result;
        }

        [HttpPost]
        public ListNode RemoveNthNodeFromEndOfList(ListNode head, int n)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(RemoveNthNodeFromEndOfList), head, n);

            var result = _leetCodeBusiness.RemoveNthNodeFromEndOfList(head, n);

            return result;
        }

        [HttpPost]
        public TreeNode InvertBinaryTree(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg}", nameof(InvertBinaryTree), root);

            var result = _leetCodeBusiness.InvertBinaryTree(root);

            return result;
        }

        [HttpPost]
        public bool BalancedBinaryTree(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg}", nameof(BalancedBinaryTree), root);

            var result = _leetCodeBusiness.BalancedBinaryTree(root);

            return result;
        }

        [HttpPost]
        public bool ValidateBinarySearchTree(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ValidateBinarySearchTree), root);

            var result = _leetCodeBusiness.ValidateBinarySearchTree(root);

            return result;
        }

        [HttpPost]
        public int FirstBadVersion(int n)
        {
            _logger.LogInformation("{method} - {arg}", nameof(FirstBadVersion), n);

            var result = _leetCodeBusiness.FirstBadVersion(n);

            return result;
        }

        [HttpPost]
        public int SearchInRotatedSortedArray(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SearchInRotatedSortedArray), nums, target);

            var result = _leetCodeBusiness.SearchInRotatedSortedArray(nums, target);

            return result;
        }

        [HttpPost]
        public TreeNode LowestCommonAncestorOfABinarySearchTree(TreeNode root, TreeNode p, TreeNode q)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}, {arg3}", nameof(LowestCommonAncestorOfABinarySearchTree), root, p, q);

            var result = _leetCodeBusiness.LowestCommonAncestorOfABinarySearchTree(root, p, q);

            return result;
        }

        [HttpPost]
        public int[][] MergeIntervals(int[][] intervals)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(MergeIntervals), intervals);

            var result = _leetCodeBusiness.MergeIntervals(intervals);

            return result;
        }

        [HttpPost]
        public bool RansomNote(string ransomNote, string magazine)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}}", nameof(RansomNote), ransomNote, magazine);

            var result = _leetCodeBusiness.RansomNote(ransomNote, magazine);

            return result;
        }

        [HttpPost]
        public int LongestPalindrome(string s)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(LongestPalindrome), s);

            var result = _leetCodeBusiness.LongestPalindrome(s);

            return result;
        }

        [HttpPost]
        public ListNode ReverseLinkedList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(ReverseLinkedList), head);

            var result = _leetCodeBusiness.ReverseLinkedList(head);

            return result;
        }

        [HttpPost]
        public TreeNode LowestCommonAncestorOfABinaryTree(TreeNode root, TreeNode p, TreeNode q)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}, {arg3}}", nameof(LowestCommonAncestorOfABinaryTree), root, p, q);

            var result = _leetCodeBusiness.LowestCommonAncestorOfABinaryTree(root, p, q);

            return result;
        }

        [HttpPost]
        public void SortColors(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(SortColors), nums);

            _leetCodeBusiness.SortColors(nums);
        }

        [HttpPost]
        public void StringToIntegerAtoi(string s)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(StringToIntegerAtoi), s);

            _leetCodeBusiness.StringToIntegerAtoi(s);
        }

        [HttpPost]
        public void MajorityElement(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(MajorityElement), nums);

            _leetCodeBusiness.MajorityElement(nums);
        }
    }
}
