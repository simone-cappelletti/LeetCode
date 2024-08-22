using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace LeetCode
{
    public interface ILeetCodeBusiness
    {
        /// <summary>
        /// https://leetcode.com/problems/min-stack/
        /// </summary>
        MinStack MinStack { get; }

        /// <summary>
        /// https://leetcode.com/problems/implement-queue-using-stacks/description/
        /// </summary>
        ImplementQueueUsingStacks ImplementQueueUsingStacks { get; }

        /// <summary>
        /// https://leetcode.com/problems/time-based-key-value-store/
        /// </summary>
        TimeBasedKeyValueStore TimeBasedKeyValueStore { get; }

        /// <summary>
        /// https://leetcode.com/problems/implement-trie-prefix-tree/description/
        /// </summary>
        ImplementTriePrefixTree ImplementTriePrefixTree { get; }

        /// <summary>
        /// https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
        /// </summary>
        SerializeAndDeserializeBinaryTree SerializeAndDeserializeBinaryTree { get; }

        /// <summary>
        /// https://leetcode.com/problems/lru-cache/description/
        /// </summary>
        LRUCache LRUCache { get; }

        /// <summary>
        /// https://leetcode.com/problems/encode-and-decode-strings/
        /// </summary>
        EncodeAndDecodeStrings EncodeAndDecodeStrings { get; }

        /// <summary>
        /// https://leetcode.com/problems/online-stock-span/
        /// </summary>
        StockSpanner StockSpanner { get; }

        /// <summary>
        /// https://leetcode.com/problems/kth-largest-element-in-a-stream/
        /// </summary>
        KthLargestElementInAStream KthLargestElementInAStream { get; }

        /// <summary>
        /// https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int[] TwoSum(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int[] TwoSumII(int[] numbers, int target);

        /// <summary>
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        bool PalindromeNumber(int x);

        /// <summary>
        /// https://leetcode.com/problems/remove-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        int RemoveElement(int[] nums, int val);

        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int RemoveDuplicatesFromSortedArray(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int LengthOfLongestSubstringTwoDistinct(string s);

        /// <summary>
        /// https://leetcode.com/problems/valid-parentheses/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool ValidParentheses(string s);

        /// <summary>
        /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        int BestTimeToBuyAndSellStock(int[] prices);

        /// <summary>
        /// https://leetcode.com/problems/merge-two-sorted-lists/
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        ListNode MergeTwoSortedListsRecursive(ListNode list1, ListNode list2);

        /// <summary>
        /// https://leetcode.com/problems/merge-two-sorted-lists/
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        ListNode MergeTwoSortedListsIterative(ListNode list1, ListNode list2);

        /// <summary>
        /// https://leetcode.com/problems/valid-palindrome/description/
        /// </summary>
        /// <param name="s"></param>
        bool ValidPalindromeString(string s);

        /// <summary>
        /// https://leetcode.com/problems/insert-interval/
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        int[][] InsertInterval(int[][] intervals, int[] newInterval);

        /// <summary>
        /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int LongestSubstringWithoutRepeatingCharacters(string s);

        /// <summary>
        /// https://leetcode.com/problems/evaluate-reverse-polish-notation/
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        int EvaluateReversePolishNotation(string[] tokens);

        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        IList<IList<int>> ThreeSum(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/binary-search/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        int BinarySearch(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/minimum-window-substring/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        string MinimumWindowSubstring(string s, string t);

        /// <summary>
        /// https://leetcode.com/problems/product-of-array-except-self/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int[] ProductOfArrayExceptSelf(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        ListNode RemoveNthNodeFromEndOfList(ListNode head, int n);

        /// <summary>
        /// https://leetcode.com/problems/invert-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        TreeNode InvertBinaryTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/balanced-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool BalancedBinaryTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/validate-binary-search-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool ValidateBinarySearchTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/first-bad-version/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int FirstBadVersion(int n);

        /// <summary>
        /// https://leetcode.com/problems/search-in-rotated-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int SearchInRotatedSortedArray(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        TreeNode LowestCommonAncestorOfABinarySearchTree(TreeNode root, TreeNode p, TreeNode q);

        /// <summary>
        /// https://leetcode.com/problems/merge-intervals/
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        int[][] MergeIntervals(int[][] intervals);

        /// <summary>
        /// https://leetcode.com/problems/ransom-note/
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        bool RansomNote(string ransomNote, string magazine);

        /// <summary>
        /// https://leetcode.com/problems/longest-palindrome/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int LongestPalindrome(string s);

        /// <summary>
        /// https://leetcode.com/problems/reverse-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        ListNode ReverseLinkedList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        TreeNode LowestCommonAncestorOfABinaryTree(TreeNode root, TreeNode p, TreeNode q);

        /// <summary>
        /// https://leetcode.com/problems/sort-colors/
        /// </summary>
        /// <param name="nums"></param>
        void SortColors(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/string-to-integer-atoi/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int StringToIntegerAtoi(string s);

        /// <summary>
        /// https://leetcode.com/problems/majority-element/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int MajorityElement(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/longest-palindromic-substring/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        string LongestPalindromicSubstring(string s);

        /// <summary>
        /// https://leetcode.com/problems/container-with-most-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        int ContainerWithMostWater(int[] height);

        /// <summary>
        /// https://leetcode.com/problems/search-insert-position/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int SearchInsertPosition(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/find-all-anagrams-in-a-string/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        IList<int> FindAllAnagramsInAString(string s, string p);

        /// <summary>
        /// https://leetcode.com/problems/permutations/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        IList<IList<int>> Permutations(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/add-binary/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        string AddBinary(string a, string b);

        /// <summary>
        /// https://leetcode.com/problems/middle-of-the-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        ListNode MiddleOfTheLinkedList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/find-center-of-star-graph/
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        int FindCenterOfStarGraph(int[][] edges);

        /// <summary>
        /// https://leetcode.com/problems/find-center-of-star-graph/
        /// </summary>
        /// <param name="image"></param>
        /// <param name="sr"></param>
        /// <param name="sc"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        int[][] FloodFill(int[][] image, int sr, int sc, int color);

        /// <summary>
        /// https://leetcode.com/problems/01-matrix/
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        int[][] Matrix01(int[][] mat);

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<IList<int>> BinaryTreeLevelOrderTraversal(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/clone-graph/
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        Node CloneGraph(Node node);

        /// <summary>
        /// https://leetcode.com/problems/number-of-islands/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        int NumberOfIslands(char[][] grid);

        /// <summary>
        /// https://leetcode.com/problems/meeting-rooms/
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        bool MeetingRooms(int[][] intervals);

        /// <summary>
        /// https://leetcode.com/problems/backspace-string-compare/description/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        bool BackspaceStringCompare(string s, string t);

        /// <summary>
        /// https://leetcode.com/problems/rotting-oranges/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        int RottingOranges(int[][] grid);

        /// <summary>
        /// https://leetcode.com/problems/counting-bits/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int[] CountingBits(int n);

        /// <summary>
        /// https://leetcode.com/problems/same-tree/
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        bool SameTree(TreeNode p, TreeNode q);

        /// <summary>
        /// https://leetcode.com/problems/number-of-1-bits/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int HammingWeight(uint n);

        /// <summary>
        /// https://leetcode.com/problems/3sum-smaller/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int ThreeSumSmaller(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/3sum-closest/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        int ThreeSumClosest(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        IList<string> LetterCombinationsOfAPhoneNumber(string digits);

        /// <summary>
        /// https://leetcode.com/problems/longest-common-prefix/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        string LongestCommonPrefix(string[] strs);

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-right-side-view/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<int> BinaryTreeRightSideView(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/k-closest-points-to-origin/
        /// </summary>
        /// <param name="points"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int[][] KClosestPointsToOrigin(int[][] points, int k);

        /// <summary>
        /// https://leetcode.com/problems/subsets/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        IList<IList<int>> Subsets(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/palindrome-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        bool PalindromeLinkedList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/word-search/
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        bool WordSearch(char[][] board, string word);

        /// <summary>
        /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
        /// </summary>
        /// <param name="preorder"></param>
        /// <param name="inorder"></param>
        /// <returns></returns>
        TreeNode ConstructBinaryTreeFromPreorderAndInorderTraversal(int[] preorder, int[] inorder);

        /// <summary>
        /// https://leetcode.com/problems/word-break/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="wordDict"></param>
        /// <returns></returns>
        public bool WordBreak(string s, IList<string> wordDict);

        /// <summary>
        /// https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends/?envType=daily-question&envId=2024-03-05
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int MinimumLengthOfStringAfterDeletingSimilarEnds(string s);

        /// <summary>
        /// https://leetcode.com/problems/bag-of-tokens/?envType=daily-question&envId=2024-03-04
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        int BagOfTokensScore(int[] tokens, int power);

        /// <summary>
        /// https://leetcode.com/problems/count-elements-with-maximum-frequency/?envType=daily-question&envId=2024-03-08
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int CountElementsWithMaximumFrequency(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/custom-sort-string/?envType=daily-question&envId=2024-03-11
        /// </summary>
        /// <param name="order"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        string CustomSortString(string order, string s);

        /// <summary>
        /// https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/?envType=daily-question&envId=2024-03-12
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        ListNode RemoveZeroSumConsecutiveNodesFromLinkedList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/find-the-pivot-integer/?envType=daily-question&envId=2024-03-13
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int FindThePivotInteger(int n);

        /// <summary>
        /// https://leetcode.com/problems/contiguous-array/?envType=daily-question&envId=2024-03-16
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int ContiguousArray(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/single-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int SingleNumber(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int KthSmallestElementInABST(TreeNode root, int k);

        /// <summary>
        /// https://leetcode.com/problems/merge-in-between-linked-lists/?envType=daily-question&envId=2024-03-20
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        ListNode MergeInBetweenLinkedLists(ListNode list1, int a, int b, ListNode list2);

        /// <summary>
        /// https://leetcode.com/problems/reorder-list/?envType=daily-question&envId=2024-03-23
        /// </summary>
        /// <param name="head"></param>
        void ReorderList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/find-all-duplicates-in-an-array/?envType=daily-question&envId=2024-03-25
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        IList<int> FindAllDuplicatesInAnArray(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/first-missing-positive/?envType=daily-question&envId=2024-03-26
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int FirstMissingPositive(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/subarray-product-less-than-k/?envType=daily-question&envId=2024-03-27
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int SubarrayProductLessThanK(int[] nums, int k);

        /// <summary>
        /// https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency/?envType=daily-question&envId=2024-03-28
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int LengthOfLongestSubarrayWithAtMostKFrequency(int[] nums, int k);

        /// <summary>
        /// https://leetcode.com/problems/remove-vowels-from-a-string/?envType=weekly-question&envId=2024-03-22
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        string RemoveVowelsFromAString(string s);

        /// <summary>
        /// https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times/?envType=daily-question&envId=2024-03-29
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public long CountSubarraysWhereMaxElementAppearsAtLeastKTimes(int[] nums, int k);

        /// <summary>
        /// https://leetcode.com/problems/subarrays-with-k-different-integers/?envType=daily-question&envId=2024-03-30
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int SubarraysWithKDifferentIntegers(int[] nums, int k);

        /// <summary>
        /// https://leetcode.com/problems/daily-temperatures/
        /// </summary>
        /// <param name="temperatures"></param>
        /// <returns></returns>
        int[] DailyTemperatures(int[] temperatures);

        /// <summary>
        /// https://leetcode.com/problems/length-of-last-word/?envType=daily-question&envId=2024-04-01
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int LengthOfLastWord(string s);

        /// <summary>
        /// https://leetcode.com/problems/move-zeroes/
        /// </summary>
        /// <param name="nums"></param>
        void MoveZeroes(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/group-anagrams/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        IList<IList<string>> GroupAnagrams(string[] strs);

        /// <summary>
        /// https://leetcode.com/problems/find-the-duplicate-number/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int FindTheDuplicateNumber(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/make-the-string-great/?envType=daily-question&envId=2024-04-05
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        string MakeTheStringGreat(string s);

        /// <summary>
        /// https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/?envType=daily-question&envId=2024-04-06
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        string MinimumRemoveToMakeValidParentheses(string s);

        /// <summary>
        /// https://leetcode.com/problems/valid-parenthesis-string/?envType=daily-question&envId=2024-04-07
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool ValidParenthesisString(string s);

        /// <summary>
        /// https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/?envType=daily-question&envId=2024-04-08
        /// </summary>
        /// <param name="students"></param>
        /// <param name="sandwiches"></param>
        /// <returns></returns>
        int NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches);

        /// <summary>
        /// https://leetcode.com/problems/swap-nodes-in-pairs/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        ListNode SwapNodesInPairs(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/reveal-cards-in-increasing-order/?envType=daily-question&envId=2024-04-10
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        int[] RevealCardsInIncreasingOrder(int[] deck);

        /// <summary>
        /// https://leetcode.com/problems/remove-k-digits/?envType=daily-question&envId=2024-04-11
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        string RemoveKDigits(string num, int k);

        /// <summary>
        /// https://leetcode.com/problems/time-needed-to-buy-tickets/?envType=daily-question&envId=2024-04-09
        /// </summary>
        /// <param name="tickets"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int TimeNeededToBuyTickets(int[] tickets, int k);

        /// <summary>
        /// https://leetcode.com/problems/sum-of-left-leaves/?envType=daily-question&envId=2024-04-14
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        int SumOfLeftLeaves(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/sum-root-to-leaf-numbers/?envType=daily-question&envId=2024-04-15
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        int SumRootToLeafNumbers(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/valid-sudoku/
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        bool ValidSudoku(char[][] board);

        /// <summary>
        /// https://leetcode.com/problems/longest-consecutive-sequence/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int LongestConsecutiveSequence(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/find-all-groups-of-farmland/?envType=daily-question&envId=2024-04-20
        /// </summary>
        /// <param name="land"></param>
        /// <returns></returns>
        int[][] FindAllGroupsOfFarmland(int[][] land);

        /// <summary>
        /// https://leetcode.com/problems/trapping-rain-water/
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        int TrappingRainWater(int[] height);

        /// <summary>
        /// https://leetcode.com/problems/roman-to-integer/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int RomanToInteger(string s);

        /// <summary>
        /// https://leetcode.com/problems/integer-to-roman/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        string IntegerToRoman(int num);

        /// <summary>
        /// https://leetcode.com/problems/search-a-2d-matrix/
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        bool SearchA2DMatrix(int[][] matrix, int target);

        /// <summary>
        /// https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/?envType=daily-question&envId=2024-05-02
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int LargestPositiveIntegerThatExistsWithItsNegative(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/count-pairs-in-two-arrays/?envType=weekly-question&envId=2024-05-01
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        long CountPairsInTwoArrays(int[] nums1, int[] nums2);

        /// <summary>
        /// https://leetcode.com/problems/boats-to-save-people/?envType=daily-question&envId=2024-05-04
        /// </summary>
        /// <param name="people"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        int BoatsToSavePeople(int[] people, int limit);

        /// <summary>
        /// https://leetcode.com/problems/4sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        IList<IList<int>> FourSum(int[] nums, int target);

        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        void RotateArray(int[] nums, int k);

        /// <summary>
        /// https://leetcode.com/problems/maximize-happiness-of-selected-children/
        /// </summary>
        /// <param name="happiness"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        long MaximizeHappinessOfSelectedChildren(int[] happiness, int k);

        /// <summary>
        /// https://leetcode.com/problems/generate-parentheses/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        IList<string> GenerateParenthesis(int n);

        /// <summary>
        /// https://leetcode.com/problems/single-element-in-a-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int SingleElementInASortedArray(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/car-fleet/
        /// </summary>
        /// <param name="target"></param>
        /// <param name="position"></param>
        /// <param name="speed"></param>
        /// <returns></returns>
        int CarFleet(int target, int[] position, int[] speed);

        /// <summary>
        /// https://leetcode.com/problems/next-greater-element-i/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        int[] NextGreaterElementI(int[] nums1, int[] nums2);

        /// <summary>
        /// https://leetcode.com/problems/remove-linked-list-elements/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        ListNode RemoveLinkedListElements(ListNode head, int val);

        /// <summary>
        /// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        int MaximumTwinSumOfALinkedList(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        ListNode SwappingNodesInALinkedList(ListNode head, int k);

        /// <summary>
        /// https://leetcode.com/problems/copy-list-with-random-pointer/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        ListNodeWithRandom CopyListWithRandomPointer(ListNodeWithRandom head);

        /// <summary>
        /// https://leetcode.com/problems/insert-into-a-binary-search-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        TreeNode InsertIntoABinarySearchTree(TreeNode root, int val);

        /// <summary>
        /// https://leetcode.com/problems/delete-node-in-a-bst/
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        TreeNode DeleteNodeInABST(TreeNode root, int key);

        /// <summary>
        /// https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <param name="hasApple"></param>
        /// <returns></returns>
        int MinimumTimeToCollectAllApplesInATree(int n, int[][] edges, IList<bool> hasApple);

        /// <summary>
        /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<IList<int>> BinaryTreeZigzagLevelOrderTraversal(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/find-duplicate-subtrees/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        IList<TreeNode> FindDuplicateSubtrees(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/check-completeness-of-a-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool CheckCompletenessOfABinaryTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/submissions/1286382108/
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="postorder"></param>
        /// <returns></returns>
        TreeNode ConstructBinaryTreeFromInorderAndPostorderTraversal(int[] inorder, int[] postorder);

        /// <summary>
        /// https://leetcode.com/problems/symmetric-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        bool SymmetricTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        int CountGoodNodesInBinaryTree(TreeNode root);

        /// <summary>
        /// https://leetcode.com/problems/last-stone-weight/
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        int LastStoneWeight(int[] stones);

        /// <summary>
        /// https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int LeastNumberOfUniqueIntegersAfterKRemovals(int[] arr, int k);

        /// <summary>
        /// https://leetcode.com/problems/furthest-building-you-can-reach/
        /// </summary>
        /// <param name="heights"></param>
        /// <param name="bricks"></param>
        /// <param name="ladders"></param>
        /// <returns></returns>
        int FurthestBuildingYouCanReach(int[] heights, int bricks, int ladders);

        /// <summary>
        /// https://leetcode.com/problems/intersection-of-two-arrays-ii/?envType=daily-question&envId=2024-07-02
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        int[] IntersectionOfTwoArraysII(int[] nums1, int[] nums2);

        /// <summary>
        /// https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves/?source=submission-noac
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/find-the-minimum-and-maximum-number-of-nodes-between-critical-points/?envType=daily-question&envId=2024-07-05
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        int[] FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints(ListNode head);

        /// <summary>
        /// https://leetcode.com/problems/pass-the-pillow/?envType=daily-question&envId=2024-07-06
        /// </summary>
        /// <param name="n"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        int PassThePillow(int n, int time);

        /// <summary>
        /// https://leetcode.com/problems/water-bottles/?envType=daily-question&envId=2024-07-07
        /// </summary>
        /// <param name="numBottles"></param>
        /// <param name="numExchange"></param>
        /// <returns></returns>
        int WaterBottles(int numBottles, int numExchange);

        /// <summary>
        /// https://leetcode.com/problems/find-the-winner-of-the-circular-game/?envType=daily-question&envId=2024-07-08
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        int FindTheWinnerOfTheCircularGame(int n, int k);

        /// <summary>
        /// https://leetcode.com/problems/average-waiting-time/?envType=daily-question&envId=2024-07-09
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        double AverageWaitingTime(int[][] customers);

        /// <summary>
        /// https://leetcode.com/problems/crawler-log-folder/?envType=daily-question&envId=2024-07-10
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        int CrawlerLogFolder(string[] logs);

        /// <summary>
        /// https://leetcode.com/problems/reverse-substrings-between-each-pair-of-parentheses/?envType=daily-question&envId=2024-07-11
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        string ReverseSubstringsBetweenEachPairOfParentheses(string s);

        /// <summary>
        /// https://leetcode.com/problems/robot-collisions/?envType=daily-question&envId=2024-07-13
        /// </summary>
        /// <param name="positions"></param>
        /// <param name="healths"></param>
        /// <param name="directions"></param>
        /// <returns></returns>
        IList<int> RobotCollisions(int[] positions, int[] healths, string directions);

        /// <summary>
        /// https://leetcode.com/problems/create-binary-tree-from-descriptions/?envType=daily-question&envId=2024-07-15
        /// </summary>
        /// <param name="descriptions"></param>
        /// <returns></returns>
        TreeNode CreateBinaryTreeFromDescriptions(int[][] descriptions);

        /// <summary>
        /// https://leetcode.com/problems/step-by-step-directions-from-a-binary-tree-node-to-another/?envType=daily-question&envId=2024-07-16
        /// </summary>
        /// <param name="root"></param>
        /// <param name="startValue"></param>
        /// <param name="destValue"></param>
        /// <returns></returns>
        string StepByStepDirectionsFromABinaryTreeNodeToAnother(TreeNode root, int startValue, int destValue);

        /// <summary>
        /// https://leetcode.com/problems/sort-the-jumbled-numbers/
        /// </summary>
        /// <param name="mapping"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        int[] SortTheJumbledNumbers(int[] mapping, int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/island-perimeter/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        int IslandPerimeter(int[][] grid);

        /// <summary>
        /// https://leetcode.com/problems/verifying-an-alien-dictionary/
        /// </summary>
        /// <param name="words"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        bool VerifyingAnAlienDictionary(string[] words, string order);

        /// <summary>
        /// https://leetcode.com/problems/find-the-town-judge/
        /// </summary>
        /// <param name="n"></param>
        /// <param name="trust"></param>
        /// <returns></returns>
        int FindTheTownJudge(int n, int[][] trust);
    }
}
