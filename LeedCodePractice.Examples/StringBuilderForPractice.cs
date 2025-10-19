using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace LeedCodePractice.Examples
{
    public class StringBuilderForPractice
    {
        public void AppendExample(string str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i<5; i++)
            {
                sb.Append(str).Append("-");
                sb.Remove(sb.Length - 1, 1); // Remove the last comma
                sb.AppendLine();
                sb.Replace("-", "_");
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}

