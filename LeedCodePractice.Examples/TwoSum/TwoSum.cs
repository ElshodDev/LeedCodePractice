namespace LeedCodePractice.Examples.TwoSum
{
    public class TwoSum
    {
        public int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> FindFair=new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                int result = target-nums[i];
                if(FindFair.ContainsKey(result))
                {
                    return new int[] { FindFair[result], i };
                }
                FindFair[nums[i]] = i;
            }
            return Array.Empty<int>();

        }
    }
}