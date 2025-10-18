namespace LeedCodePractice.Examples
{
    public class longest_palindromic_substring
    {
        public static int FindLongestPalindromicSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                maxLength = Math.Max(maxLength, len);
            }
            return maxLength;
        }
        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
