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
    }
}
