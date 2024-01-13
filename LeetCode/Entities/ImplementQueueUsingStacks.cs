namespace LeetCode
{
    public class ImplementQueueUsingStacks
    {
        private readonly Stack<int> s1 = new();
        private readonly Stack<int> s2 = new();

        public void Push(int x)
        {
            s1.Push(x);
        }

        public int Pop()
        {
            if (s2.Count == 0)
                ReverseStack();

            return s2.Pop();
        }

        public int Peek()
        {
            if (s2.Count == 0)
                ReverseStack();

            return s2.Peek();
        }

        public bool Empty()
        {
            return
                s1.Count == 0 &&
                s2.Count == 0;
        }

        private void ReverseStack()
        {
            while (s1.Count != 0)
                s2.Push(s1.Pop());
        }
    }
}
