using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> new class operations </summary>
    public class Operations
    {
        /// <summary> returns maximun integer in a list </summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }
            int maxim = nums[0];
            foreach (int i in nums)
            {
                if (i > maxim)
                {
                    maxim = i;
                }
            }
            return maxim;
        }
    }
}
