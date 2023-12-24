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
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        bool IsPalindrome(int x);

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
        int RemoveDuplicates(int[] nums);

        /// <summary>
        /// https://leetcode.com/problems/longest-substring-with-at-most-two-distinct-characters/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstringTwoDistinct(string s);
    }
}
