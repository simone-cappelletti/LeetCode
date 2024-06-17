namespace LeetCode;

public class KthLargestElementInAStream
{
    private int _k;
    private PriorityQueue<int, int> _nums;

    public KthLargestElementInAStream(int k, int[] nums)
    {
        _k = k;
        _nums = new PriorityQueue<int, int>();

        foreach (int num in nums)
            Add(num);
    }

    public int Add(int val)
    {
        _nums.Enqueue(val, val);

        while (_nums.Count > _k)
            _nums.Dequeue();

        return _nums.Peek();
    }
}
