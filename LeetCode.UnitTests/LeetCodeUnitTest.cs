using Microsoft.Extensions.Logging;
using Moq;

namespace LeetCode.UnitTests
{
    public class LeetCodeUnitTest
    {
        [Theory]
        [InlineData(new int[4] { 2, 7, 11, 15 }, 9, new int[2] { 0, 1 })]
        public void TwoSum(int[] nums, int target, int[] solution)
        {
            // Arrange


            // Act
            var result = CreateBusiness().TwoSum(nums, target);


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