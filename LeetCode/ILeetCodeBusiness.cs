namespace LeetCode
{
    public interface ILeetCodeBusiness
    {
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
    }
}
