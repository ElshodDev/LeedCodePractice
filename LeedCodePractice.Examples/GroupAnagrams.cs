namespace LeedCodePractice.Examples
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramsMethod(string[] strs)
        {
            var anagramMap = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var charArray = str.ToCharArray();
                Array.Sort(charArray);
                var sortedStr = new string(charArray);
                if (!anagramMap.ContainsKey(sortedStr))
                {
                    anagramMap[sortedStr] = new List<string>();
                }
                anagramMap[sortedStr].Add(str);
            }
            return anagramMap.Values.Select(list => (IList<string>)list).ToList();
        }
    }
}
