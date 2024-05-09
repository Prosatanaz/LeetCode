using System.Diagnostics.Metrics;


public class Solution
{
    static void Main(string[] args)
    {    
        Solution solution = new Solution();
       

    }
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        
        int count_1 = m - 1;
        int count_2 = n - 1;
        int last_element = n + m - 1;


        
        while (count_2 >= 0)
        {
            if (count_1 >= 0 && nums1[count_1] > nums2[count_2]) 
            {

                nums1[last_element--] = nums1[count_1--];
            }
            else 
            {
                nums1[last_element--] = nums2[count_2--];
            }
            
        }
        return nums1;
    }
}


