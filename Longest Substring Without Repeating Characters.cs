public class Solution {
public int LengthOfLongestSubstring(string s)
{
    int maxLength = 0;
    StringBuilder sb = new StringBuilder();

    foreach (char c in s)
    {
        int index = sb.ToString().IndexOf(c);
        if (index == -1) sb.Append(c);
        else
        {
            maxLength = Math.Max(maxLength, sb.Length);
            sb.Remove(0, index + 1);
            sb.Append(c);
        }
    }
    maxLength = Math.Max(maxLength, sb.Length);
    return maxLength;
}}
