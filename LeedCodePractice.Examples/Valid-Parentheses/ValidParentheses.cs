namespace LeedCodePractice.Examples.Valid_Parentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> parenthesesMap = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
            foreach (char c in s)
            {
                if (parenthesesMap.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (parenthesesMap.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != parenthesesMap[c])
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
