namespace LeetCode
{
    public class LeetCodeBusiness : ILeetCodeBusiness
    {
        private readonly ILogger<LeetCodeBusiness> _logger;

        public LeetCodeBusiness(ILogger<LeetCodeBusiness> logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                // target = x + y;
                var x = nums[i];
                var y = target - x;

                if (dic.TryGetValue(y, out var yIndex))
                {
                    return new int[2] { yIndex, i };
                }
                else
                {
                    if (!dic.ContainsKey(x))
                        dic.Add(x, i);
                }
            }

            throw new ArgumentException("No solution found");
        }

        /// <inheritdoc/>
        public bool PalindromeNumber(int x)
        {
            if (x < 0) return false;
            if (x % 10 == 0 && x != 0) return false;

            var myValue = 0;

            while (x > myValue)
            {
                myValue = myValue * 10 + x % 10;

                x /= 10;
            }

            return myValue == x || myValue / 10 == x;
        }

        /// <inheritdoc/>
        public int RemoveElement(int[] nums, int val)
        {
            var numsLength = nums.Length;
            var i = 0;

            while (i < numsLength)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[--numsLength];
                }
                else
                {
                    i++;
                }
            }

            return numsLength;
        }

        /// <inheritdoc/>
        public int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            var k = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                var value = nums[i];
                if (value != nums[i - 1])
                {
                    nums[k++] = value;
                }
            }

            return k;
        }

        /// <inheritdoc/>
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            var characters = new Dictionary<char, int>();
            var maxLength = 0;

            for (int left = 0, right = 0; right < s.Length; right++)
            {
                characters.TryGetValue(s[right], out int count);
                characters[s[right]] = count + 1;

                while (characters.Count > 2)
                {
                    characters[s[left]]--;

                    if (characters[s[left]] < 1)
                    {
                        characters.Remove(s[left]);
                    }

                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        /// <inheritdoc/>
        public bool ValidParentheses(string s)
        {
            var characters = new Stack<char>();

            const char openRoundPar = '(';
            const char closedRoundPar = ')';

            const char openSquarePar = '[';
            const char closedSquarePar = ']';

            const char openBracketPar = '{';
            const char closedBracketPar = '}';

            foreach (var @char in s)
            {
                switch (@char)
                {
                    case openRoundPar:
                    case openSquarePar:
                    case openBracketPar:

                        characters.Push(@char);

                        break;

                    case closedRoundPar:

                        if (!characters.TryPop(out var currentOpenRoundPar) ||
                            !currentOpenRoundPar.Equals(openRoundPar))
                        {
                            return false;
                        }

                        break;

                    case closedSquarePar:

                        if (!characters.TryPop(out var currentOpenSquarePar) ||
                            !currentOpenSquarePar.Equals(openSquarePar))
                        {
                            return false;
                        }

                        break;

                    case closedBracketPar:

                        if (!characters.TryPop(out var currentOpenBracketPar) ||
                            !currentOpenBracketPar.Equals(openBracketPar))
                        {
                            return false;
                        }

                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
                }
            }

            return characters.Count == 0;
        }

        /// <inheritdoc/>
        public int BestTimeToBuyAndSellStock(int[] prices)
        {
            var minPrice = prices[0];
            var maxValue = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                maxValue = Math.Max(maxValue, prices[i] - minPrice);
            }

            return maxValue;
        }

        /// <inheritdoc/>
        public ListNode MergeTwoSortedListsRecursive(ListNode list1, ListNode list2)
        {
            if (list1 is null) return list2;
            else if (list2 is null) return list1;
            else if (list1.val > list2.val)
            {
                list2.next = MergeTwoSortedListsRecursive(list1, list2.next);

                return list2;
            }
            else
            {
                list1.next = MergeTwoSortedListsRecursive(list1.next, list2);

                return list1;
            }
        }

        /// <inheritdoc/>
        public ListNode MergeTwoSortedListsIterative(ListNode list1, ListNode list2)
        {
            var head = new ListNode();
            var dummy = new ListNode();

            head.next = dummy;

            while (list1 is not null || list2 is not null)
            {
                if (list1 is null)
                {
                    dummy.next = list2;
                    break;
                }
                else if (list2 is null)
                {
                    dummy.next = list1;
                    break;
                }
                else if (list1.val > list2.val)
                {
                    dummy.next = new ListNode(list2.val);

                    list2 = list2.next;
                }
                else
                {
                    dummy.next = new ListNode(list1.val);

                    list1 = list1.next;
                }

                dummy = dummy.next;
            }

            return head.next.next;
        }
    }
}
