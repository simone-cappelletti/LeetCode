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
    }
}
