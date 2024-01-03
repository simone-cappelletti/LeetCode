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
        public int[] TwoSumII(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left <= right)
            {
                if (numbers[left] + numbers[right] > target)
                {
                    --right;
                }
                else if (numbers[left] + numbers[right] < target)
                {
                    ++left;
                }
                else
                {
                    return new int[] { ++left, ++right };
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
                    dummy.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    dummy.next = list1;
                    list1 = list1.next;
                }

                dummy = dummy.next;
            }

            return head.next.next;
        }

        /// <inheritdoc/>
        public bool ValidPalindromeString(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            s = s.ToLower();

            while (left < right)
            {
                if (!char.IsAsciiLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsAsciiLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if (s[left] != s[right])
                        return false;

                    left++;
                    right--;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public int[][] InsertInterval(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();

            foreach (var interval in intervals)
            {
                if (interval[0] > newInterval[1])
                {
                    result.Add(newInterval);
                    newInterval = interval;
                }
                else if (interval[1] < newInterval[0])
                {
                    result.Add(interval);
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]);
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }

            result.Add(newInterval);

            return result.ToArray();
        }

        /// <inheritdoc/>
        public int LongestSubstringWithoutRepeatingCharacters(string s)
        {
            if (s.Length < 2)
                return s.Length;

            var dic = new Dictionary<char, int>();

            var maxLength = 0;
            var left = 0;
            var right = 0;

            while (right < s.Length)
            {
                if (dic.TryGetValue(s[right], out var value))
                {
                    if (value >= left)
                    {
                        maxLength = Math.Max(maxLength, right - left);
                        left = value + 1;
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, right - left + 1);
                    }

                    dic[s[right]] = right;
                }
                else
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                    dic.Add(s[right], right);
                }

                right++;
            }

            return maxLength;
        }

        /// <inheritdoc/>
        public int EvaluateReversePolishNotation(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out var value))
                {
                    stack.Push(value);
                }
                else
                {
                    var secondOperand = stack.Pop();
                    var firstOperand = stack.Pop();

                    var result = token switch
                    {
                        "+" => firstOperand + secondOperand,
                        "-" => firstOperand - secondOperand,
                        "*" => firstOperand * secondOperand,
                        "/" => firstOperand / secondOperand,
                        _ => throw new ArgumentOutOfRangeException(token)
                    };

                    stack.Push(result);
                }
            }

            return stack.Pop();
        }
    }
}
