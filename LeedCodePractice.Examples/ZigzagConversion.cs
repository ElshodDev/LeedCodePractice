using System.Text;

namespace LeedCodePractice.Examples
{
    public class ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length <= numRows) return s;

            var builders = new StringBuilder[numRows];
            for (int i = 0; i < numRows; i++) builders[i] = new StringBuilder();

            int row = 0, step = 1;
            foreach (char c in s)
            {
                builders[row].Append(c);
                if (row == 0) step = 1;
                if (row == numRows - 1) step = -1;
                row += step;
            }

            var result = new StringBuilder();
            foreach (var builder in builders) result.Append(builder.ToString());
            return result.ToString();
        }
    }
}
