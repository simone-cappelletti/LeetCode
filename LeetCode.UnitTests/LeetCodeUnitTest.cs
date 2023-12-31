using Microsoft.Extensions.Logging;
using Moq;

namespace LeetCode.UnitTests
{
    public class LeetCodeUnitTest
    {
        private ILeetCodeBusiness CreateBusiness()
        {
            var logger = new Mock<ILogger<LeetCodeBusiness>>();

            return new LeetCodeBusiness(logger.Object);
        }

        [Theory]
        [InlineData(new int[4] { 2, 7, 11, 15 }, 9, new int[2] { 0, 1 })]
        [InlineData(new int[4] { 2, -6, -9, 3 }, -15, new int[2] { 1, 2 })]
        [InlineData(new int[5] { -2, 7, 11, 15, 6 }, 4, new int[2] { 0, 4 })]
        [InlineData(new int[5] { 5, 1, 5, 15, 4 }, 10, new int[2] { 0, 2 })]
        [InlineData(new int[5] { 2, 8, -3, 0, 2 }, 4, new int[2] { 0, 4 })]
        [InlineData(new int[5] { -2, -4, -1, -5, 9 }, 4, new int[2] { 3, 4 })]
        [InlineData(new int[5] { 5, 1, 5, 15, 6 }, 11, new int[2] { 0, 4 })]
        public void TwoSum(int[] nums, int target, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.TwoSum(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[4] { 2, 7, 11, 15 }, 9, new int[2] { 1, 2 })]
        [InlineData(new int[3] { 2, 3, 4 }, 6, new int[2] { 1, 3 })]
        [InlineData(new int[2] { -1, 0 }, -1, new int[2] { 1, 2 })]
        [InlineData(new int[4] { 0, 0, 3, 4 }, 0, new int[2] { 1, 2 })]
        [InlineData(new int[4] { -3, 3, 4, 90 }, 0, new int[2] { 1, 2 })]
        public void TwoSumII(int[] numbers, int target, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.TwoSumII(numbers, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(10, false)]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(4224, true)]
        [InlineData(4227, false)]
        public void PalindromeNumber(int x, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.PalindromeNumber(x);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new int[] { 2, 2, 3 }, 2, 1)]
        public void RemoveElement(int[] nums, int val, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RemoveElement(nums, val);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void RemoveDuplicatesFromSortedArray(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RemoveDuplicatesFromSortedArray(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("eceba", 3)]
        [InlineData("ccaabbb", 5)]
        [InlineData("ababffzzeee", 5)]
        [InlineData("ababcbcbaaabbdef", 6)]
        [InlineData("leeetcode", 4)]
        [InlineData("abaccc", 4)]
        [InlineData("abc", 2)]
        public void LengthOfLongestSubstringTwoDistinct(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LengthOfLongestSubstringTwoDistinct(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void BestTimeToBuyAndSellStock(int[] prices, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.BestTimeToBuyAndSellStock(prices);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("([)]", false)]
        public void ValidParentheses(string s, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ValidParentheses(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        public void MergeTwoSortedListsRecursive()
        {
            // Arrange
            var business = CreateBusiness();

            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var resultList = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            // Act
            var result = business.MergeTwoSortedListsRecursive(list1, list2);

            // Assert
            while (resultList.next is not null)
            {
                Assert.Equal(result.val, resultList.val);

                resultList = resultList.next;
                result = result.next;
            }
        }

        [Fact]
        public void MergeTwoSortedListsIterative()
        {
            // Arrange
            var business = CreateBusiness();

            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var resultList = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            // Act
            var result = business.MergeTwoSortedListsIterative(list1, list2);

            // Assert
            while (resultList.next is not null)
            {
                Assert.Equal(result.val, resultList.val);

                resultList = resultList.next;
                result = result.next;
            }
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void ValidPalindromeString(string s, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ValidPalindromeString(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        public void InsertInterval()
        {
            // Arrange
            var business = CreateBusiness();

            var intervals = new int[][] { [1, 2], [3, 5], [6, 7], [8, 10], [12, 16] };
            var newInterval = new int[] { 4, 8 };
            var solution = new int[][] { [1, 2], [3, 10], [12, 16] };

            // Act
            var result = business.InsertInterval(intervals, newInterval);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("abba", 2)]
        [InlineData("tmmzuxt", 5)]
        public void LongestSubstringWithoutRepeatingCharacters(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LongestSubstringWithoutRepeatingCharacters(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
        [InlineData(new string[] { "4", "13", "5", "/", "+" }, 6)]
        [InlineData(new string[] { "2", "1", "+", "3", "*" }, 9)]
        [InlineData(new string[] { "3", "11", "+", "5", "-" }, 9)]
        public void EvaluateReversePolishNotation(string[] tokens, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.EvaluateReversePolishNotation(tokens);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        public void ThreeSum()
        {
            // Arrange
            var business = CreateBusiness();
            var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var solution = new List<IList<int>>()
            {
                new List<int> {-1, 2, -1 },
                new List<int> {0, 1, -1 }
            };

            // Act
            var result = business.ThreeSum(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        void BinarySearch(int[] nums, int target, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.BinarySearch(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("ADOBECODEBANC", "ABC", "BANC")]
        void MinimumWindowSubstring(string s, string t, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.MinimumWindowSubstring(s, t);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        void ProductOfArrayExceptSelf(int[] nums, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ProductOfArrayExceptSelf(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void RemoveNthNodeFromEndOfList()
        {
            // Arrange
            var business = CreateBusiness();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var resultList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));

            // Act
            var result = business.RemoveNthNodeFromEndOfList(head, 2);

            // Assert
            while (resultList.next is not null)
            {
                Assert.Equal(result.val, resultList.val);

                resultList = resultList.next;
                result = result.next;
            }
        }
    }
}