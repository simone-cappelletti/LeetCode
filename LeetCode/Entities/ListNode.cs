namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class ListNodeWithRandom
    {
        public int val;
        public ListNodeWithRandom next;
        public ListNodeWithRandom random;

        public ListNodeWithRandom(int val = 0)
        {
            this.val = val;
        }
    }
}
