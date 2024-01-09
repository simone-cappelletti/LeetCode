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

        /// <inheritdoc/>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // Two pointers approach
            IList<IList<int>> result = new List<IList<int>>();

            // x + y = -z
            var x = 1;
            var y = nums.Length - 1;
            var z = 0;

            Array.Sort(nums);

            while (z < nums.Length - 2)
            {
                var zValue = -nums[z];

                // Break when -zValue > 0 because remaining values cannot sum to zero.
                if (-zValue > 0)
                    break;

                // Skip zValue is the same the one before because we'll have duplicates.
                if (false ==
                    (
                        z > 0 &&
                        zValue == -nums[z - 1]
                    )
                )
                {
                    while (x < y)
                    {
                        var xValue = nums[x];
                        var yValue = nums[y];

                        if (xValue + yValue > zValue)
                        {
                            --y;
                        }
                        else if (xValue + yValue < zValue)
                        {
                            ++x;
                        }
                        else
                        {
                            // Skip when xValue and yValue are the same of previous one
                            if (false ==
                                (
                                    x > 0 &&
                                    y < nums.Length - 1 &&
                                    xValue == nums[x - 1] &&
                                    yValue == nums[y + 1]

                                )
                            )
                            {
                                result.Add(new List<int>() { xValue, yValue, -zValue });
                            }

                            --y;
                            ++x;
                        }
                    }
                }

                ++z;
                x = z + 1;
                y = nums.Length - 1;
            }

            return result;
        }

        /// <inheritdoc/>
        public int BinarySearch(int[] nums, int target)
        {
            var index = -1;

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (target > nums[mid])
                {
                    left = ++mid;
                }
                else if (target < nums[mid])
                {
                    right = --mid;
                }
                else
                {
                    return mid;
                }
            }

            return index;
        }

        /// <inheritdoc/>
        public string MinimumWindowSubstring(string s, string t)
        {
            if (s.Length < t.Length)
                return string.Empty;

            var sCount = new int[128];
            var tCount = new int[128];

            var left = 0;
            var right = 0;
            var minLength = Int32.MaxValue;
            var start = 0;
            var matchingChars = t.Length;

            foreach (var @char in t)
                tCount[@char]++;

            while (right < s.Length)
            {
                var @char = s[right];
                sCount[@char]++;

                if (tCount[@char] > 0 &&
                    sCount[@char] <= tCount[@char])
                {
                    matchingChars--;
                }

                while (matchingChars == 0)
                {
                    if (right - left + 1 < minLength)
                    {
                        minLength = right - left + 1;
                        start = left;
                    }

                    var @leftChar = s[left];
                    sCount[@leftChar]--;

                    if (tCount[@leftChar] > 0 &&
                        sCount[@leftChar] < tCount[@leftChar])
                    {
                        matchingChars++;
                    }

                    left++;
                }

                right++;
            }

            return minLength == Int32.MaxValue ? string.Empty : s.Substring(start, minLength);
        }

        /// <inheritdoc/>
        public int[] ProductOfArrayExceptSelf(int[] nums)
        {
            var answer = new int[nums.Length];
            var totalProduct = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                answer[i] = totalProduct;
                totalProduct *= nums[i];
            }

            totalProduct = 1;
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= totalProduct;
                totalProduct *= nums[i];
            }

            return answer;
        }

        /// <inheritdoc/>
        public ListNode RemoveNthNodeFromEndOfList(ListNode head, int n)
        {
            var count = 0;
            var firstNode = head;
            var secondNode = head;
            var result = head;

            while (count < n)
            {
                firstNode = firstNode.next;
                count++;
            }

            if (firstNode == null)
                return head.next;

            while (firstNode.next != null)
            {
                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }

            secondNode.next = secondNode.next.next;

            return result;
        }

        /// <inheritdoc/>
        public TreeNode InvertBinaryTree(TreeNode root)
        {
            if (root is null)
                return null;

            var leftNode = InvertBinaryTree(root.left);
            var rightNode = InvertBinaryTree(root.right);

            root.left = rightNode;
            root.right = leftNode;

            return root;
        }

        /// <inheritdoc/>
        public bool BalancedBinaryTree(TreeNode root)
        {
            if (root is null)
                return true;

            return
                Math.Abs(Height(root.left) - Height(root.right)) < 2 &&
                BalancedBinaryTree(root.left) &&
                BalancedBinaryTree(root.right);

            int Height(TreeNode node)
            {
                if (node is null)
                    return -1;
                else
                    return 1 + Math.Max(Height(node.left), Height(node.right));
            }
        }
    }
}
