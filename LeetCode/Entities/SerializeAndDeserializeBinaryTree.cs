using Microsoft.AspNetCore.Routing.Patterns;
using System.Text;

namespace LeetCode
{
    public class SerializeAndDeserializeBinaryTree
    {
        private const char SEPARATOR = '|';

        public string Serialize(TreeNode root)
        {
            if (root is null)
                return string.Empty;

            var sb = new StringBuilder();
            var code = 0;
            var queue = new Queue<(int Code, int ParentCode, char Position, TreeNode Node)>();

            queue.Enqueue((code, 0, 'X', root));

            while (queue.Count > 0)
            {
                var (currentCode, currentParentCode, currentPosition, currentNode) = queue.Dequeue();

                sb.AppendLine($"{currentCode}{SEPARATOR}{currentParentCode}{SEPARATOR}{currentPosition}{SEPARATOR}{currentNode.val}");

                if (currentNode.left is not null)
                    queue.Enqueue((++code, currentCode, 'L', currentNode.left));

                if (currentNode.right is not null)
                    queue.Enqueue((++code, currentCode, 'R', currentNode.right));
            }

            return sb.ToString();

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }

        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return null;

            var dic = new Dictionary<int, TreeNode>();
            var levels = data.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            for (var i = 0; i < levels.Length; i++)
            {
                var level = levels[i].Split(SEPARATOR, StringSplitOptions.RemoveEmptyEntries);

                var code = int.Parse(level[0]);
                var parentCode = int.Parse(level[1]);
                var position = level[2];
                var val = int.Parse(level[3]);

                var node = new TreeNode(val);

                if (dic.TryGetValue(parentCode, out var parentNode))
                {
                    if (position == "L")
                        parentNode.left = node;
                    else if (position == "R")
                        parentNode.right = node;
                }

                dic.Add(code, node);
            }

            return dic[0];

            // Time Complexity: O(n)
            // Space Complexity: O(n)
        }
    }
}
