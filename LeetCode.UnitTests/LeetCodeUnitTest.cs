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

        [Fact]
        void ValidateBinarySearchTree()
        {
            // Arrange
            var business = CreateBusiness();
            var input = new TreeNode(
                val: 5,
                left: new TreeNode(
                    val: 1),
                right: new TreeNode(
                    val: 4,
                    left: new TreeNode(3),
                    right: new TreeNode(6)));

            // Act
            var result = business.ValidateBinarySearchTree(input);

            // Assert
            Assert.Equal(result, false);
        }

        [Theory]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 1 }, 9, 7)]
        void SearchInRotatedSortedArray(int[] nums, int target, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.SearchInRotatedSortedArray(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void MergeIntervals()
        {
            // Arrange
            var business = CreateBusiness();
            var input = new List<int[]>()
            {
                new int[] { 1, 3},
                new int[] { 2, 6},
                new int[] { 8, 10},
                new int[] { 15, 18}
            };
            var solution = new List<int[]>()
            {
                new int[] { 1, 6},
                new int[] { 8, 10},
                new int[] { 15, 18}
            };

            // Act
            var result = business.MergeIntervals(input.ToArray());

            // Assert
            Assert.Equal(result, solution);
        }


        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        void RansomNote(string ransomNote, string magazine, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RansomNote(ransomNote, magazine);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("abccccdd", 7)]
        void LongestPalindrome(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LongestPalindrome(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void ReverseLinkedList()
        {
            // Arrange
            var business = CreateBusiness();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var resultList = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));

            // Act
            var result = business.ReverseLinkedList(head);

            // Assert
            while (resultList.next is not null)
            {
                Assert.Equal(result.val, resultList.val);

                resultList = resultList.next;
                result = result.next;
            }
        }

        [Theory]
        [InlineData(new int[] { 2, 0, 2, 1, 1, 0 }, new int[] { 0, 0, 1, 1, 2, 2 })]
        void SortColors(int[] nums, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            business.SortColors(nums);

            // Assert
            Assert.Equal(nums, solution);
        }

        [Fact]
        void ImplementTriePrefixTree()
        {
            // Arrange

            // Act
            ImplementTriePrefixTree trie = new ImplementTriePrefixTree();

            trie.Insert("apple");
            var appleInsert = trie.Search("apple");
            var appFirstSearch = trie.Search("app");
            var appPrefix = trie.StartsWith("app");
            trie.Insert("app");
            var appSecondSearch = trie.Search("app");

            // Assert
            Assert.True(appleInsert);
            Assert.False(appFirstSearch);
            Assert.True(appPrefix);
            Assert.True(appSecondSearch);
        }

        [Theory]
        [InlineData("-91283472332", -2147483648)]
        [InlineData("3.14159", 3)]
        [InlineData(".1", 0)]
        [InlineData("+-12", 0)]
        [InlineData("  0000000000012345678", 12345678)]
        [InlineData("10", 10)]
        [InlineData("   +0 123", 0)]
        [InlineData("  +  413", 0)]
        void StringToIntegerAtoi(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.StringToIntegerAtoi(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        void MajorityElement(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.MajorityElement(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("abbaccaba", "baccab")]
        void LongestPalindromicSubstring(string s, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LongestPalindromicSubstring(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        void ContainerWithMostWater(int[] height, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ContainerWithMostWater(height);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, -2, 0)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        void SearchInsertPosition(int[] nums, int target, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.SearchInsertPosition(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("cbaebabacd", "abc", new int[] { 0, 6 })]
        [InlineData("abab", "ab", new int[] { 0, 1, 2 })]
        [InlineData("abecbdecb", "bce", new int[] { 1, 2, 6 })]
        void FindAllAnagramsInAString(string s, string p, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.FindAllAnagramsInAString(s, p);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void Permutations()
        {
            // Arrange
            var business = CreateBusiness();
            var resultList = new List<IList<int>>()
            {
                new List<int>() { 0, 1 },
                new List<int>() { 1, 0 }
            };

            // Act
            var result = business.Permutations(new int[] { 0, 1 });

            // Assert
            Assert.Equal(result, resultList);
        }

        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("1111", "1111", "11110")]
        void AddBinary(string a, string b, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.AddBinary(a, b);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void FloodFill()
        {
            // Arrange
            var business = CreateBusiness();
            var input = new int[][]
            {
                new int[] { 1,1,1 },
                new int[] { 1,1,0 },
                new int[] { 1,0,1 }
            };

            var output = new int[][]
            {
                new int[] { 2,2,2 },
                new int[] { 2,2,0 },
                new int[] { 2, 0, 1 }
            };

            // Act
            var result = business.FloodFill(input, 1, 1, 2);

            // Assert
            Assert.Equal(result, output);
        }

        [Fact]
        void NumberOfIslands()
        {
            // Arrange
            var business = CreateBusiness();
            var input = new char[][]
            {
                new char[] { '1','1','1','1','0' },
                new char[] { '1','1','0','1','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','0','0','0' },
            };

            var output = 1;

            // Act
            var result = business.NumberOfIslands(input);

            // Assert
            Assert.Equal(result, output);
        }

        [Fact]
        void MeetingRooms()
        {
            // Arrange
            var business = CreateBusiness();
            var input = new int[][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            };

            var output = false;

            // Act
            var result = business.MeetingRooms(input);

            // Assert
            Assert.Equal(result, output);
        }

        [Theory]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a#c", "b", false)]
        void BackspaceStringCompare(string s, string t, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.BackspaceStringCompare(s, t);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(5, new int[] { 0, 1, 1, 2, 1, 2 })]
        void CountingBits(int n, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.CountingBits(n);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(128, 1)]
        [InlineData(11, 3)]
        void HammingWeight(uint n, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.HammingWeight(n);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { -1, 0, 1, 2, 3, 7, 9 }, 5, 8)]
        [InlineData(new int[] { -2, 0, 1, 3 }, 2, 2)]
        void ThreeSumSmaller(int[] nums, int target, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ThreeSumSmaller(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { -1, -2, -3, 4, 5, 6, 8, 9 }, 14, 14)]
        [InlineData(new int[] { -1, -2, -3, -4, -5, -6, -8, -9 }, 14, -6)]
        void ThreeSumClosest(int[] nums, int target, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ThreeSumClosest(nums, target);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("aabccabba", 3)]
        [InlineData("cabaabac", 0)]
        [InlineData("aaabbcbcbba", 1)]
        public void MinimumLengthOfStringAfterDeletingSimilarEnds(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.MinimumLengthOfStringAfterDeletingSimilarEnds(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 100 }, 50, 0)]
        [InlineData(new int[] { 200, 100 }, 150, 1)]
        [InlineData(new int[] { 100, 200, 300, 400 }, 200, 2)]
        void BagOfTokensScore(int[] tokens, int power, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.BagOfTokensScore(tokens, power);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 1, 4 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        void CountElementsWithMaximumFrequency(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.CountElementsWithMaximumFrequency(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("kqep", "pekeq", "kqeep")]
        [InlineData("cba", "abcd", "cbad")]
        public void CustomSortString(string order, string s, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.CustomSortString(order, s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(8, 6)]
        [InlineData(4, -1)]
        void FindThePivotInteger(int n, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.FindThePivotInteger(n);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 0, 1 }, 4)]
        [InlineData(new int[] { 0, 1, 0 }, 2)]
        void ContiguousArray(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ContiguousArray(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        void SingleNumber(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.SingleNumber(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Fact]
        void ReorderList()
        {
            // Arrange
            var business = CreateBusiness();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var resultList = new ListNode(1, new ListNode(5, new ListNode(2, new ListNode(4, new ListNode(3)))));

            // Act
            business.ReorderList(head);

            // Assert
            while (resultList.next is not null)
            {
                Assert.Equal(head.val, resultList.val);

                resultList = resultList.next;
                head = head.next;
            }
        }

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 2, 3 })]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1 })]
        void FindAllDuplicatesInAnArray(int[] nums, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.FindAllDuplicatesInAnArray(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
        [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
        void FirstMissingPositive(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.FirstMissingPositive(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 10, 5, 2, 6 }, 100, 8)]
        [InlineData(new int[] { 2, 5, 5, 2, 6 }, 90, 12)]
        void SubarrayProductLessThanK(int[] nums, int k, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.SubarrayProductLessThanK(nums, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3, 1, 2 }, 2, 6)]
        [InlineData(new int[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 1, 2)]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5 }, 4, 4)]
        void LengthOfLongestSubarrayWithAtMostKFrequency(int[] nums, int k, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LengthOfLongestSubarrayWithAtMostKFrequency(nums, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("leetcodeisacommunityforcoders", "ltcdscmmntyfrcdrs")]
        [InlineData("aeiou", "")]
        void RemoveVowelsFromAString(string s, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RemoveVowelsFromAString(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 2, 3, 3 }, 2, 6)]
        [InlineData(new int[] { 1, 4, 2, 1 }, 3, 0)]
        [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4 }, 2, 6)]
        void CountSubarraysWhereMaxElementAppearsAtLeastKTimes(int[] nums, int k, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.CountSubarraysWhereMaxElementAppearsAtLeastKTimes(nums, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 1, 2, 3 }, 2, 7)]
        [InlineData(new int[] { 1, 2, 1, 3, 4 }, 3, 3)]
        void SubarraysWithKDifferentIntegers(int[] nums, int k, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.SubarraysWithKDifferentIntegers(nums, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
        [InlineData(new int[] { 30, 40, 50, 60 }, new int[] { 1, 1, 1, 0 })]
        void DailyTemperatures(int[] temperatures, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.DailyTemperatures(temperatures);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        void LengthOfLastWord(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LengthOfLastWord(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        void MoveZeroes(int[] nums, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            business.MoveZeroes(nums);

            // Assert
            Assert.Equal(nums, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
        [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
        void FindTheDuplicateNumber(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.FindTheDuplicateNumber(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("leEeetcode", "leetcode")]
        [InlineData("abBAcC", "")]
        void MakeTheStringGreat(string s, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.MakeTheStringGreat(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("lee(t(c)o)de)", "lee(t(c)o)de")]
        [InlineData("a)b(c)d", "ab(c)d")]
        [InlineData("))((", "")]
        void MinimumRemoveToMakeValidParentheses(string s, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.MinimumRemoveToMakeValidParentheses(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("(*)", true)]
        [InlineData("(*))", true)]
        void ValidParenthesisString(string s, bool solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.ValidParenthesisString(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 0, 0 }, new int[] { 0, 1, 0, 1 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 0, 0, 1 }, new int[] { 1, 0, 0, 0, 1, 1 }, 3)]
        void NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.NumberOfStudentsUnableToEatLunch(students, sandwiches);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 17, 13, 11, 2, 3, 5, 7 }, new int[] { 2, 13, 3, 11, 5, 17, 7 })]
        [InlineData(new int[] { 1, 1000 }, new int[] { 1, 1000 })]
        void RevealCardsInIncreasingOrder(int[] deck, int[] solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RevealCardsInIncreasingOrder(deck);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("1432219", 3, "1219")]
        [InlineData("10200", 1, "200")]
        [InlineData("10", 2, "0")]
        void RemoveKDigits(string num, int k, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RemoveKDigits(num, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 2 }, 2, 6)]
        [InlineData(new int[] { 5, 1, 1, 1 }, 0, 8)]
        [InlineData(new int[] { 3, 4, 6, 2, 5, 1 }, 1, 16)]
        void TimeNeededToBuyTickets(int[] tickets, int k, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.TimeNeededToBuyTickets(tickets, k);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        void LongestConsecutiveSequence(int[] nums, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.LongestConsecutiveSequence(nums);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
        [InlineData(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
        void TrappingRainWater(int[] height, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.TrappingRainWater(height);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("LVIII", 58)]
        [InlineData("III", 3)]
        public void RomanToInteger(string s, int solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.RomanToInteger(s);

            // Assert
            Assert.Equal(result, solution);
        }

        [Theory]
        [InlineData(3, "III")]
        [InlineData(58, "LVIII")]
        [InlineData(1994, "MCMXCIV")]
        public void IntegerToRoman(int num, string solution)
        {
            // Arrange
            var business = CreateBusiness();

            // Act
            var result = business.IntegerToRoman(num);

            // Assert
            Assert.Equal(result, solution);
        }
    }
}