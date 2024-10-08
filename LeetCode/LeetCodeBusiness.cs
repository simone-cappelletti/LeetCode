﻿using System.Text;

namespace LeetCode
{
    public class LeetCodeBusiness : ILeetCodeBusiness
    {
        private readonly ILogger<LeetCodeBusiness> _logger;

        /// <inheritdoc/>
        public MinStack MinStack { get; } = new();

        /// <inheritdoc/>
        public ImplementQueueUsingStacks ImplementQueueUsingStacks { get; } = new();

        /// <inheritdoc/>
        public TimeBasedKeyValueStore TimeBasedKeyValueStore { get; } = new();

        /// <inheritdoc/>
        public ImplementTriePrefixTree ImplementTriePrefixTree { get; } = new();

        /// <inheritdoc/>
        public SerializeAndDeserializeBinaryTree SerializeAndDeserializeBinaryTree { get; } = new();

        /// <inheritdoc/>
        public LRUCache LRUCache { get; }

        /// <inheritdoc/>
        public EncodeAndDecodeStrings EncodeAndDecodeStrings { get; }

        /// <inheritdoc/>
        public StockSpanner StockSpanner { get; }

        /// <inheritdoc/>
        public KthLargestElementInAStream KthLargestElementInAStream { get; }

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

        /// <inheritdoc/>
        public bool ValidateBinarySearchTree(TreeNode root)
        {
            return IsBST(root, null, null);

            bool IsBST(TreeNode node, int? low, int? high)
            {
                if (node is null)
                    return true;

                if (
                    (low.HasValue && node.val <= low.Value) ||
                    (high.HasValue && node.val >= high.Value)
                )
                    return false;

                return
                    IsBST(node.left, low, node.val) &&
                    IsBST(node.right, node.val, high);
            }
        }

        /// <inheritdoc/>
        public int FirstBadVersion(int n)
        {
            // Simulate API
            var IsBadVersion = (int x) => { return true; };

            return BinarySearch(n);

            // Time complexity: O(log(n))
            // Space complexity: O(1)

            int BinarySearch(int n)
            {
                var start = 1;
                var end = n;
                while (start <= end)
                {
                    var mid = start + (end - start) / 2;

                    if (IsBadVersion(mid))
                        end = mid - 1;
                    else
                        start = mid + 1;
                }

                return start;
            }
        }

        /// <inheritdoc/>
        public int SearchInRotatedSortedArray(int[] nums, int target)
        {
            var result = 0;

            if (nums[0] > nums[nums.Length - 1])
                result = RotatedBinarySearch(nums, target);
            else
                result = NormalBinarySearch(nums, target);

            return result;

            // Time Complexity: O(log n)
            // Space Complexity: O(1)

            int RotatedBinarySearch(int[] nums, int target)
            {
                var start = 0;
                var end = nums.Length - 1;

                while (start <= end)
                {
                    var mid = start + (end - start) / 2;

                    if (nums[mid] == target)
                        return mid;
                    else if (nums[mid] >= nums[start])
                    {
                        // Left side ordered
                        if (nums[start] <= target &&
                            nums[mid] >= target)
                            end = mid - 1;
                        else
                            start = mid + 1;
                    }
                    else
                    {
                        // Right side ordered
                        if (nums[mid] <= target &&
                            nums[end] >= target)
                            start = mid + 1;
                        else
                            end = mid - 1;
                    }
                }

                return -1;
            }

            int NormalBinarySearch(int[] nums, int target)
            {
                var start = 0;
                var end = nums.Length - 1;

                while (start <= end)
                {
                    var mid = start + (end - start) / 2;

                    if (nums[mid] > target)
                        end = mid - 1;
                    else if (nums[mid] < target)
                        start = mid + 1;
                    else if (nums[mid] == target)
                        return mid;
                }

                return -1;
            }
        }

        /// <inheritdoc/>
        public TreeNode LowestCommonAncestorOfABinarySearchTree(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root is null)
                return null;

            if (p.val > root.val &&
                q.val > root.val)
                return LowestCommonAncestorOfABinarySearchTree(root.right, p, q);
            else if (p.val < root.val &&
                    q.val < root.val)
                return LowestCommonAncestorOfABinarySearchTree(root.left, p, q);
            else
                return root;

            // Time Complexity: O(N)
            // Space Complexity: O(N)
        }

