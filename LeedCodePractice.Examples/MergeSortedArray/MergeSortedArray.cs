namespace LeedCodePractice.Examples.MergeSortedArray
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int iterator = 0; iterator < n; iterator++)
                {
                    nums1[iterator] = nums2[iterator];
                }
                return;
            }
            int i = m - 1;    // Last valid element in nums1
            int j = n - 1;    // Last element in nums2
            int k = m + n - 1;// End of nums1

                while (i >= 0 && j >= 0)
                {
                    if (nums1[i] > nums2[j])
                    {
                        nums1[k--] = nums1[i--];
                    }
                    else
                    {
                        nums1[k--] = nums2[j--];
                    }
                }
            }
        }
}
