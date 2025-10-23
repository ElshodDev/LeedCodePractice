using System.Text;

namespace LeedCodePractice.Examples
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            StringBuilder lowercase = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    lowercase.Append(char.ToLower(c));
                }
            }
            string lowercaseStr = lowercase.ToString();

            int left = 0;
            int right = lowercaseStr.Length - 1;

            while (left < right)
            {
                if (lowercaseStr[left] != lowercaseStr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