        /// <inheritdoc/>
        public int[][] MergeIntervals(int[][] intervals)
        {
            var result = new List<int[]>();
            var sortedIntervals = intervals.OrderBy(x => x[0]);
            var currentInterval = new int[2] { -1, -1 };

            foreach (var interval in sortedIntervals)
            {
                if (currentInterval[0] == -1)
                    currentInterval = interval;
                else
                {
                    if (currentInterval[1] >= interval[0])
                        currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
                    else
                    {
                        result.Add(new int[] { currentInterval[0], currentInterval[1] });
                        currentInterval = interval;
                    }
                }
            }

            result.Add(new int[] { currentInterval[0], currentInterval[1] });

            return result.ToArray();

            // Time Complexity: O(n log(n))
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public bool RansomNote(string ransomNote, string magazine)
        {
            var ransomNoteDic = new Dictionary<char, int>(26);

            foreach (var @char in ransomNote)
            {
                ransomNoteDic.TryGetValue(@char, out var value);
                ransomNoteDic[@char] = ++value;
            }

            foreach (var @char in magazine)
            {
                if (ransomNoteDic.TryGetValue(@char, out var value))
                {
                    ransomNoteDic[@char] = --value;
                    if (value == 0)
                        ransomNoteDic.Remove(@char);
                }
            }

            return ransomNoteDic.Count() == 0;

            // Time Complexity: O(Max(ransomNote, magazine))
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int LongestPalindrome(string s)
        {
            var dic = new int[52];
            var result = 0;
            var oddChar = 0;

            foreach (var @char in s)
                dic[ASCIIToIndex(@char)]++;

            foreach (var @char in dic)
            {
                if (@char % 2 == 0)
                {
                    result += @char;
                }
                else
                {
                    result += @char - 1;
                    oddChar = Math.Max(oddChar, @char);
                }
            }

            if (oddChar > 0)
                result += oddChar - (oddChar - 1);

            return result;

            int ASCIIToIndex(char c)
            {
                if (c >= 97) // a-z
                    return c - 71;

                return c - 65; // A-Z
            }

            // Time Complexity: O(n)
            // Space Complecity: 0(1) - 52 characters
        }

        /// <inheritdoc/>
        public ListNode ReverseLinkedList(ListNode head)
        {
            if (head is null)
                return head;

            ListNode prev = null;

            while (head is not null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public TreeNode LowestCommonAncestorOfABinaryTree(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode lowestCommonAncestor = null;

            DFS(root, p, q);

            return lowestCommonAncestor;

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            bool DFS(TreeNode root, TreeNode p, TreeNode q)
            {
                if (root is null)
                    return false;

                var nodeFound = root == p || root == q;
                var leftSubTree = DFS(root.left, p, q);
                var rightSubTree = DFS(root.right, p, q);

                if (nodeFound)
                {
                    if (leftSubTree || rightSubTree)
                        lowestCommonAncestor = root;
                }
                else
                {
                    if (leftSubTree && rightSubTree)
                        lowestCommonAncestor = root;
                }

                return nodeFound || leftSubTree || rightSubTree;
            }
        }

        /// <inheritdoc/>
        public void SortColors(int[] nums)
        {
            var redIndex = 0;
            var blueIndex = nums.Length - 1;

            for (var i = 0; i <= blueIndex; i++)
            {
                switch (nums[i])
                {
                    case 0:

                        if (i > redIndex)
                        {
                            Swap(nums, redIndex, i);
                            redIndex++;
                            i--;
                        }

                        break;

                    case 2:

                        Swap(nums, blueIndex, i);
                        blueIndex--;
                        i--;

                        break;
                }
            }

            void Swap(int[] nums, int start, int end)
            {
                var temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
            }

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int StringToIntegerAtoi(string s)
        {
            var stack = new Stack<int>();
            var result = 0;
            var sign = ' ';
            var exitLoop = false;

            foreach (var @char in s)
            {
                switch (@char)
                {
                    case '+':
                    case '-':

                        if (stack.Count() == 0 && sign == ' ')
                            sign = @char;
                        else
                            exitLoop = true;

                        break;

                    case ' ':

                        if (stack.Count() > 0 || sign != ' ')
                            exitLoop = true;

                        break;

                    case '.':

                        if (stack.Count() >= 0)
                            exitLoop = true;

                        break;

                    default:

                        if (int.TryParse(@char.ToString(), out var value))
                            stack.Push(value);
                        else
                            exitLoop = true;

                        break;
                }

                if (exitLoop)
                    break;
            }

            try
            {
                var power = 0;
                while (stack.Count > 0)
                {
                    checked
                    {
                        var stackValue = stack.Pop();
                        if (stackValue != 0)
                        {
                            var powerValue = (int)Math.Pow(10, power);
                            var currentValue = stackValue * powerValue;
                            result += currentValue;
                        }

                        power++;
                    }
                }
            }
            catch (OverflowException e)
            {
                result = sign == '-' ? int.MinValue : int.MaxValue;
            }

            return sign == '-' ? -result : result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int MajorityElement(int[] nums)
        {
            // Boyer-Moore

            if (nums.Length == 1)
                return nums[0];

            var candidate = nums[0];
            var freq = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (freq == 0)
                    candidate = nums[i];

                freq += nums[i] == candidate ? 1 : -1;

                if (freq > Math.Floor((double)nums.Length / 2))
                    return candidate;
            }

            return candidate;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public string LongestPalindromicSubstring(string s)
        {
            // Brute force
            for (int length = s.Length; length > 0; length--)
                for (int start = 0; start <= s.Length - length; start++)
                {
                    if (IsPalindrome(start, start + length - 1, s))
                        return s.Substring(start, length);
                }

            return string.Empty;

            bool IsPalindrome(int i, int j, string s)
            {
                while (i < j)
                {
                    if (s[i] != s[j])
                        return false;

                    i++;
                    j--;
                }

                return true;
            }

            // Time Complexity: O(n^3)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int ContainerWithMostWater(int[] height)
        {
            var result = 0;
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                var leftValue = height[left];
                var rightValue = height[right];

                var minValue = Math.Min(leftValue, rightValue);
                result = Math.Max(result, minValue * (right - left));

                if (leftValue <= rightValue)
                    left++;
                else
                    right--;
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int SearchInsertPosition(int[] nums, int target)
        {
            var index = Array.BinarySearch(nums, target);

            if (index < 0)
                index = Math.Abs(++index);

            return index;

            // Time complexity: O(log n)
            // Space complexity: O(1)
        }

        /// <inheritdoc/>
        public IList<int> FindAllAnagramsInAString(string s, string p)
        {
            var result = new List<int>();
            var pDic = new int[26];
            var sDic = new int[26];
            var a = 'a';

            foreach (var @char in p)
                pDic[@char - a]++;

            var left = 0;
            for (var right = 0; right < s.Length; right++)
            {
                sDic[s[right] - a]++;

                if (right - left + 1 != p.Length)
                    continue;

                if (Enumerable.SequenceEqual(pDic, sDic))
                    result.Add(left);

                sDic[s[left] - a]--;
                left++;
            }

            return result;

            // Time Complexity: O(n) with n = MAX(s,p)
            // Space complexity: O(1)
        }

        /// <inheritdoc/>
        public IList<IList<int>> Permutations(int[] nums)
        {
            if (nums.Length == 1)
                return new List<IList<int>>()
            {
                new List<int>() {nums[0]}
            };

            return GetPermutations(nums);

            List<IList<int>> GetPermutations(int[] nums)
            {
                if (nums.Length == 2)
                {
                    return new List<IList<int>>()
                    {
                        new List<int>() {nums[0], nums[1]},
                        new List<int>() {nums[1], nums[0]}
                    };
                }

                var number = nums[0];
                var permutations = GetPermutations(nums[1..]);
                var result = new List<IList<int>>();

                foreach (var permutation in permutations)
                {
                    var counter = permutation.Count();
                    for (var i = counter; i >= 0; i--)
                    {
                        var newPermutation = permutation.ToList();
                        newPermutation.Insert(i, number);
                        result.Add(newPermutation);
                    }
                }

                return result;
            }

            // Time Complexity: O(n!) with n = nums.Length
            // Space Complexity: O(n) with n = nums.Length
        }

        /// <inheritdoc/>
        public string AddBinary(string a, string b)
        {
            var sb = new StringBuilder();

            if (a.Length > b.Length)
                b = b.PadLeft(a.Length, '0');
            else
                a = a.PadLeft(b.Length, '0');

            var count = false;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                var x = a[i];
                var y = b[i];

                if (x.Equals('1') && y.Equals('1'))
                {
                    if (count)
                        sb.Insert(0, '1');
                    else
                    {
                        count = true;
                        sb.Insert(0, '0');
                    }
                }
                else if (x.Equals('0') && y.Equals('0'))
                {
                    if (count)
                    {
                        count = false;
                        sb.Insert(0, '1');
                    }
                    else
                        sb.Insert(0, '0');
                }
                else
                {
                    if (count)
                        sb.Insert(0, '0');
                    else
                        sb.Insert(0, '1');
                }
            }

            if (count)
                sb.Insert(0, '1');

            return sb.ToString();

            // Time Complexity: O(n) with n = Max(a,b)
            // Space Complexity: O(n) with n = Max(a,b)
        }

        /// <inheritdoc/>
        public ListNode MiddleOfTheLinkedList(ListNode head)
        {
            var slowNode = head;
            var fastNode = head;

            while (fastNode.next?.next is not null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }

            if (fastNode.next is not null)
                return slowNode.next;

            return slowNode;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int FindCenterOfStarGraph(int[][] edges)
        {
            return
                edges[0][0] == edges[1][0] ||
                edges[0][0] == edges[1][1] ?
                edges[0][0] :
                edges[0][1];

            // Time Complexity: O(1)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var queue = new Queue<(int, int)>();

            queue.Enqueue((sr, sc));

            while (queue.Count > 0)
            {
                var element = queue.Dequeue();
                var elementColor = image[element.Item1][element.Item2];

                if (elementColor == color)
                    continue;

                // UP
                if (element.Item1 - 1 >= 0 && image[element.Item1 - 1][element.Item2] == elementColor)
                    queue.Enqueue((element.Item1 - 1, element.Item2));

                // DOWN
                if (element.Item1 + 1 < image.Length && image[element.Item1 + 1][element.Item2] == elementColor)
                    queue.Enqueue((element.Item1 + 1, element.Item2));

                // LEFT
                if (element.Item2 - 1 >= 0 && image[element.Item1][element.Item2 - 1] == elementColor)
                    queue.Enqueue((element.Item1, element.Item2 - 1));

                // RIGHT
                if (element.Item2 + 1 < image[element.Item1].Length && image[element.Item1][element.Item2 + 1] == elementColor)
                    queue.Enqueue((element.Item1, element.Item2 + 1));

                image[element.Item1][element.Item2] = color;
            }

            return image;

            // N = number of pixels
            //
            // Time Complexity: O(N)
            // Space Complexity: O(N)
        }

        /// <inheritdoc/>
        public int[][] Matrix01(int[][] mat)
        {
            var visited = new bool[mat.Length][];
            var queue = new Queue<(int X, int Y)>();

            for (var x = 0; x < mat.Length; x++)
            {
                visited[x] = new bool[mat[x].Length];

                for (var y = 0; y < mat[x].Length; y++)
                {
                    if (mat[x][y] == 0)
                    {
                        queue.Enqueue((x, y));
                        visited[x][y] = true;
                    }
                }
            }

            while (queue.Count > 0)
            {
                var XYCoord = queue.Dequeue();
                var value = mat[XYCoord.X][XYCoord.Y];

                // UP
                if (XYCoord.X - 1 >= 0 && !visited[XYCoord.X - 1][XYCoord.Y])
                {
                    mat[XYCoord.X - 1][XYCoord.Y] = value + 1;
                    queue.Enqueue((XYCoord.X - 1, XYCoord.Y));
                    visited[XYCoord.X - 1][XYCoord.Y] = true;
                }

                // DOWN
                if (XYCoord.X + 1 < mat.Length && !visited[XYCoord.X + 1][XYCoord.Y])
                {
                    mat[XYCoord.X + 1][XYCoord.Y] = value + 1;
                    queue.Enqueue((XYCoord.X + 1, XYCoord.Y));
                    visited[XYCoord.X + 1][XYCoord.Y] = true;
                }

                // LEFT
                if (XYCoord.Y - 1 >= 0 && !visited[XYCoord.X][XYCoord.Y - 1])
                {
                    mat[XYCoord.X][XYCoord.Y - 1] = value + 1;
                    queue.Enqueue((XYCoord.X, XYCoord.Y - 1));
                    visited[XYCoord.X][XYCoord.Y - 1] = true;
                }

                // RIGHT
                if (XYCoord.Y + 1 < mat[XYCoord.X].Length && !visited[XYCoord.X][XYCoord.Y + 1])
                {
                    mat[XYCoord.X][XYCoord.Y + 1] = value + 1;
                    queue.Enqueue((XYCoord.X, XYCoord.Y + 1));
                    visited[XYCoord.X][XYCoord.Y + 1] = true;
                }
            }

            return mat;

            // Time Complexity: 0(mn)
            // Space Complexity: 0(mn)
        }

        /// <inheritdoc/>
        public IList<IList<int>> BinaryTreeLevelOrderTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();
            var queue = new Queue<(int Level, TreeNode Node)>();

            if (root is null)
                return result;

            result.Add(new List<int>() { root.val });
            queue.Enqueue((0, root));

            while (queue.Count > 0)
            {
                var (Level, Node) = queue.Dequeue();

                if (Node.left is null &&
                   Node.right is null)
                    continue;

                while (result.Count <= Level + 1)
                    result.Add(new List<int>());

                if (Node.left is not null)
                {
                    result[Level + 1].Add(Node.left.val);
                    queue.Enqueue((Level + 1, Node.left));
                }

                if (Node.right is not null)
                {
                    result[Level + 1].Add(Node.right.val);
                    queue.Enqueue((Level + 1, Node.right));
                }
            }

            return result;

            // Time Complexity: O(n) with n number of nodes
            // Space Complexity: O(n) with n number of nodes
        }

        /// <inheritdoc/>
        public Node CloneGraph(Node node)
        {
            if (node is null)
                return null;

            var newNode = new Node(node.val, new List<Node>());

            var nodes = new Dictionary<int, Node>()
            {
                {newNode.val, newNode}
            };

            DFS(newNode, node);

            return newNode;

            // Time Complexity: O(n) with n number of nodes.
            // Space Complexity: O(n) with n number of nodes.

            void DFS(Node newNode, Node node)
            {
                foreach (var neighbor in node.neighbors)
                {
                    if (!nodes.TryGetValue(neighbor.val, out var newNeighbor))
                    {
                        newNeighbor = new Node(neighbor.val);

                        nodes.Add(newNeighbor.val, newNeighbor);

                        DFS(newNeighbor, neighbor);
                    }

                    newNode.neighbors.Add(newNeighbor);
                }
            }
        }

        /// <inheritdoc/>
        public int NumberOfIslands(char[][] grid)
        {
            var result = 0;
            var directions = new List<(int Row, int Col)>()
            {
                (1, 0), (-1, 0), (0, 1), (0, -1)
            };

            for (var row = 0; row < grid.Length; row++)
                for (var col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == '0')
                        continue;

                    var queue = new Queue<(int Row, int Col)>();
                    queue.Enqueue((row, col));
                    grid[row][col] = '0';

                    while (queue.Count > 0)
                    {
                        var (Row, Col) = queue.Dequeue();

                        foreach (var (directionRow, directionCol) in directions)
                        {
                            var currentRow = Row + directionRow;
                            var currentCcol = Col + directionCol;

                            if (currentRow >= 0 &&
                                currentRow < grid.Length &&
                                currentCcol >= 0 &&
                                currentCcol < grid[row].Length &&
                                grid[currentRow][currentCcol] == '1')
                            {
                                queue.Enqueue((currentRow, currentCcol));
                                grid[currentRow][currentCcol] = '0';
                            }
                        }
                    }

                    result++;
                }

            return result;

            // Time Complexity: O(M x N) with M = grid rows and N = grid columns
            // Space Complexity: O(min(M x N)) with M = grid rows and N = grid columns
        }

        /// <inheritdoc/>
        public bool MeetingRooms(int[][] intervals)
        {
            var orderedMeetings = intervals.OrderBy(x => x[0]).ToArray();

            for (var i = 1; i < orderedMeetings.Count(); i++)
                if (orderedMeetings[i][0] < orderedMeetings[i - 1][1])
                    return false;

            return true;

            // Time Complexity: O(n)
            // Space Complecity: O(n)
        }

        /// <inheritdoc/>
        public bool BackspaceStringCompare(string s, string t)
        {
            const char BACKSPACE = '#';
            int sPos = s.Length - 1, tPos = t.Length - 1;
            int sBackspaceCount = 0, tBackspaceCount = 0;

            while (sPos >= 0 || tPos >= 0)
            {
                while (sPos >= 0)
                {
                    if (s[sPos].Equals(BACKSPACE))
                    {
                        sBackspaceCount++;
                        sPos--;
                    }
                    else if (sBackspaceCount > 0)
                    {
                        sBackspaceCount--;
                        sPos--;
                    }
                    else
                    {
                        break;
                    }
                }

                while (tPos >= 0)
                {
                    if (t[tPos].Equals(BACKSPACE))
                    {
                        tBackspaceCount++;
                        tPos--;
                    }
                    else if (tBackspaceCount > 0)
                    {
                        tBackspaceCount--;
                        tPos--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sPos >= 0 && tPos >= 0)
                {
                    if (!s[sPos].Equals(t[tPos]))
                        return false;
                }

                if ((sPos >= 0) != (tPos >= 0))
                    return false;

                sPos--;
                tPos--;
            }

            return true;

            // Time Complexity: O(max(s, t))
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int RottingOranges(int[][] grid)
        {
            var result = 0;
            var queue = new Queue<(int Level, int Row, int Col)>();
            var directions = new List<(int Row, int Col)>()
            {
                (1, 0),  // Down
                (-1, 0), // Up
                (0, 1),  // Right
                (0, -1), // Left
            };

            for (var row = 0; row < grid.Length; row++)
                for (var col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 2)
                    {
                        var partialResult = 0;
                        queue.Enqueue((0, row, col));

                        while (queue.Count > 0)
                        {
                            var (currLevel, currRow, currCol) = queue.Dequeue();
                            var nextLevel = currLevel + 1;
                            grid[currRow][currCol] = 0;
                            var freshOrangeFound = false;

                            foreach (var (dirRow, dirCol) in directions)
                            {
                                if (
                                    currRow + dirRow < grid.Length &&
                                    currRow + dirRow >= 0 &&
                                    currCol + dirCol < grid[currRow].Length &&
                                    currCol + dirCol >= 0 &&
                                    grid[currRow + dirRow][currCol + dirCol] == 1
                                )
                                {
                                    queue.Enqueue((nextLevel, currRow + dirRow, currCol + dirCol));
                                    freshOrangeFound = true;
                                }
                            }

                            if (freshOrangeFound)
                                partialResult = nextLevel;
                        }

                        result = Math.Max(result, partialResult);
                    }
                }

            for (var row = 0; row < grid.Length; row++)
                for (var col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1)
                        return -1;
                }

            return result;
        }

        /// <inheritdoc/>
        public int[] CountingBits(int n)
        {
            var result = new int[n + 1];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = Get1s(i);
            }

            return result;

            int Get1s(int n)
            {
                var result = 0;

                while (n > 0)
                {
                    result += n % 2;
                    n /= 2;
                }

                return result;
            }

            // Time complexity: O(n log n)
            // Space complexity: 0(n)
        }

        /// <inheritdoc/>
        public bool SameTree(TreeNode p, TreeNode q)
        {
            return DFS(p, q);

            bool DFS(TreeNode a, TreeNode b)
            {
                if (a is null && b is null)
                    return true;

                if (a?.val != b?.val)
                    return false;

                return DFS(a.left, b.left) && DFS(a.right, b.right);
            }

            // Time Complexity: O(max(p, q))
            // Space Complexity: O(max(p, q))
        }

        /// <inheritdoc/>
        public int HammingWeight(uint n)
        {
            uint result = 0;

            while (n > 0)
            {
                result += n % 2;
                n >>= 1;
            }

            return (int)result;

            // Time complexity: O(log n) = O(1)
            // Space complexity: O(1)
        }

        /// <inheritdoc/>
        public int ThreeSumSmaller(int[] nums, int target)
        {
            if (nums.Length < 3)
                return 0;

            var result = 0;
            Array.Sort(nums);

            var i = 0;
            var j = 1;
            var k = nums.Length - 1;

            while (i < nums.Length - 2)
            {
                var iValue = nums[i];

                while (j < k)
                {
                    var jValue = nums[j];
                    var kValue = nums[k];

                    if (iValue + jValue + kValue < target)
                    {
                        result += (k - j);
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }

                i++;
                j = i + 1;
                k = nums.Length - 1;
            }

            return result;

            // Time Complexity: O(n^2)
            // Space Complecity: O(1)
        }

        /// <inheritdoc/>
        public int ThreeSumClosest(int[] nums, int target)
        {
            var closestDifference = int.MaxValue;
            var closestSum = 0;

            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 2; i++)
            {
                var left = i + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    var difference = Math.Abs(sum - target);

                    if (difference == 0)
                        return sum;
                    if (difference < closestDifference)
                    {
                        closestDifference = difference;
                        closestSum = sum;
                    }

                    if (sum < target)
                        left++;
                    else
                        right--;
                }
            }

            return closestSum;

            // Time Complexity: O(n^2)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public IList<string> LetterCombinationsOfAPhoneNumber(string digits)
        {
            var dic = new Dictionary<char, char[]>()
            {
                {'2', new char[]{ 'a', 'b', 'c'} },
                {'3', new char[]{ 'd', 'e', 'f'} },
                {'4', new char[]{ 'g', 'h', 'i'} },
                {'5', new char[]{ 'j', 'k', 'l'} },
                {'6', new char[]{ 'm', 'n', 'o'} },
                {'7', new char[]{ 'p', 'q', 'r', 's'} },
                {'8', new char[]{ 't', 'u', 'v'} },
                {'9', new char[]{ 'w', 'x', 'y', 'z'} },
            };
            var result = new List<string>();

            if (string.IsNullOrWhiteSpace(digits))
                return result;

            foreach (var digit in digits)
            {
                result = Combination(result, digit);
            }

            result = result
                .Where(x => x.Length == digits.Length)
                .ToList();

            return result;

            List<string> Combination(List<string> combinations, char digit)
            {
                var newCombinations = new List<string>();

                if (combinations.Count == 0)
                {
                    foreach (var @char in dic[digit])
                        newCombinations.Add(@char.ToString());
                }
                else
                {
                    foreach (var combination in combinations)
                    {
                        foreach (var @char in dic[digit])
                            newCombinations.Add(combination + @char.ToString());
                    }
                }

                combinations.AddRange(newCombinations);

                return combinations;
            }

            // Time Complexity: O(4^n * n)
            // Space Complexity: O(n), the recursion.
        }

        /// <inheritdoc/>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            var result = string.Empty;

            for (var i = 0; i < strs[0].Length; i++)
            {
                for (var ii = 1; ii < strs.Length; ii++)
                {
                    if (strs[ii].Length <= i ||
                        strs[ii][i] != strs[0][i])
                        return result;
                }

                result += strs[0][i];
            }

            return result;

            // With n = number of words and m = max words length
            // Time Complexity: O(n * m)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public IList<int> BinaryTreeRightSideView(TreeNode root)
        {
            List<int> _dic = new();

            DFS(root, 0);

            return _dic;

            // n = number of nodes
            // Time Complexity: O(n)
            // Space Complexity: O(n)

            void DFS(TreeNode node, int level)
            {
                if (node is null)
                    return;

                if (_dic.Count() == level)
                    _dic.Add(node.val);

                DFS(node.right, level + 1);
                DFS(node.left, level + 1);
            }
        }

        /// <inheritdoc/>
        public int[][] KClosestPointsToOrigin(int[][] points, int k)
        {
            if (points.Length == 0)
                return null;

            var priorityQueue = new PriorityQueue<int[], int>();

            foreach (var point in points)
            {
                priorityQueue.Enqueue(point, (point[0] * point[0] + point[1] * point[1]) * -1);

                if (priorityQueue.Count > k)
                    priorityQueue.Dequeue();
            }

            var result = new int[k][];

            for (var i = 0; i < k; i++)
                result[i] = priorityQueue.Dequeue();

            return result;

            // Time Complexity: O(N log K)
            // Space Complexity: O(K)
        }

        /// <inheritdoc/>
        public IList<IList<int>> Subsets(int[] nums)
        {
            var allSubsets = new List<IList<int>>()
            {
                new List<int>()
            };

            foreach (var num in nums)
            {
                var newSubsets = new List<List<int>>();

                foreach (var currentSubset in allSubsets)
                {
                    var newSubset = new List<int>(currentSubset);
                    newSubset.Add(num);
                    newSubsets.Add(newSubset);
                }

                allSubsets.AddRange(newSubsets);
            }

            return allSubsets;

            // Time Complexity: O(N x 2^N)
            // Space Complexity: O(2^N)
        }

        /// <inheritdoc/>
        public bool PalindromeLinkedList(ListNode head)
        {
            if (head is null)
                return true;

            var fast = head;
            var slow = head;

            while (fast.next?.next is not null)
            {
                fast = fast.next?.next;
                slow = slow.next;
            }

            if (fast.next is not null)
                slow = slow.next;

            var reversedHead = ReverseList(slow);

            while (reversedHead is not null)
            {
                if (reversedHead.val != head.val)
                    return false;

                reversedHead = reversedHead.next;
                head = head.next;
            }

            return true;

            // Time Complexity: O(N)
            // Space Complexity: O(1)

            ListNode ReverseList(ListNode node)
            {
                ListNode prev = null;
                var curr = node;

                while (curr is not null)
                {
                    var temp = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = temp;
                }

                return prev;
            }
        }

        /// <inheritdoc/>
        public bool WordSearch(char[][] board, string word)
        {
            for (var i = 0; i < board.Length; i++)
                for (var ii = 0; ii < board[i].Length; ii++)
                {
                    if (DFS(board, word, i, ii, 0))
                        return true;
                }

            return false;

            // M = rows number, N = columns number, K = word length
            // Time Complexity: O(3^K x (M x N))
            // Space Complexity: O(3^K)

            bool DFS(char[][] board, string word, int row, int col, int index)
            {
                if (index >= word.Length)
                    return true;

                if (row < 0 ||
                    row >= board.Length ||
                    col < 0 ||
                    col >= board[row].Length ||
                    !board[row][col].Equals(word[index]))
                    return false;

                var temp = board[row][col];
                board[row][col] = '-';
                index++;

                var found = DFS(board, word, row + 1, col, index) ||
                            DFS(board, word, row - 1, col, index) ||
                            DFS(board, word, row, col + 1, index) ||
                            DFS(board, word, row, col - 1, index);

                board[row][col] = temp;

                return found;
            }
        }

        /// <inheritdoc/>
        public TreeNode ConstructBinaryTreeFromPreorderAndInorderTraversal(int[] preorder, int[] inorder)
        {
            var _preorderIndex = 0;
            var _dic = new Dictionary<int, int>();

            for (var i = 0; i < inorder.Length; i++)
                _dic.Add(inorder[i], i);

            return ArrayToTree(preorder, 0, preorder.Length - 1);

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            TreeNode ArrayToTree(int[] preorder, int left, int right)
            {
                if (left > right)
                    return null;

                var rootValue = preorder[_preorderIndex++];
                var root = new TreeNode(rootValue);

                root.left = ArrayToTree(preorder, left, _dic[rootValue] - 1);
                root.right = ArrayToTree(preorder, _dic[rootValue] + 1, right);

                return root;
            }
        }

        /// <inheritdoc/>
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var dic = new HashSet<string>();
            var queue = new Queue<int>();
            var seen = new bool[s.Length + 1];

            foreach (var word in wordDict)
                dic.Add(word);

            queue.Enqueue(0);

            while (queue.Count > 0)
            {
                var start = queue.Dequeue();

                if (start == s.Length)
                    return true;

                for (var end = start + 1; end <= s.Length; end++)
                {
                    if (seen[end])
                        continue;

                    if (dic.Contains(s[start..end]))
                    {
                        queue.Enqueue(end);
                        seen[end] = true;
                    }
                }
            }

            return false;

            // n = s,Length, m = wordDict.Length and k = average length of wordDict's words
            // Time Complexity: O(n^3)
            // Space Complexity: O(n + m * k), m * k to populate the dic
        }

        /// <inheritdoc/>
        public int MinimumLengthOfStringAfterDeletingSimilarEnds(string s)
        {
            if (s.Length == 1)
                return 1;

            var result = 0;
            var left = 0;
            var right = s.Length - 1;

            while (left < right && s[left] == s[right])
            {
                if (s[left + 1] == s[right])
                {
                    left++;
                    continue;
                }

                if (s[right - 1] == s[left])
                {
                    right--;
                    continue;
                }

                if (right - left == 2)
                    return 1;

                left++;
                right--;
            }

            result = right - left;

            return result > 0 ? result + 1 : result;

            // n = s.Length
            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int BagOfTokensScore(int[] tokens, int power)
        {
            var score = 0;
            var maxScore = 0;
            var left = 0;
            var right = tokens.Length - 1;

            Array.Sort(tokens);

            while (left <= right)
            {
                if (score == 0)
                {
                    if (power >= tokens[left])
                    {
                        power -= tokens[left];
                        score++;
                        left++;
                        maxScore = Math.Max(maxScore, score);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (power >= tokens[left])
                    {
                        power -= tokens[left];
                        score++;
                        left++;
                        maxScore = Math.Max(maxScore, score);
                    }
                    else
                    {
                        power += tokens[right];
                        right--;
                        score--;
                    }
                }
            }

            return maxScore;

            // n = tokens.Length
            // Time Complexity: O(n log n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int CountElementsWithMaximumFrequency(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var maximumFreq = 0;
            var result = 0;

            foreach (var num in nums)
            {
                dic.TryGetValue(num, out var freq);
                dic[num] = ++freq;

                if (freq == maximumFreq)
                {
                    result += freq;
                }
                else if (freq > maximumFreq)
                {
                    maximumFreq = freq;
                    result = freq;
                }
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public string CustomSortString(string order, string s)
        {
            var result = new StringBuilder();
            var dic = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                dic.TryGetValue(s[i], out var iValue);
                dic[s[i]] = iValue + 1;
            }

            foreach (var @char in order)
            {
                if (dic.TryGetValue(@char, out var charValue))
                {
                    result.Append(@char, charValue);
                    dic.Remove(@char);
                }
            }

            foreach (var (@char, charValue) in dic)
            {
                result.Append(@char, charValue);
            }

            return result.ToString();

            // n = Math.Max(order,Length, s.Length);
            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public ListNode RemoveZeroSumConsecutiveNodesFromLinkedList(ListNode head)
        {
            var result = new ListNode(0, head);
            var currentNode = result;
            var prefixSum = new Dictionary<int, ListNode>();
            var partialSum = 0;

            while (currentNode is not null)
            {
                partialSum += currentNode.val;

                if (prefixSum.TryGetValue(partialSum, out var partialSumNode))
                {
                    var current = partialSumNode.next;
                    var sum = partialSum + current.val;

                    while (sum != partialSum)
                    {
                        prefixSum.Remove(sum);
                        current = current.next;
                        sum += current.val;
                    }

                    partialSumNode.next = current.next;
                }
                else
                {
                    prefixSum.Add(partialSum, currentNode);
                }

                currentNode = currentNode.next;
            }

            return result.next;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int FindThePivotInteger(int n)
        {
            var counters = new int[n];
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var previousIndex = i > 2 ? i - 2 : 0;
                counters[i - 1] = counters[previousIndex] + i;
            }

            for (var i = n - 1; i >= 0; i--)
            {
                sum += i + 1;

                if (sum == counters[i])
                    return i + 1;
            }

            return -1;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int ContiguousArray(int[] nums)
        {
            var result = 0;
            var sum = 0;
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? -1 : 1;

                if (sum == 0)
                    result = Math.Max(result, i + 1);
                else if (dic.TryGetValue(sum, out var sumIndex))
                    result = Math.Max(result, i - sumIndex);
                else
                    dic.Add(sum, i);
            }

            return result;

            // Time Complexity: O(n)
            // Space Compelxity: O(n)
        }

        /// <inheritdoc/>
        public int SingleNumber(int[] nums)
        {
            var result = 0;

            foreach (var num in nums)
                result ^= num;

            return result;
        }

        /// <inheritdoc/>
        public int KthSmallestElementInABST(TreeNode root, int k)
        {
            var counter = 0;
            var result = DFS(root, new List<int>()).ToArray();

            if (!result.Any())
                return 0;

            return result[k - 1];

            List<int> DFS(TreeNode node, List<int> list)
            {
                if (node is null)
                    return list;

                DFS(node.left, list);

                list.Add(node.val);

                DFS(node.right, list);

                return list;
            }

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public ListNode MergeInBetweenLinkedLists(ListNode list1, int a, int b, ListNode list2)
        {
            var result = list1;

            var aNode = result;
            while (a > 1 && aNode.next is not null)
            {
                aNode = aNode.next;
                a--;
                b--;
            }

            var bNode = aNode;
            while (b >= 1 && bNode.next is not null)
            {
                bNode = bNode.next;
                b--;
            }

            aNode.next = list2;
            while (list2.next is not null)
                list2 = list2.next;
            list2.next = bNode.next;

            return result;

            // Time Complexity: O(a + b)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public void ReorderList(ListNode head)
        {
            if (head is null)
                return;

            var slow = head;
            var fast = head;

            // Midpoint
            while (fast is not null && fast.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reverse
            var current = slow;
            ListNode prev = null;
            while (current is not null)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            // Merge
            var leftSide = head;
            var rightSide = prev;
            while (rightSide.next is not null)
            {
                var temp = leftSide.next;
                leftSide.next = rightSide;
                leftSide = temp;

                temp = rightSide.next;
                rightSide.next = leftSide;
                rightSide = temp;
            }

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public IList<int> FindAllDuplicatesInAnArray(int[] nums)
        {
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (nums[Math.Abs(num) - 1] < 0)
                    result.Add(Math.Abs(num));
                else
                    nums[Math.Abs(num) - 1] *= -1;
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int FirstMissingPositive(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var idx = nums[i] - 1;

                if (num > 0 && num <= nums.Length && num != nums[idx])
                {
                    nums[i] = nums[idx];
                    nums[idx] = num;
                    i--;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return nums.Length + 1;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int SubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
                return 0;

            var result = 0;
            var left = 0;
            var right = 0;
            var currentProduct = 1;

            while (right < nums.Length)
            {
                currentProduct *= nums[right];

                while (currentProduct >= k)
                    currentProduct /= nums[left++];

                result += right - left + 1;
                right++;
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int LengthOfLongestSubarrayWithAtMostKFrequency(int[] nums, int k)
        {
            var result = 0;
            var left = 0;
            var freq = new Dictionary<int, int>();

            for (var right = 0; right < nums.Length; right++)
            {
                freq.TryGetValue(nums[right], out var rightFreq);
                freq[nums[right]] = ++rightFreq;

                while (freq[nums[right]] > k)
                {
                    freq.TryGetValue(nums[left], out var leftFreq);
                    freq[nums[left]] = --leftFreq;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public string RemoveVowelsFromAString(string s)
        {
            var sb = new StringBuilder();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (var @char in s)
            {
                if (!vowels.Contains(@char))
                    sb.Append(@char);
            }

            return sb.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public long CountSubarraysWhereMaxElementAppearsAtLeastKTimes(int[] nums, int k)
        {
            long result = 0;
            var max = nums.Max();
            var counter = 0;
            var start = 0;

            for (var end = 0; end < nums.Length; end++)
            {
                if (nums[end] == max)
                    counter++;

                while (counter == k)
                {
                    if (nums[start] == max)
                        counter--;

                    start++;
                }

                result += start;
            }

            return result;

            // Time Complexity: O(n)
            // Space Complecity: O(1)
        }

        /// <inheritdoc/>
        public int SubarraysWithKDifferentIntegers(int[] nums, int k)
        {
            return
                SlidingWindow(nums, k) -
                SlidingWindow(nums, k - 1);

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            int SlidingWindow(int[] nums, int k)
            {
                var freq = new Dictionary<int, int>();
                var left = 0;
                var right = 0;
                var result = 0;

                while (right < nums.Length)
                {
                    var rightNum = nums[right];

                    freq.TryGetValue(rightNum, out var rightCount);
                    freq[rightNum] = ++rightCount;

                    while (freq.Count > k)
                    {
                        // Shrink
                        var leftNum = nums[left];

                        freq.TryGetValue(leftNum, out var leftCount);
                        freq[leftNum] = --leftCount;

                        if (leftCount == 0)
                            freq.Remove(leftNum);

                        left++;
                    }

                    result += right - left + 1;
                    right++;
                }

                return result;
            }
        }

        /// <inheritdoc/>
        public int[] DailyTemperatures(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            var stack = new Stack<int>();

            stack.Push(0);

            for (var i = 1; i < temperatures.Length; i++)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
                {
                    var id = stack.Pop();
                    result[id] = i - id;
                }

                stack.Push(i);
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int LengthOfLastWord(string s)
        {
            var result = 0;

            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (result == 0)
                        continue;
                    else
                        return result;
                }
                else
                {
                    result++;
                }
            }

            return result;

            // Time complexity: O(n)
            // Space complexity: O(1)
        }

        /// <inheritdoc/>
        public void MoveZeroes(int[] nums)
        {
            var lastSwap = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];

                if (num != 0)
                {
                    // Swap
                    var temp = nums[lastSwap];
                    nums[lastSwap] = num;
                    nums[i] = temp;

                    lastSwap++;
                }
            }

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var dic = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var counters = new int[26];
                foreach (var @char in str)
                    counters[@char - 'a']++;

                var sb = new StringBuilder();
                for (var i = 0; i < 26; i++)
                    if (counters[i] > 0)
                        sb.Append((char)('a' + i), counters[i]);

                var key = sb.ToString();

                dic.TryGetValue(key, out var value);

                value ??= new List<string>();
                value.Add(str);

                dic[key] = value;
            }

            foreach ((var key, var value) in dic)
                result.Add(value);

            return result;

            // Time Complexity: O(nk)
            // Space Complexity: O(nk)
        }

        /// <inheritdoc/>
        public int FindTheDuplicateNumber(int[] nums)
        {
            var tortoise = nums[0];
            var hare = nums[0];

            do
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
            }
            while (tortoise != hare);

            tortoise = nums[0];

            while (tortoise != hare)
            {
                tortoise = nums[tortoise];
                hare = nums[hare];
            }

            return hare;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public string MakeTheStringGreat(string s)
        {
            if (s.Length < 2)
                return s;

            var stack = new Stack<int>();

            for (var i = 0; i < s.Length; i++)
            {
                var currentChar = (int)s[i];

                if (stack.Count > 0)
                {
                    var topStackChar = stack.Peek();
                    if (Math.Abs(currentChar - topStackChar) == 32)
                        stack.Pop();
                    else
                        stack.Push(currentChar);
                }
                else
                {
                    stack.Push(currentChar);
                }
            }

            var sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Insert(0, (char)stack.Pop());

            return sb.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public string MinimumRemoveToMakeValidParentheses(string s)
        {
            var sb = new StringBuilder();
            var indexes = new HashSet<int>();
            var stack = new Stack<(int index, char @char)>();

            for (var i = 0; i < s.Length; i++)
            {
                var @char = s[i];

                if (@char == '(')
                {
                    stack.Push((i, @char));
                }
                else if (@char == ')')
                {
                    if (stack.Count > 0 && stack.Peek().@char == '(')
                        stack.Pop();
                    else
                        stack.Push((i, @char));
                }
            }

            while (stack.Count > 0)
                indexes.Add(stack.Pop().index);

            for (var i = 0; i < s.Length; i++)
                if (!indexes.Contains(i))
                    sb.Append(s[i]);

            return sb.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public bool ValidParenthesisString(string s)
        {
            var stack = new Stack<(int index, char @char)>();
            for (var i = 0; i < s.Length; i++)
            {
                var @char = s[i];

                if (@char == '(')
                {
                    stack.Push((i, @char));
                }
                else if (@char == ')')
                {
                    if (stack.Count > 0 && stack.Peek().@char == '(')
                        stack.Pop();
                    else
                        stack.Push((i, @char));
                }
            }

            var indexes = new HashSet<int>();
            while (stack.Count > 0)
                indexes.Add(stack.Pop().index);

            var sb = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
                if (indexes.Contains(i) || s[i] == '*')
                    sb.Append(s[i]);

            indexes.Clear();
            s = sb.ToString();

            for (var i = 0; i < s.Length; i++)
            {
                var @char = s[i];
                var jollyFound = false;

                if (@char == '(')
                {
                    var j = i + 1;
                    while (j < s.Length)
                    {
                        if (s[j] == '*' && !indexes.Contains(j))
                        {
                            jollyFound = true;
                            indexes.Add(j);
                            break;
                        }
                        j++;
                    }
                }
                else if (@char == ')')
                {
                    var j = i - 1;
                    while (j >= 0)
                    {
                        if (s[j] == '*' && !indexes.Contains(j))
                        {
                            jollyFound = true;
                            indexes.Add(j);
                            break;
                        }
                        j--;
                    }
                }
                else
                {
                    continue;
                }

                if (!jollyFound)
                    return false;
            }

            return true;

            // Time Complexity: O(n^2)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int NumberOfStudentsUnableToEatLunch(int[] students, int[] sandwiches)
        {
            var studentsQ = new Queue<int>();
            var sandwichesS = new Stack<int>();
            var length = students.Length;
            var served = 0;

            for (var i = 0; i < length; i++)
            {
                studentsQ.Enqueue(students[i]);
                sandwichesS.Push(sandwiches[length - 1 - i]);
            }

            while (studentsQ.Count > 0 && studentsQ.Count > served)
            {
                if (studentsQ.Peek() == sandwichesS.Peek())
                {
                    studentsQ.Dequeue();
                    sandwichesS.Pop();
                    served = 0;
                }
                else
                {
                    studentsQ.Enqueue(studentsQ.Dequeue());
                    served++;
                }
            }

            return studentsQ.Count;

            // Time Complexity: O(n^2)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public ListNode SwapNodesInPairs(ListNode head)
        {
            if (head is null || head.next is null)
                return head;

            var dummy = new ListNode(next: head);

            ListNode prevNode = dummy;
            while (head is not null && head.next is not null)
            {
                var firstNode = head;
                var secondNode = head.next;

                // Swap
                prevNode.next = secondNode;
                firstNode.next = secondNode.next;
                secondNode.next = firstNode;

                prevNode = firstNode;
                head = firstNode.next;
            }

            return dummy.next;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int[] RevealCardsInIncreasingOrder(int[] deck)
        {
            if (deck.Length < 2)
                return deck;

            var result = new int[deck.Length];
            var deckIndex = 0;
            var resultIndex = 0;
            var skip = false;

            Array.Sort(deck);

            while (deckIndex < deck.Length)
            {
                if (result[resultIndex] == 0)
                {
                    if (!skip)
                    {
                        result[resultIndex] = deck[deckIndex];
                        deckIndex++;
                    }

                    skip = !skip;
                }

                resultIndex = (resultIndex + 1) % deck.Length;
            }

            return result;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public string RemoveKDigits(string num, int k)
        {
            if (num.Length == k)
                return "0";

            var result = new StringBuilder();

            foreach (var digit in num)
            {
                while (k > 0 &&
                        result.Length > 0 &&
                        result[result.Length - 1] > digit)
                {
                    result.Remove(result.Length - 1, 1);
                    k--;
                }

                result.Append(digit);
            }

            while (k > 0)
            {
                result.Remove(result.Length - 1, 1);
                k--;
            }

            while (result.Length > 1 &&
                    result[0] == '0')
            {
                result.Remove(0, 1);
            }

            return result.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int TimeNeededToBuyTickets(int[] tickets, int k)
        {
            var result = 0;

            for (var i = 0; i < tickets.Length; i++)
                result += Math.Min(tickets[i], i <= k ? tickets[k] : tickets[k] - 1);

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root is null)
                return 0;

            return DFS(root, false);

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            int DFS(TreeNode node, bool left)
            {
                if (node.left is null && node.right is null)
                    return left ? node.val : 0;

                var result = 0;
                if (node.right is not null)
                    result += DFS(node.right, false);

                if (node.left is not null)
                    result += DFS(node.left, true);

                return result;
            }
        }

        /// <inheritdoc/>
        public int SumRootToLeafNumbers(TreeNode root)
        {
            if (root is null)
                return 0;

            var result = 0;
            var queue = new Queue<(TreeNode node, int num)>();
            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                (var node, var num) = queue.Dequeue();
                num *= 10;

                if (node.left is null &&
                    node.right is null)
                {
                    result += (num + node.val);
                    continue;
                }

                if (node.left is not null)
                    queue.Enqueue((node.left, num + node.val));

                if (node.right is not null)
                    queue.Enqueue((node.right, num + node.val));
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(h), with h = tree's height
        }

        /// <inheritdoc/>
        public bool ValidSudoku(char[][] board)
        {
            var n = 9;

            // Validating rows
            for (var i = 0; i < n; i++)
            {
                var map = new HashSet<int>(n);

                for (var ii = 0; ii < n; ii++)
                {
                    if (board[i][ii] == '.')
                        continue;

                    if (map.Contains(board[i][ii]))
                        return false;
                    else
                        map.Add(board[i][ii]);
                }

                map.Clear();
            }

            // Validating columns
            for (var i = 0; i < n; i++)
            {
                var map = new HashSet<int>(n);

                for (var ii = 0; ii < n; ii++)
                {
                    if (board[ii][i] == '.')
                        continue;

                    if (map.Contains(board[ii][i]))
                        return false;
                    else
                        map.Add(board[ii][i]);
                }

                map.Clear();
            }

            // Validate boxes
            var row = 0;
            var col = 0;

            while (row < n && col < n)
            {
                var map = new HashSet<int>(n);

                for (var currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (var currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        if (board[currentRow][currentCol] == '.')
                            continue;

                        if (map.Contains(board[currentRow][currentCol]))
                            return false;
                        else
                            map.Add(board[currentRow][currentCol]);
                    }
                }

                if (row < 6)
                {
                    row += 3;
                }
                else
                {
                    row = 0;
                    col += 3;
                }
            }

            return true;

            // Not considering n = 9!
            // Time Complexity: O(n^2)
            // Space Complexity: O(n^2)
        }

        /// <inheritdoc/>
        public int LongestConsecutiveSequence(int[] nums)
        {
            var result = 0;
            var dic = new HashSet<int>(nums);

            foreach (var num in nums)
            {
                if (dic.Contains(num - 1))
                    continue;

                var streak = 1;

                while (dic.Contains(num + streak))
                    streak++;

                result = Math.Max(streak, result);
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int[][] FindAllGroupsOfFarmland(int[][] land)
        {
            var result = new List<int[]>();

            for (var row = 0; row < land.Length; row++)
                for (var col = 0; col < land[row].Length; col++)
                {
                    if (land[row][col] == 0)
                        continue;

                    result.Add(FindGroupBoundaries(land, row, col));
                }

            return result.ToArray();

            // Time Complexity: O(mn)
            // Space Complexity: O(mn)

            int[] FindGroupBoundaries(int[][] land, int row, int col)
            {
                int r2 = row;
                int c2 = col;

                // Bottom-right corner
                while (r2 < land.Length && land[r2][col] == 1)
                    r2++;

                while (c2 < land[0].Length && land[row][c2] == 1)
                    c2++;

                for (var i = row; i < r2; i++)
                {
                    for (var j = col; j < c2; j++)
                    {
                        land[i][j] = 0;
                    }
                }

                return new int[] { row, col, r2 - 1, c2 - 1 };
            }
        }

        /// <inheritdoc/>
        public int TrappingRainWater(int[] height)
        {
            var result = 0;

            var left = 0;
            var right = height.Length - 1;

            var leftMax = 0;
            var rightMax = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        result += leftMax - height[left];

                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        result += rightMax - height[right];

                    right--;
                }
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int RomanToInteger(string s)
        {
            var result = 0;
            var symbols = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            for (var i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    if (symbols[s[i]] >= symbols[s[i + 1]])
                        result += symbols[s[i]];
                    else
                    {
                        result += symbols[s[i + 1]] - symbols[s[i]];
                        i++;
                    }
                }
                else
                {
                    result += symbols[s[i]];
                }
            }

            return result;

            // Time Complexity: O(n), considering n = s.Length;
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public string IntegerToRoman(int num)
        {
            var result = new StringBuilder();
            var values = new int[13] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var symbols = new string[13] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (var i = 0; i < values.Length && num > 0; i++)
            {
                while (values[i] <= num)
                {
                    num -= values[i];
                    result.Append(symbols[i]);
                }
            }

            return result.ToString();

            // Time Complexity: O(1)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public bool SearchA2DMatrix(int[][] matrix, int target)
        {
            var row = matrix.Length;
            if (row == 0)
                return false;

            var col = matrix[0].Length;

            var left = 0;
            var right = row * col - 1;

            while (left <= right)
            {
                var midIndex = (left + right) / 2;
                var midValue = matrix[midIndex / col][midIndex % col];

                if (target == midValue)
                    return true;
                else
                {
                    if (target < midValue)
                        right = midIndex - 1;
                    else
                        left = midIndex + 1;
                }
            }

            return false;

            // Time Complexity: 0(log(mn))
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int LargestPositiveIntegerThatExistsWithItsNegative(int[] nums)
        {
            Array.Sort(nums);

            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var leftValue = nums[left];
                var rightValue = nums[right];

                if (leftValue > 0 || rightValue < 0)
                    break;

                leftValue = Math.Abs(leftValue);

                if (leftValue > rightValue)
                    left++;
                else if (leftValue < rightValue)
                    right--;
                else
                    return leftValue;
            }

            return -1;

            // Time Complexity: O(n log n), depending on sort implementation.
            // Space Complexity: O(log n), depending on sort implementation.
        }

        /// <inheritdoc/>
        public long CountPairsInTwoArrays(int[] nums1, int[] nums2)
        {
            long result = 0;
            var differences = new long[nums1.Length];

            for (var i = 0; i < nums1.Length; i++)
                differences[i] = nums1[i] - nums2[i];

            Array.Sort(differences);

            for (var i = 0; i < nums1.Length; i++)
            {
                if (differences[i] > 0)
                {
                    result += nums1.Length - i - 1;
                }
                else
                {
                    var left = i + 1;
                    var right = nums1.Length - 1;

                    while (left <= right)
                    {
                        var mid = left + (right - left) / 2;

                        if (differences[i] + differences[mid] > 0)
                            right = mid - 1;
                        else
                            left = mid + 1;
                    }

                    result += nums1.Length - left;
                }
            }

            return result;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int BoatsToSavePeople(int[] people, int limit)
        {
            Array.Sort(people);

            var result = 0;
            var left = 0;
            var right = people.Length - 1;

            while (left <= right)
            {
                if (people[right] + people[left] <= limit)
                    left++;

                result++;
                right--;
            }

            return result;

            // Time Complexity: O(n log n), depending on sort method
            // Space Complexity: O(n), depending on sort method
        }

        /// <inheritdoc/>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);

            return KSum(nums, target, 0, 4);

            IList<IList<int>> KSum(int[] nums, long target, int start, int k)
            {
                var result = new List<IList<int>>();

                if (start == nums.Length)
                    return result;

                long average_value = target / k;
                if (nums[start] > average_value ||
                    average_value > nums[nums.Length - 1])
                    return result;

                if (k == 2)
                    return TwoSum(nums, target, start);

                for (int i = start; i < nums.Length; i++)
                {
                    if (i > start && nums[i - 1] == nums[i])
                        continue;

                    foreach (var subset in KSum(nums, target - nums[i], i + 1, k - 1))
                    {
                        var list = new List<int>() { nums[i] };
                        list.AddRange(subset);
                        result.Add(list);
                    }
                }

                return result;
            }

            IList<IList<int>> TwoSum(int[] nums, long target, int start)
            {
                var result = new List<IList<int>>();

                int currentStart = start;
                var currentEnd = nums.Length - 1;

                while (currentStart < currentEnd)
                {
                    if (currentStart > start &&
                        nums[currentStart - 1] == nums[currentStart])
                    {
                        currentStart++;
                        continue;
                    }

                    if (currentEnd < nums.Length - 1 &&
                        nums[currentEnd + 1] == nums[currentEnd])
                    {
                        currentEnd--;
                        continue;
                    }

                    int complement = nums[currentStart] + nums[currentEnd];
                    if (complement < target)
                        ++currentStart;
                    else if (complement > target)
                        --currentEnd;
                    else
                        result.Add(new List<int> { nums[currentStart++], nums[currentEnd--] });
                }

                return result;
            }
        }

        /// <inheritdoc/>
        public void RotateArray(int[] nums, int k)
        {
            var temp = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
                temp[(i + k) % nums.Length] = nums[i];

            for (var i = 0; i < nums.Length; i++)
                nums[i] = temp[i];

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public long MaximizeHappinessOfSelectedChildren(int[] happiness, int k)
        {
            long result = 0;

            Array.Sort(happiness);

            for (var i = 1; i <= k; i++)
            {
                var value = happiness[happiness.Length - i] - i + 1;

                if (value > 0)
                    result += value;
            }

            return result;

            // Time Complexity: O(n log n), depending on sort implementation
            // Space Complexity: O(n), depending on sort implementation
        }

        /// <inheritdoc/>
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            Backtracking(result, "(", 1, 0, n);

            return result;

            void Backtracking(List<string> result, string currentCombination, int open, int closed, int n)
            {
                if (open == closed && open == n)
                {
                    result.Add(currentCombination);
                    return;
                }

                if (open < n)
                    Backtracking(result, currentCombination + "(", open + 1, closed, n);

                if (open > closed)
                    Backtracking(result, currentCombination + ")", open, closed + 1, n);
            }
        }

        /// <inheritdoc/>
        public int SingleElementInASortedArray(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (mid + 1 < nums.Length && nums[mid] == nums[mid + 1])
                {
                    if ((nums.Length - mid) % 2 == 1)
                        left = mid + 2;
                    else
                        right = mid - 1;
                }
                else if (mid - 1 >= 0 && nums[mid] == nums[mid - 1])
                {
                    if ((mid - 1) % 2 == 1)
                        right = mid - 2;
                    else
                        left = mid + 1;
                }
                else
                {
                    return nums[mid];
                }
            }

            return 0;

            // Time Complexity: O(log n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var stack = new Stack<double>();

            Array.Sort(position, speed);

            for (int i = 0; i < position.Length; i++)
            {
                var car = (double)(target - position[i]) / speed[i];

                while (stack.Any() && car >= stack.Peek())
                    stack.Pop();

                stack.Push(car);
            }

            return stack.Count();

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int[] NextGreaterElementI(int[] nums1, int[] nums2)
        {
            var dic = new Dictionary<int, int>();
            var stack = new Stack<int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                var num = nums2[i];

                while (stack.Count > 0 && stack.Peek() < num)
                    dic[stack.Pop()] = num;

                stack.Push(num);
                dic[num] = -1;
            }

            var result = new int[nums1.Length];

            for (var i = 0; i < nums1.Length; i++)
                result[i] = dic[nums1[i]];

            return result;

            // n = nums2.Length
            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public ListNode RemoveLinkedListElements(ListNode head, int val)
        {
            while (head is not null && head.val == val)
                head = head.next;

            if (head is null)
                return head;

            var current = head;
            while (current.next is not null)
            {
                if (current.next.val == val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }

            return head;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int MaximumTwinSumOfALinkedList(ListNode head)
        {
            var result = 0;

            if (head is null)
                return result;

            // Midpoint
            var slow = head;
            var fast = head;
            while (fast?.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // Reversing
            var reversed = slow;
            ListNode prev = null;
            while (reversed is not null)
            {
                var temp = reversed.next;
                reversed.next = prev;
                prev = reversed;
                reversed = temp;
            }

            // Computing result
            while (head is not null && prev is not null)
            {
                result = Math.Max(head.val + prev.val, result);

                head = head.next;
                prev = prev.next;
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public ListNode SwappingNodesInALinkedList(ListNode head, int k)
        {
            var first = head;
            var second = head;
            ListNode toBeSwapped = null;

            while (first is not null)
            {
                if (k == 1)
                    // This is the Kth node
                    toBeSwapped = first;

                first = first.next;
                k--;

                if (k < 0)
                    // This is the List.Length - Kth node
                    second = second.next;
            }

            var temp = toBeSwapped.val;
            toBeSwapped.val = second.val;
            second.val = temp;

            return head;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public ListNodeWithRandom CopyListWithRandomPointer(ListNodeWithRandom head)
        {

            if (head is null)
                return null;

            var dic = new Dictionary<ListNodeWithRandom, ListNodeWithRandom>();

            var oldNode = head;
            var newNode = new ListNodeWithRandom(oldNode.val);

            dic[oldNode] = newNode;

            while (oldNode is not null)
            {
                newNode.next = GetNode(oldNode.next);
                newNode.random = GetNode(oldNode.random);

                oldNode = oldNode.next;
                newNode = newNode.next;
            }

            ListNodeWithRandom GetNode(ListNodeWithRandom node)
            {
                if (node is null)
                    return null;

                if (dic.TryGetValue(node, out var oldNode))
                {
                    return oldNode;
                }
                else
                {
                    var newNode = new ListNodeWithRandom(node.val);
                    dic[node] = newNode;
                    return newNode;
                }
            }

            return dic[head];

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public TreeNode InsertIntoABinarySearchTree(TreeNode root, int val)
        {
            if (root is null)
                return new TreeNode(val);

            if (val < root.val)
                root.left = InsertIntoABinarySearchTree(root.left, val);

            else if (val > root.val)
                root.right = InsertIntoABinarySearchTree(root.right, val);

            return root;
        }

        /// <inheritdoc/>
        public TreeNode DeleteNodeInABST(TreeNode root, int key)
        {
            if (root is null)
                return null;

            if (key < root.val)
                root.left = DeleteNodeInABST(root.left, key);
            else if (key > root.val)
                root.right = DeleteNodeInABST(root.right, key);
            else
            {
                if (root.left is null)
                    return root.right;
                else if (root.right is null)
                    return root.left;

                var successor = InOrderSuccessor(root.right);
                root.val = successor.val;
                root.right = DeleteNodeInABST(root.right, root.val);
            }

            return root;

            // Time Complexity: O(log n)
            // Space Complexity: O(log n)

            TreeNode InOrderSuccessor(TreeNode node)
            {
                var successor = node;

                while (successor.left is not null)
                    successor = successor.left;

                return successor;
            }
        }

        /// <inheritdoc/>
        public int MinimumTimeToCollectAllApplesInATree(int n, int[][] edges, IList<bool> hasApple)
        {
            var dic = new Dictionary<int, List<int>>();

            foreach (var edge in edges)
            {
                int a = edge[0];
                int b = edge[1];

                if (!dic.ContainsKey(a))
                    dic[a] = new List<int>();

                if (!dic.ContainsKey(b))
                    dic[b] = new List<int>();

                dic[a].Add(b);
                dic[b].Add(a);
            }

            return Dfs(0, -1, dic, hasApple);

            int Dfs(int node, int parent, Dictionary<int, List<int>> dic, IList<bool> hasApple)
            {
                if (!dic.ContainsKey(node))
                    return 0; // Leaf node

                var totalTime = 0;

                foreach (var child in dic[node])
                {
                    if (child == parent)
                        continue;

                    var childTime = Dfs(child, node, dic, hasApple);

                    if (childTime > 0 || hasApple[child])
                        totalTime += childTime + 2;
                }

                return totalTime;
            }
        }

        /// <inheritdoc/>
        public IList<IList<int>> BinaryTreeZigzagLevelOrderTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root is null)
                return result;

            var left = false;
            var mainStack = new Stack<TreeNode>();
            var tempStack = new Stack<TreeNode>();

            tempStack.Push(root);

            while (tempStack.Count > 0)
            {
                mainStack = tempStack;
                tempStack = new Stack<TreeNode>();

                var level = new List<int>();

                while (mainStack.Count > 0)
                {
                    var node = mainStack.Pop();
                    level.Add(node.val);

                    if (left)
                    {
                        if (node.right is not null) tempStack.Push(node.right);
                        if (node.left is not null) tempStack.Push(node.left);
                    }
                    else
                    {
                        if (node.left is not null) tempStack.Push(node.left);
                        if (node.right is not null) tempStack.Push(node.right);
                    }
                }

                left = !left;

                result.Add(level);
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            var result = new List<TreeNode>();
            var dic = new Dictionary<string, int>(10);

            Dfs(root);

            return result;

            // Time Complexity: O(n^2)
            // Space Complexity: O(n^2)

            string Dfs(TreeNode node)
            {
                if (node is null)
                    return "-";

                var currentPath = $"{node.val},{Dfs(node.left)},{Dfs(node.right)}";

                if (!dic.TryGetValue(currentPath, out var currentPathCount))
                {
                    dic.Add(currentPath, 1);
                }
                else
                {
                    if (currentPathCount == 1)
                    {
                        result.Add(node);
                        dic[currentPath]++;
                    }
                }

                return currentPath;
            }
        }

        /// <inheritdoc/>
        public bool CheckCompletenessOfABinaryTree(TreeNode root)
        {
            if (root is null)
                return true;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var nullNodeFound = false;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node is null)
                {
                    nullNodeFound = true;
                }
                else
                {
                    if (nullNodeFound)
                        return false;

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            return true;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public TreeNode ConstructBinaryTreeFromInorderAndPostorderTraversal(int[] inorder, int[] postorder)
        {
            var rightMostElement = postorder.Length - 1;
            var indexes = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
                indexes[inorder[i]] = i;

            return Helper(0, postorder.Length - 1, inorder, postorder);

            TreeNode Helper(int leftIndex, int rightIndex, int[] inorder, int[] postorder)
            {
                if (leftIndex > rightIndex)
                    return null;

                var nodeValue = postorder[rightMostElement];
                var nodeIndex = indexes[nodeValue];
                var node = new TreeNode(nodeValue);

                rightMostElement--;

                node.right = Helper(nodeIndex + 1, rightIndex, inorder, postorder);
                node.left = Helper(leftIndex, nodeIndex - 1, inorder, postorder);

                return node;
            }
        }

        /// <inheritdoc/>
        public bool SymmetricTree(TreeNode root)
        {
            var result = true;

            if (root is null)
                return result;

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var leftNode = queue.Dequeue();
                var rightNode = queue.Dequeue();

                if (leftNode is null && rightNode is null)
                    continue;

                if (leftNode is null || rightNode is null)
                    return false;

                if (leftNode.val != rightNode.val)
                    return false;

                queue.Enqueue(leftNode.left);
                queue.Enqueue(rightNode.right);
                queue.Enqueue(leftNode.right);
                queue.Enqueue(rightNode.left);
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int CountGoodNodesInBinaryTree(TreeNode root)
        {
            var result = 0;

            if (root is null)
                return result;

            Dfs(root, root.val);

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            void Dfs(TreeNode node, int max)
            {
                if (node is null)
                    return;

                if (node.val >= max)
                    result++;

                max = Math.Max(node.val, max);

                Dfs(node.left, max);
                Dfs(node.right, max);
            }
        }

        /// <inheritdoc/>
        public int LastStoneWeight(int[] stones)
        {
            var queue = new PriorityQueue<int, int>();

            foreach (var stone in stones)
                queue.Enqueue(stone, -stone);

            while (queue.Count > 1)
            {
                var stone1 = -queue.Dequeue();
                var stone2 = -queue.Dequeue();
                var diff = Math.Abs(stone1 - stone2);

                if (diff > 0)
                    queue.Enqueue(diff, -diff);
            }

            if (queue.Count > 0)
                return queue.Peek();

            return 0;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int LeastNumberOfUniqueIntegersAfterKRemovals(int[] arr, int k)
        {
            var dic = new Dictionary<int, int>();
            var elements = new HashSet<int>();
            var queue = new PriorityQueue<int, int>();

            foreach (var num in arr)
            {
                dic.TryGetValue(num, out var value);
                dic[num] = value + 1;
            }

            foreach (var num in arr)
            {
                if (elements.Contains(num))
                    continue;

                queue.Enqueue(num, dic[num]);
                elements.Add(num);
            }

            while (k > 0)
                k -= dic[queue.Dequeue()];

            if (k < 0)
                return queue.Count + 1;

            return queue.Count;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int FurthestBuildingYouCanReach(int[] heights, int bricks, int ladders)
        {
            var result = 0;
            var queue = new PriorityQueue<int, int>();

            for (var i = 1; i < heights.Length; i++)
            {
                var difference = heights[i] - heights[i - 1];

                if (difference <= 0)
                {
                    result++;
                    continue;
                }

                if (ladders > 0)
                {
                    queue.Enqueue(difference, difference);

                    ladders--;
                    result++;
                }
                else
                {
                    if (queue.Count > 0)
                    {
                        var lastLadderHeightDifference = queue.Peek();

                        if (lastLadderHeightDifference < difference &&
                            bricks >= lastLadderHeightDifference)
                        {
                            queue.DequeueEnqueue(difference, difference);

                            bricks -= lastLadderHeightDifference;
                            result++;

                            continue;
                        }
                    }

                    if (bricks >= difference)
                    {
                        bricks -= difference;
                        result++;
                    }
                    else
                    {
                        return result;
                    }
                }

            }

            return result;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int[] IntersectionOfTwoArraysII(int[] nums1, int[] nums2)
        {
            var result = new List<int>();
            var dic = new Dictionary<int, int>();

            foreach (var num in nums1)
            {
                dic.TryGetValue(num, out var value);
                dic[num] = ++value;
            }

            foreach (var num in nums2)
            {
                if (dic.TryGetValue(num, out var value))
                {
                    result.Add(num);

                    dic[num] = --value;

                    if (value == 0)
                        dic.Remove(num);
                }
            }

            return result.ToArray();

            // Time Complexity: O(n)
            // Space Complexity: O(min(n, m))
        }

        /// <inheritdoc/>
        public int MinimumDifferenceBetweenLargestAndSmallestValueInThreeMoves(int[] nums)
        {
            if (nums.Length < 4)
                return 0;

            Array.Sort(nums);

            var minDiff = int.MaxValue;

            for (int left = 0, right = nums.Length - 4; left < 4; left++, right++)
                minDiff = Math.Min(minDiff, nums[right] - nums[left]);

            return minDiff;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int[] FindTheMinimumAndMaximumNumberOfNodesBetweenCriticalPoints(ListNode head)
        {
            var minDistance = int.MaxValue;
            var previousNode = head;
            var currentNode = head.next;
            var index = 1;
            var previousCriticalIndex = 0;
            var firstCriticalIndex = 0;

            while (currentNode.next != null)
            {
                if ((currentNode.val < previousNode.val && currentNode.val < currentNode.next.val) ||
                    (currentNode.val > previousNode.val && currentNode.val > currentNode.next.val))
                {
                    if (previousCriticalIndex == 0)
                    {
                        previousCriticalIndex = index;
                        firstCriticalIndex = index;
                    }
                    else
                    {
                        minDistance = Math.Min(minDistance, index - previousCriticalIndex);
                        previousCriticalIndex = index;
                    }
                }

                previousNode = currentNode;
                currentNode = currentNode.next;

                index++;
            }

            if (minDistance != int.MaxValue)
                return new int[] { minDistance, previousCriticalIndex - firstCriticalIndex };

            return new int[] { -1, -1 };

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int PassThePillow(int n, int time)
        {
            var direction = time / (n - 1);
            var personIndex = time % (n - 1);

            if (direction % 2 == 0)
                return personIndex + 1;
            else
                return n - personIndex;

            // Time Complexity: O(1)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int WaterBottles(int numBottles, int numExchange)
        {
            var result = 0;
            var fullBottles = numBottles;
            var emptyBottles = 0;

            while (fullBottles > 0)
            {
                result += fullBottles;

                var temp = fullBottles;
                fullBottles = (fullBottles + emptyBottles) / numExchange;
                emptyBottles = (temp + emptyBottles) % numExchange;
            }

            return result;

            // Time Complexity: O(log n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int FindTheWinnerOfTheCircularGame(int n, int k)
        {
            var queue = new Queue<int>();

            for (var i = 1; i <= n; i++)
                queue.Enqueue(i);

            while (queue.Count > 1)
            {
                var localK = k;

                while (localK > 1)
                {
                    queue.Enqueue(queue.Dequeue());
                    localK--;
                }

                queue.Dequeue();
            }

            return queue.Peek();

            // Time Complexity: O(nk)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public double AverageWaitingTime(int[][] customers)
        {
            double result = 0;
            var currentTime = customers[0][0];

            foreach (var customer in customers)
            {
                var arrival = customer[0];
                var time = customer[1];

                if (currentTime >= arrival)
                {
                    result += currentTime - arrival + time;
                    currentTime += time;
                }
                else
                {
                    result += time;
                    currentTime += arrival - currentTime + time;
                }
            }

            return result / customers.Length;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int CrawlerLogFolder(string[] logs)
        {
            var result = 0;

            foreach (var log in logs)
            {
                if (log.Equals("../"))
                {
                    if (result > 0)
                        result--;
                }
                else if (!log.Equals("./"))
                {
                    result++;
                }
            }

            return result;

            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        public string ReverseSubstringsBetweenEachPairOfParentheses(string s)
        {
            var result = new StringBuilder();
            var stack = new Stack<int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('(') ||
                    s[i].Equals('[') ||
                    s[i].Equals('{'))
                {
                    stack.Push(result.Length);

                    continue;
                }

                if (s[i].Equals(')') ||
                    s[i].Equals(']') ||
                    s[i].Equals('}'))
                {
                    var start = stack.Pop();

                    Reverse(result, start, result.Length - 1);

                    continue;
                }

                result.Append(s[i]);
            }

            return result.ToString();

            void Reverse(StringBuilder result, int start, int end)
            {
                while (start < end)
                {
                    var temp = result[start];
                    result[start] = result[end];
                    result[end] = temp;

                    start++;
                    end--;
                }
            }

            // Time Complexity: O(nˆ2)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public IList<int> RobotCollisions(int[] positions, int[] healths, string directions)
        {
            var result = new List<int>();
            var robots = new List<Robot>();
            var robotsStack = new Stack<Robot>();

            for (var i = 0; i < positions.Length; i++)
            {
                robots.Add(new Robot()
                {
                    Id = i,
                    Position = positions[i],
                    Health = healths[i],
                    Direction = directions[i]
                });
            }

            var sortedRobots = robots
                .OrderBy(x => x.Position)
                .ToList();

            foreach (var robot in sortedRobots)
            {
                if (robot.Direction.Equals('R'))
                {
                    robotsStack.Push(robot);
                    continue;
                }

                while (robotsStack.Count > 0)
                {
                    var previousRobot = robotsStack.Peek();

                    if (previousRobot.Health > robot.Health)
                    {
                        previousRobot.Health--;
                        robot.Health = 0;

                        break;
                    }
                    else if (previousRobot.Health == robot.Health)
                    {
                        previousRobot.Health = 0;
                        robot.Health = 0;
                        robotsStack.Pop();

                        break;
                    }
                    else
                    {
                        robotsStack.Pop();
                        previousRobot.Health = 0;
                        robot.Health--;
                    }
                }
            }

            foreach (var robot in robots)
                if (robot.Health > 0)
                    result.Add(robot.Health);

            return result;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public TreeNode CreateBinaryTreeFromDescriptions(int[][] descriptions)
        {
            var seen = new HashSet<int>();
            var dic = new Dictionary<int, TreeNode>();

            foreach (var description in descriptions)
            {
                var parentValue = description[0];
                var childValue = description[1];
                var isLeft = description[2] == 1;

                dic.TryGetValue(parentValue, out var parentNode);
                dic.TryGetValue(childValue, out var childNode);

                parentNode ??= new TreeNode(parentValue);
                childNode ??= new TreeNode(childValue);

                if (isLeft)
                    parentNode.left = childNode;
                else
                    parentNode.right = childNode;

                dic[parentValue] = parentNode;
                dic[childValue] = childNode;

                seen.Add(childValue);
            }

            foreach (var description in descriptions)
                if (!seen.Contains(description[0]))
                    return dic[description[0]];

            return null;

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public string StepByStepDirectionsFromABinaryTreeNodeToAnother(TreeNode root, int startValue, int destValue)
        {
            var lca = LCA(root, startValue, destValue);

            var startPath = new StringBuilder();
            var destPath = new StringBuilder();
            var directions = new StringBuilder();

            GetPath(lca, startValue, startPath);
            GetPath(lca, destValue, destPath);

            directions.Append(new string('U', startPath.Length));
            directions.Append(destPath);

            return directions.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(n)

            TreeNode LCA(TreeNode node, int value1, int value2)
            {
                if (node is null)
                    return null;

                if (node.val == value1 || node.val == value2)
                    return node;

                var leftSubtree = LCA(node.left, value1, value2);
                var rightSubtree = LCA(node.right, value1, value2);

                if (leftSubtree is null)
                    return rightSubtree;
                else if (rightSubtree is null)
                    return leftSubtree;
                else
                    return node;
            }

            bool GetPath(TreeNode node, int value, StringBuilder path)
            {
                if (node is null)
                    return false;

                if (node.val == value)
                    return true;

                path.Append("L");
                if (GetPath(node.left, value, path))
                    return true;
                path.Length = path.Length - 1;

                path.Append("R");
                if (GetPath(node.right, value, path))
                    return true;
                path.Length = path.Length - 1;

                return false;
            }
        }

        /// <inheritdoc/>
        public int[] SortTheJumbledNumbers(int[] mapping, int[] nums)
        {
            var resultMap = new int[nums.Length];

            for (var i = 0; i < nums.Length; i++)
            {
                var numString = nums[i].ToString();
                var mappedNum = 0;

                for (var ii = 0; ii < numString.Length; ii++)
                    mappedNum += ((int)Math.Pow(10, numString.Length - 1 - ii) * mapping[numString[ii] - '0']);

                resultMap[i] = mappedNum;
            }

            Array.Sort(resultMap, nums);

            return nums;

            // Time Complexity: O(n log n)
            // Space Complexity: O(n)
        }

        /// <inheritdoc/>
        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
                for (var ii = 0; ii < grid[0].Length; ii++)
                {
                    if (grid[i][ii] == 1)
                    {
                        // Up
                        if (i - 1 < 0 || grid[i - 1][ii] == 0)
                            result++;

                        // Down
                        if (i + 1 >= grid.Length || grid[i + 1][ii] == 0)
                            result++;

                        // Left
                        if (ii - 1 < 0 || grid[i][ii - 1] == 0)
                            result++;

                        // Right
                        if (ii + 1 >= grid[0].Length || grid[i][ii + 1] == 0)
                            result++;
                    }
                }

            return result;

            // m = grid rows, n = grid columns
            // Time Complexity: O(m x n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public bool VerifyingAnAlienDictionary(string[] words, string order)
        {
            if (words.Length <= 1)
                return true;

            var dic = new Dictionary<char, int>();

            for (var i = 0; i < order.Length; i++)
                dic.Add(order[i], i);

            for (var i = 1; i < words.Length; i++)
            {
                var precedingWord = words[i - 1];
                var currentWord = words[i];

                if (IsPreceding(precedingWord, currentWord, dic) == false)
                    return false;
            }

            return true;

            // N = total number of characters in words
            // Time Complexity: O(N)
            // Space Complexity: O(1)

            bool IsPreceding(string precedingWord, string nextWord, Dictionary<char, int> order)
            {
                for (var i = 0; i < precedingWord.Length; i++)
                {
                    if (nextWord.Length > i)
                    {
                        var precedingWordChar = precedingWord[i];
                        var nextWordChar = nextWord[i];

                        if (precedingWordChar == nextWordChar)
                            continue;

                        if (order[precedingWordChar] > order[nextWordChar])
                            return false;
                        else
                            return true;
                    }

                    return false;
                }

                return true;
            }
        }

        /// <inheritdoc/>
        public int FindTheTownJudge(int n, int[][] trust)
        {
            var people = new int[n];

            foreach (var couple in trust)
            {
                people[couple[1] - 1]++;
                people[couple[0] - 1]--;
            }

            for (var i = 0; i < n; i++)
                if (people[i] == n - 1)
                    return i + 1;

            return -1;

            // n = trust.Length;
            // Time Complexity: O(n)
            // Space Complexity: O(1)
        }

        /// <inheritdoc/>
        public int MaxAreaOfIsland(int[][] grid)
        {
            var maxSize = 0;
            var directions = new List<(int Row, int Column)>()
        {
            (1, 0),     // right
            (-1, 0),    // left
            (0, 1),     // up
            (0, -1),    // down    
        };

            for (var row = 0; row < grid.Length; row++)
                for (var column = 0; column < grid[row].Length; column++)
                {
                    if (grid[row][column] == 0)
                        continue;

                    var currentSize = 0;
                    var queue = new Queue<(int Row, int Column)>();
                    queue.Enqueue((row, column));
                    grid[row][column] = 0;

                    while (queue.Count > 0)
                    {
                        var (currentRow, currentColumn) = queue.Dequeue();
                        currentSize++;

                        foreach (var direction in directions)
                        {
                            var nextRow = currentRow + direction.Row;
                            var nextColumn = currentColumn + direction.Column;

                            if (
                                nextRow >= 0 &&
                                nextColumn >= 0 &&
                                nextRow < grid.Length &&
                                nextColumn < grid[row].Length &&
                                grid[nextRow][nextColumn] == 1
                            )
                            {
                                queue.Enqueue((nextRow, nextColumn));

                                grid[nextRow][nextColumn] = 0;
                            }
                        }
                    }

                    maxSize = Math.Max(maxSize, currentSize);
                }

            return maxSize;

            // M = number of rows
            // N = number of columns
            // Time Complexity: O(M x N)
            // Space Complexity: O(M x N)
        }

        /// <inheritdoc/>
        public void WallsAndGates(int[][] rooms)
        {
            const int EMPTY = 2147483647;
            const int GATE = 0;

            var queue = new Queue<(int Row, int Column)>();
            var directions = new List<(int Row, int Column)>()
            {
                (1, 0), // up
                (-1, 0),// down
                (0, 1), // right
                (0, -1),// left
            };

            for (var row = 0; row < rooms.Length; row++)
                for (var column = 0; column < rooms[row].Length; column++)
                    if (rooms[row][column] == GATE)
                        queue.Enqueue((row, column));

            while (queue.Count > 0)
            {
                var (roomRow, roomColumn) = queue.Dequeue();

                foreach (var direction in directions)
                {
                    var currentRow = roomRow + direction.Row;
                    var currentColumn = roomColumn + direction.Column;

                    if (
                        currentRow >= 0 &&
                        currentColumn >= 0 &&
                        currentRow < rooms.Length &&
                        currentColumn < rooms[0].Length &&
                        rooms[currentRow][currentColumn] == EMPTY
                    )
                    {
                        rooms[currentRow][currentColumn] = rooms[roomRow][roomColumn] + 1;
                        queue.Enqueue((currentRow, currentColumn));
                    }
                }
            }

            // Time Complexity: O(M x N)
            // Space Complexity: O(M x N)
        }

        /// <inheritdoc/>
        public IList<IList<int>> PacificAtlanticWaterFlow(int[][] heights)
        {
            var pacificCells = new HashSet<(int, int)>();
            var atlanticCells = new HashSet<(int, int)>();
            var directions = new List<(int Row, int Col)>()
            {
                (1, 0),
                (-1, 0),
                (0, 1),
                (0, -1)
            };

            var rows = heights.Length;
            var columns = heights[0].Length;

            var result = new List<IList<int>>();

            // Pacific cells
            for (var i = 0; i < columns; i++)
                DFS(heights, 0, i, true);
            for (var i = 0; i < rows; i++)
                DFS(heights, i, 0, true);

            // Atlantic cells
            for (var i = 0; i < rows; i++)
                DFS(heights, i, columns - 1, false);
            for (var i = 0; i < columns; i++)
                DFS(heights, rows - 1, i, false);

            foreach (var pacificCell in pacificCells)
                if (atlanticCells.Contains(pacificCell))
                    result.Add(new List<int>() { pacificCell.Item1, pacificCell.Item2 });

            return result;

            // Time Complexity: (M x N)
            // Space Complexity: (M x N)

            void DFS(int[][] heights, int row, int col, bool itsPacific)
            {
                var height = heights[row][col];

                if (itsPacific)
                    pacificCells.Add((row, col));
                else
                    atlanticCells.Add((row, col));

                foreach (var (directionRow, directionCol) in directions)
                {
                    var nextRow = row + directionRow;
                    var nextCol = col + directionCol;

                    if (
                        nextRow >= 0 &&
                        nextCol >= 0 &&
                        nextRow < rows &&
                        nextCol < columns &&
                        height <= heights[nextRow][nextCol]
                    )
                    {
                        if (itsPacific && pacificCells.Contains((nextRow, nextCol)))
                            continue;
                        else if (!itsPacific && atlanticCells.Contains((nextRow, nextCol)))
                            continue;
                        else
                            DFS(heights, nextRow, nextCol, itsPacific);
                    }
                }
            }
        }
    }
}
