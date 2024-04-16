using System.Text;

namespace LeetCode
{
    public class EncodeAndDecodeStrings
    {
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            return string.Join(' ', strs.Select(x => Convert.ToBase64String(Encoding.ASCII.GetBytes(x))));
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            return s.Split(' ').Select(x => Encoding.ASCII.GetString(Convert.FromBase64String(x))).ToList();
        }
    }
}
