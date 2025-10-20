using System.Text;

namespace LeedCodePractice.Examples
{
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var reverseWords = new StringBuilder();
            for (int i = words.Length-1; i >=0; i--)
            {
                reverseWords.Append(words[i]);
                if (i > 0)
                    reverseWords.Append(' ');
            }
            return reverseWords.ToString();
        }
    }
}
