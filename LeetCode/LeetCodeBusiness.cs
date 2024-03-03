using System.Text;

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
    }
}
