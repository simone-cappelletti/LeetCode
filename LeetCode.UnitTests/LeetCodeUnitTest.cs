using Microsoft.Extensions.Logging;
using Moq;

namespace LeetCode.UnitTests
{
    public class LeetCodeUnitTest
    {
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

        private ILeetCodeBusiness CreateBusiness()
        {
            var logger = new Mock<ILogger<LeetCodeBusiness>>();

            return new LeetCodeBusiness(logger.Object);
        }
    }
}