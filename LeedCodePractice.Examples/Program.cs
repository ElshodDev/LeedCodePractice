namespace LeedCodePractice.Examples;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "babad";
        int length = longest_palindromic_substring.FindLongestPalindromicSubstring(s);
        Console.WriteLine($"The length of the longest palindromic substring in '{s}' is: {length}");
    }
}
