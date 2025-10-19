namespace LeedCodePractice.Examples;

public class Program
{
    public static void Main(string[] args)
    {
        string s = "babad";
        int length = longest_palindromic_substring.FindLongestPalindromicSubstring(s);
        Console.WriteLine($"The length of the longest palindromic substring in '{s}' is: {length}");

        ZigzagConversion zigzag = new ZigzagConversion();
        string converted = zigzag.Convert("PAYPALISHIRING", 3);
        Console.WriteLine($"The converted string is: {converted}");
        string converted2 = zigzag.Convert("PAYPALISHIRING", 4);
        Console.WriteLine($"The converted string is: {converted2}");
        string converted3 = zigzag.Convert("A", 1);
        Console.WriteLine($"The converted string is: {converted3}");

    }
}
