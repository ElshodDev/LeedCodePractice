namespace LeedCodePractice.Examples.LengthOfLastWords
{
    public class LengthOfLastWord
    {
      public int LengthOfLastWordMethod(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            string[] words = s.Trim().Split(' ');
            return words.Length == 0 ? 0 : words[^1].Length;
        }
    }
}
