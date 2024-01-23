namespace LeetCode
{
    public class ImplementTriePrefixTree
    {
        private TrieNode _root = new TrieNode(null);

        public void Insert(string word)
        {
            var trieNode = _root;

            foreach (var @char in word)
            {
                if (trieNode.Contains(@char, out var node))
                {
                    trieNode = node;
                }
                else
                {
                    var newNode = new TrieNode(@char);
                    trieNode.AddChild(newNode);
                    trieNode = newNode;
                }
            }

            trieNode.AddChild(new TrieNode('{'));
        }

        public bool Search(string word, bool prefix = false)
        {
            var node = _root;

            foreach (var @char in word)
            {
                if (node.Contains(@char, out var charNode))
                    node = charNode;
                else
                    return false;
            }

            if (prefix)
                return true;

            return node.Contains('{', out _);
        }

        public bool StartsWith(string prefix)
        {
            return Search(prefix, true);
        }
    }

    public class TrieNode
    {
        private const char A = 'a';

        public char? Value = null;
        public TrieNode[] Childs = new TrieNode[27];

        public TrieNode(char? value)
        {
            Value = value;
        }

        public void AddChild(TrieNode child)
        {
            Childs[child.Value.Value - A] = child;
        }

        public bool Contains(char value, out TrieNode childNode)
        {
            childNode = Childs[value - A];

            return childNode is not null;
        }
    }
}
