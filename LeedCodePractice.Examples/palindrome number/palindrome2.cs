namespace LeedCodePractice.Examples.palindrome_number
{
    public class palindrome2
    {
        public bool IsPalindrome(int x)
        {
          if(x<0) return false;
            string str = x.ToString();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
