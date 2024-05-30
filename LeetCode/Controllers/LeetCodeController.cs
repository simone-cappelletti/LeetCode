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
        public int StringToIntegerAtoi(string s)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(StringToIntegerAtoi), s);

            var result = _leetCodeBusiness.StringToIntegerAtoi(s);

            return result;
        }

        [HttpPost]
        public int MajorityElement(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(MajorityElement), nums);

            var result = _leetCodeBusiness.MajorityElement(nums);

            return result;
        }

        [HttpPost]
        public string LongestPalindromicSubstring(string s)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(LongestPalindromicSubstring), s);

            var result = _leetCodeBusiness.LongestPalindromicSubstring(s);

            return result;
        }

        [HttpPost]
        public int ContainerWithMostWater(int[] height)
        {
            _logger.LogInformation("{method} - {arg}}", nameof(ContainerWithMostWater), height);

            var result = _leetCodeBusiness.ContainerWithMostWater(height);

            return result;
        }

        [HttpPost]
        public int SearchInsertPosition(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}}", nameof(SearchInsertPosition), nums, target);

            var result = _leetCodeBusiness.SearchInsertPosition(nums, target);

            return result;
        }

        [HttpPost]
        public IList<int> FindAllAnagramsInAString(string s, string p)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}}", nameof(FindAllAnagramsInAString), s, p);

            var result = _leetCodeBusiness.FindAllAnagramsInAString(s, p);

            return result;
        }

        [HttpPost]
        public IList<IList<int>> Permutations(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}}}", nameof(Permutations), nums);

            var result = _leetCodeBusiness.Permutations(nums);

            return result;
        }

        [HttpPost]
        public string AddBinary(string a, string b)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}}}", nameof(AddBinary), a, b);

            var result = _leetCodeBusiness.AddBinary(a, b);

            return result;
        }

        [HttpPost]
        public ListNode MiddleOfTheLinkedList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg}}}", nameof(MiddleOfTheLinkedList), head);

            var result = _leetCodeBusiness.MiddleOfTheLinkedList(head);

            return result;
        }

        [HttpPost]
        public int FindCenterOfStarGraph(int[][] edges)
        {
            _logger.LogInformation("{method} - {arg}}}", nameof(FindCenterOfStarGraph), edges);

            var result = _leetCodeBusiness.FindCenterOfStarGraph(edges);

            return result;
        }

        [HttpPost]
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}, {arg3}, {arg4}", nameof(FloodFill), image, sr, sc, color);

            var result = _leetCodeBusiness.FloodFill(image, sr, sc, color);

            return result;
        }

        [HttpPost]
        public int[][] Matrix01(int[][] mat)
        {
            _logger.LogInformation("{method} - {arg}", nameof(Matrix01), mat);

            var result = _leetCodeBusiness.Matrix01(mat);

            return result;
        }

        [HttpPost]
        public IList<IList<int>> BinaryTreeLevelOrderTraversal(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg}", nameof(BinaryTreeLevelOrderTraversal), root);

            var result = _leetCodeBusiness.BinaryTreeLevelOrderTraversal(root);

            return result;
        }

        [HttpPost]
        public Node CloneGraph(Node node)
        {
            _logger.LogInformation("{method} - {arg}", nameof(CloneGraph), node);

            var result = _leetCodeBusiness.CloneGraph(node);

            return result;
        }

        [HttpPost]
        public int NumberOfIslands(char[][] grid)
        {
            _logger.LogInformation("{method} - {arg}", nameof(NumberOfIslands), grid);

            var result = _leetCodeBusiness.NumberOfIslands(grid);

            return result;
        }

        [HttpPost]
        public bool MeetingRooms(int[][] intervals)
        {
            _logger.LogInformation("{method} - {arg}", nameof(MeetingRooms), intervals);

            var result = _leetCodeBusiness.MeetingRooms(intervals);

            return result;
        }

        [HttpPost]
        public bool BackspaceStringCompare(string s, string t)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(BackspaceStringCompare), s, t);

            var result = _leetCodeBusiness.BackspaceStringCompare(s, t);

            return result;
        }

        [HttpPost]
        public int RottingOranges(int[][] grid)
        {
            _logger.LogInformation("{method} - {arg}", nameof(RottingOranges), grid);

            var result = _leetCodeBusiness.RottingOranges(grid);

            return result;
        }

        [HttpPost]
        public int[] CountingBits(int n)
        {
            _logger.LogInformation("{method} - {arg}", nameof(CountingBits), n);

            var result = _leetCodeBusiness.CountingBits(n);

            return result;
        }

        [HttpPost]
        public bool SameTree(TreeNode p, TreeNode q)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SameTree), p, q);

            var result = _leetCodeBusiness.SameTree(p, q);

            return result;
        }

        [HttpPost]
        public int HammingWeight(uint n)
        {
            _logger.LogInformation("{method} - {arg}", nameof(SameTree), n);

            var result = _leetCodeBusiness.HammingWeight(n);

            return result;
        }

        [HttpPost]
        public int ThreeSumSmaller(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SameTree), nums, target);

            var result = _leetCodeBusiness.ThreeSumSmaller(nums, target);

            return result;
        }

        [HttpPost]
        public int ThreeSumClosest(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SameTree), nums, target);

            var result = _leetCodeBusiness.ThreeSumClosest(nums, target);

            return result;
        }

        [HttpPost]
        public IList<string> LetterCombinationsOfAPhoneNumber(string digits)
        {
            _logger.LogInformation("{method} - {arg}", nameof(LetterCombinationsOfAPhoneNumber), digits);

            var result = _leetCodeBusiness.LetterCombinationsOfAPhoneNumber(digits);

            return result;
        }

        [HttpPost]
        public string LongestCommonPrefix(string[] strs)
        {
            _logger.LogInformation("{method} - {arg}", nameof(LongestCommonPrefix), strs);

            var result = _leetCodeBusiness.LongestCommonPrefix(strs);

            return result;
        }

        [HttpPost]
        public IList<int> BinaryTreeRightSideView(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg}", nameof(BinaryTreeRightSideView), root);

            var result = _leetCodeBusiness.BinaryTreeRightSideView(root);

            return result;
        }

        [HttpPost]
        public int[][] KClosestPointsToOrigin(int[][] points, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(KClosestPointsToOrigin), points, k);

            var result = _leetCodeBusiness.KClosestPointsToOrigin(points, k);

            return result;
        }

        [HttpPost]
        public IList<IList<int>> Subsets(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(Subsets), nums);

            var result = _leetCodeBusiness.Subsets(nums);

            return result;
        }

        [HttpPost]
        public bool PalindromeLinkedList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg}", nameof(PalindromeLinkedList), head);

            var result = _leetCodeBusiness.PalindromeLinkedList(head);

            return result;
        }

        [HttpPost]
        public bool WordSearch(char[][] board, string word)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(WordSearch), board, word);

            var result = _leetCodeBusiness.WordSearch(board, word);

            return result;
        }

        [HttpPost]
        public TreeNode ConstructBinaryTreeFromPreorderAndInorderTraversal(int[] preorder, int[] inorder)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(ConstructBinaryTreeFromPreorderAndInorderTraversal), preorder, inorder);

            var result = _leetCodeBusiness.ConstructBinaryTreeFromPreorderAndInorderTraversal(preorder, inorder);

            return result;
        }

        [HttpPost]
        public bool WordBreak(string s, IList<string> wordDict)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(WordBreak), s, wordDict);

            var result = _leetCodeBusiness.WordBreak(s, wordDict);

            return result;
        }

        [HttpPost]
        public int MinimumLengthOfStringAfterDeletingSimilarEnds(string s)
        {
            _logger.LogInformation("{method} - {arg}", nameof(MinimumLengthOfStringAfterDeletingSimilarEnds), s);

            var result = _leetCodeBusiness.MinimumLengthOfStringAfterDeletingSimilarEnds(s);

            return result;
        }

        [HttpPost]
        public int BagOfTokensScore(int[] tokens, int power)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(BagOfTokensScore), tokens, power);

            var result = _leetCodeBusiness.BagOfTokensScore(tokens, power);

            return result;
        }

        [HttpPost]
        public int CountElementsWithMaximumFrequency(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(CountElementsWithMaximumFrequency), nums);

            var result = _leetCodeBusiness.CountElementsWithMaximumFrequency(nums);

            return result;
        }

        [HttpPost]
        public string CustomSortString(string order, string s)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(CustomSortString), order, s);

            var result = _leetCodeBusiness.CustomSortString(order, s);

            return result;
        }

        [HttpPost]
        public ListNode RemoveZeroSumConsecutiveNodesFromLinkedList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg}", nameof(RemoveZeroSumConsecutiveNodesFromLinkedList), head);

            var result = _leetCodeBusiness.RemoveZeroSumConsecutiveNodesFromLinkedList(head);

            return result;
        }

        [HttpPost]
        public int FindThePivotInteger(int n)
        {
            _logger.LogInformation("{method} - {arg}", nameof(FindThePivotInteger), n);

            var result = _leetCodeBusiness.FindThePivotInteger(n);

            return result;
        }

        [HttpPost]
        public int ContiguousArray(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ContiguousArray), nums);

            var result = _leetCodeBusiness.ContiguousArray(nums);

            return result;
        }

        [HttpPost]
        public int SingleNumber(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(SingleNumber), nums);

            var result = _leetCodeBusiness.SingleNumber(nums);

            return result;
        }

        [HttpPost]
        public int KthSmallestElementInABST(TreeNode root, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(KthSmallestElementInABST), root, k);

            var result = _leetCodeBusiness.KthSmallestElementInABST(root, k);

            return result;
        }

        [HttpPost]
        public ListNode MergeInBetweenLinkedLists(ListNode list1, int a, int b, ListNode list2)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}, {arg3}, {arg4}", nameof(MergeInBetweenLinkedLists), list1, a, b, list2);

            var result = _leetCodeBusiness.MergeInBetweenLinkedLists(list1, a, b, list2);

            return result;
        }

        [HttpPost]
        public void ReorderList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg}", nameof(ReorderList), head);

            _leetCodeBusiness.ReorderList(head);
        }

        [HttpPost]
        public IList<int> FindAllDuplicatesInAnArray(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(FindAllDuplicatesInAnArray), nums);

            var result = _leetCodeBusiness.FindAllDuplicatesInAnArray(nums);

            return result;
        }

        [HttpPost]
        public int FirstMissingPositive(int[] nums)
        {
            _logger.LogInformation("{method} - {arg}", nameof(FirstMissingPositive), nums);

            var result = _leetCodeBusiness.FirstMissingPositive(nums);

            return result;
        }

        [HttpPost]
        public int SubarrayProductLessThanK(int[] nums, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SubarrayProductLessThanK), nums, k);

            var result = _leetCodeBusiness.SubarrayProductLessThanK(nums, k);

            return result;
        }

        [HttpPost]
        public int LengthOfLongestSubarrayWithAtMostKFrequency(int[] nums, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(LengthOfLongestSubarrayWithAtMostKFrequency), nums, k);

            var result = _leetCodeBusiness.LengthOfLongestSubarrayWithAtMostKFrequency(nums, k);

            return result;
        }

        [HttpPost]
        public string RemoveVowelsFromAString(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(RemoveVowelsFromAString), s);

            var result = _leetCodeBusiness.RemoveVowelsFromAString(s);

            return result;
        }

        [HttpPost]
        public long CountSubarraysWhereMaxElementAppearsAtLeastKTimes(int[] nums, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(RemoveVowelsFromAString), nums, k);

            var result = _leetCodeBusiness.CountSubarraysWhereMaxElementAppearsAtLeastKTimes(nums, k);

            return result;
        }

        [HttpPost]
        public int SubarraysWithKDifferentIntegers(int[] nums, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SubarraysWithKDifferentIntegers), nums, k);

            var result = _leetCodeBusiness.SubarraysWithKDifferentIntegers(nums, k);

            return result;
        }

        [HttpPost]
        public int[] DailyTemperatures(int[] temperatures)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(DailyTemperatures), temperatures);

            var result = _leetCodeBusiness.DailyTemperatures(temperatures);

            return result;
        }

        [HttpPost]
        public int LengthOfLastWord(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(LengthOfLastWord), s);

            var result = _leetCodeBusiness.LengthOfLastWord(s);

            return result;
        }

        [HttpPost]
        public void MoveZeroes(int[] nums)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(MoveZeroes), nums);

            _leetCodeBusiness.MoveZeroes(nums);
        }

        [HttpPost]
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(GroupAnagrams), strs);

            var result = _leetCodeBusiness.GroupAnagrams(strs);

            return result;
        }

        [HttpPost]
        public int FindTheDuplicateNumber(int[] nums)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(FindTheDuplicateNumber), nums);

            var result = _leetCodeBusiness.FindTheDuplicateNumber(nums);

            return result;
        }

        [HttpPost]
        public string MakeTheStringGreat(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(MakeTheStringGreat), s);

            var result = _leetCodeBusiness.MakeTheStringGreat(s);

            return result;
        }

        [HttpPost]
        public string MinimumRemoveToMakeValidParentheses(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(MinimumRemoveToMakeValidParentheses), s);

            var result = _leetCodeBusiness.MinimumRemoveToMakeValidParentheses(s);

            return result;
        }

        [HttpPost]
        public bool ValidParenthesisString(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(ValidParenthesisString), s);

            var result = _leetCodeBusiness.ValidParenthesisString(s);

            return result;
        }

        [HttpPost]
        public int NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(NumberOfStudentsUnableToEatLunch), students, sandwiches);

            var result = _leetCodeBusiness.NumberOfStudentsUnableToEatLunch(students, sandwiches);

            return result;
        }

        [HttpPost]
        public ListNode SwapNodesInPairs(ListNode head)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(SwapNodesInPairs), head);

            var result = _leetCodeBusiness.SwapNodesInPairs(head);

            return result;
        }

        [HttpPost]
        public int[] RevealCardsInIncreasingOrder(int[] deck)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(RevealCardsInIncreasingOrder), deck);

            var result = _leetCodeBusiness.RevealCardsInIncreasingOrder(deck);

            return result;
        }

        [HttpPost]
        public string RemoveKDigits(string num, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(RemoveKDigits), num, k);

            var result = _leetCodeBusiness.RemoveKDigits(num, k);

            return result;
        }

        [HttpPost]
        public int TimeNeededToBuyTickets(int[] tickets, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(TimeNeededToBuyTickets), tickets, k);

            var result = _leetCodeBusiness.TimeNeededToBuyTickets(tickets, k);

            return result;
        }

        [HttpPost]
        public int SumOfLeftLeaves(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(SumOfLeftLeaves), root);

            var result = _leetCodeBusiness.SumOfLeftLeaves(root);

            return result;
        }

        [HttpPost]
        public int SumRootToLeafNumbers(TreeNode root)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(SumRootToLeafNumbers), root);

            var result = _leetCodeBusiness.SumRootToLeafNumbers(root);

            return result;
        }

        [HttpPost]
        public bool ValidSudoku(char[][] board)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(ValidSudoku), board);

            var result = _leetCodeBusiness.ValidSudoku(board);

            return result;
        }

        [HttpPost]
        public int LongestConsecutiveSequence(int[] nums)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(LongestConsecutiveSequence), nums);

            var result = _leetCodeBusiness.LongestConsecutiveSequence(nums);

            return result;
        }

        [HttpPost]
        public int[][] FindAllGroupsOfFarmland(int[][] land)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(FindAllGroupsOfFarmland), land);

            var result = _leetCodeBusiness.FindAllGroupsOfFarmland(land);

            return result;
        }

        [HttpPost]
        public int TrappingRainWater(int[] height)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(TrappingRainWater), height);

            var result = _leetCodeBusiness.TrappingRainWater(height);

            return result;
        }

        [HttpPost]
        public int RomanToInteger(string s)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(RomanToInteger), s);

            var result = _leetCodeBusiness.RomanToInteger(s);

            return result;
        }

        [HttpPost]
        public string IntegerToRoman(int num)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(IntegerToRoman), num);

            var result = _leetCodeBusiness.IntegerToRoman(num);

            return result;
        }

        [HttpPost]
        public bool SearchA2DMatrix(int[][] matrix, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SearchA2DMatrix), matrix, target);

            var result = _leetCodeBusiness.SearchA2DMatrix(matrix, target);

            return result;
        }

        [HttpPost]
        public int LargestPositiveIntegerThatExistsWithItsNegative(int[] nums)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(LargestPositiveIntegerThatExistsWithItsNegative), nums);

            var result = _leetCodeBusiness.LargestPositiveIntegerThatExistsWithItsNegative(nums);

            return result;
        }

        [HttpPost]
        public long CountPairsInTwoArrays(int[] nums1, int[] nums2)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(CountPairsInTwoArrays), nums1, nums2);

            var result = _leetCodeBusiness.CountPairsInTwoArrays(nums1, nums2);

            return result;
        }

        [HttpPost]
        public long BoatsToSavePeople(int[] people, int limit)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(BoatsToSavePeople), people, limit);

            var result = _leetCodeBusiness.BoatsToSavePeople(people, limit);

            return result;
        }

        [HttpPost]
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(FourSum), nums, target);

            var result = _leetCodeBusiness.FourSum(nums, target);

            return result;
        }

        [HttpPost]
        public void RotateArray(int[] nums, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(RotateArray), nums, k);

            _leetCodeBusiness.RotateArray(nums, k);
        }

        [HttpPost]
        public void MaximizeHappinessOfSelectedChildren(int[] happiness, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(MaximizeHappinessOfSelectedChildren), happiness, k);

            _leetCodeBusiness.MaximizeHappinessOfSelectedChildren(happiness, k);
        }

        [HttpPost]
        public IList<string> GenerateParenthesis(int n)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(GenerateParenthesis), n);

            var result = _leetCodeBusiness.GenerateParenthesis(n);

            return result;
        }

        [HttpPost]
        public int SingleElementInASortedArray(int[] nums)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(SingleElementInASortedArray), nums);

            var result = _leetCodeBusiness.SingleElementInASortedArray(nums);

            return result;
        }

        [HttpPost]
        public int CarFleet(int target, int[] position, int[] speed)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}, {arg3}", nameof(CarFleet), target, position, speed);

            var result = _leetCodeBusiness.CarFleet(target, position, speed);

            return result;
        }

        [HttpPost]
        public int[] NextGreaterElementI(int[] nums1, int[] nums2)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(NextGreaterElementI), nums1, nums2);

            var result = _leetCodeBusiness.NextGreaterElementI(nums1, nums2);

            return result;
        }

        [HttpPost]
        public ListNode RemoveLinkedListElements(ListNode head, int val)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(RemoveLinkedListElements), head, val);

            var result = _leetCodeBusiness.RemoveLinkedListElements(head, val);

            return result;
        }

        [HttpPost]
        public int MaximumTwinSumOfALinkedList(ListNode head)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(MaximumTwinSumOfALinkedList), head);

            var result = _leetCodeBusiness.MaximumTwinSumOfALinkedList(head);

            return result;
        }

        [HttpPost]
        public ListNode SwappingNodesInALinkedList(ListNode head, int k)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(SwappingNodesInALinkedList), head, k);

            var result = _leetCodeBusiness.SwappingNodesInALinkedList(head, k);

            return result;
        }

        [HttpPost]
        public ListNodeWithRandom CopyListWithRandomPointer(ListNodeWithRandom head)
        {
            _logger.LogInformation("{method} - {arg1}", nameof(CopyListWithRandomPointer), head);

            var result = _leetCodeBusiness.CopyListWithRandomPointer(head);

            return result;
        }

        [HttpPost]
        public TreeNode InsertIntoABinarySearchTree(TreeNode root, int val)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(InsertIntoABinarySearchTree), root, val);

            var result = _leetCodeBusiness.InsertIntoABinarySearchTree(root, val);

            return result;
        }

        [HttpPost]
        public TreeNode DeleteNodeInABST(TreeNode root, int val)
        {
            _logger.LogInformation("{method} - {arg1}, {arg2}", nameof(DeleteNodeInABST), root, val);

            var result = _leetCodeBusiness.DeleteNodeInABST(root, val);

            return result;
        }
    }
}
