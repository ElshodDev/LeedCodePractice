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


        StringBuilderForPractice sbPractice = new StringBuilderForPractice();
        sbPractice.AppendExample("Salom");
        sbPractice.AppendExample("Dunyo");


        ReverseWordsInString reverseWordsInString = new ReverseWordsInString();
        string reversed = reverseWordsInString.ReverseWords("  Hello   World  ");
        Console.WriteLine($"Reversed words: '{reversed}'");
        string reversed2 = reverseWordsInString.ReverseWords("a good   example");
        Console.WriteLine($"Reversed words: '{reversed2}'");



        ValidPalindrome validPalindrome = new ValidPalindrome();
        bool isPalindrome = validPalindrome.IsPalindrome("A man, a plan, a canal: Panama");
        Console.WriteLine($"Is palindrome: {isPalindrome}");
        bool isPalindrome2 = validPalindrome.IsPalindrome("wdqqwdqdqdqd");
        Console.WriteLine($"Is Palindrome: {isPalindrome2}");
        GroupAnagrams groupAnagrams = new GroupAnagrams();
        var anagrams = groupAnagrams.GroupAnagramsMethod(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        Console.WriteLine("Grouped Anagrams:");
        foreach (var group in anagrams)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }


        palindrome_number.palindrom palindromChecker = new palindrome_number.palindrom();
        bool isNumberPalindrome = palindromChecker.IsPalindrome(121);
        Console.WriteLine($"Is number palindrome: {isNumberPalindrome}");
        bool isNumberPalindrome2 = palindromChecker.IsPalindrome(-121);
        Console.WriteLine($"Is number palindrome: {isNumberPalindrome2}");
        bool isNumberPalindrome3 = palindromChecker.IsPalindrome(10);
        Console.WriteLine($"Is number palindrome: {isNumberPalindrome3}");

        palindrome_number.palindrome2 palindromChecker2 = new palindrome_number.palindrome2();
        bool isNumberPalindrome4 = palindromChecker2.IsPalindrome(12321);
        Console.WriteLine($"Is number palindrome: {isNumberPalindrome4}");
        bool isNumberPalindrome5 = palindromChecker2.IsPalindrome(-12321);
        Console.WriteLine($"Is number palindrome: {isNumberPalindrome5}");



        Sum.Sum sumCalculator = new Sum.Sum();
        var triplets = sumCalculator.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        Console.WriteLine("Triplets that sum to zero:");
        foreach (var triplet in triplets)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }



        Valid_Parentheses.ValidParentheses validParentheses = new Valid_Parentheses.ValidParentheses();
        bool isValid1 = validParentheses.IsValid("()");
        Console.WriteLine($"Is valid parentheses '()': {isValid1}");
        bool isValid2 = validParentheses.IsValid("()[]{}");
        Console.WriteLine($"Is valid parentheses '()[]{{}}': {isValid2}");
        bool isValid3 = validParentheses.IsValid("(]");
        Console.WriteLine($"Is valid parentheses '(]': {isValid3}");


        TwoSum.TwoSum twoSumSolver = new TwoSum.TwoSum();
        int[] result = twoSumSolver.FindTwoSum(new int[] { 2, 6, 7, 15 }, 21);
        Console.WriteLine($"Indices of the two numbers that add up to the target: [{string.Join(", ", result)}]");


        SearchInsertPosition.SearchInsertPos searchInsertPos = new SearchInsertPosition.SearchInsertPos();
        int insertIndex = searchInsertPos.SearchInsertPosition(new int[] { 1, 3, 5, 6 }, 5);
        Console.WriteLine($"Index to insert the target: {insertIndex}");


        Multiply_Strings.MultiplyStrings multiplyStrings = new Multiply_Strings.MultiplyStrings();
        string product0 = multiplyStrings.Multiply("2", "3");
        string product = multiplyStrings.Multiply("123", "456");
        Console.WriteLine($"Product of the two numbers:{product0}, {product}");


        LengthOfLastWords.LengthOfLastWord lengthOfLastWord = new LengthOfLastWords.LengthOfLastWord();
        int lastWordLength = lengthOfLastWord.LengthOfLastWordMethod("Hello World");
        Console.WriteLine($"Length of the last word: {lastWordLength}");

        MergeSortedArray.MergeSortedArray mergeSortedArrays = new MergeSortedArray.MergeSortedArray();
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = new int[] { 2, 5, 6 };
        mergeSortedArrays.Merge(nums1, 0, nums2, 1);
        Console.WriteLine($"Merged array: [{string.Join(", ", nums1)}]");
    }
}
