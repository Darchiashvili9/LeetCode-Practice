using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            int Sxvaoba = target - nums[i];

            if (dict.ContainsKey(Sxvaoba))
            {
                return new int[] { dict[Sxvaoba], i };
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }

            return Array.Empty<int>();
    }
}

var solver = new Solution();
int[] nums = { 2, 7, 11, 15 };
int target = 9;
var result = solver.TwoSum(nums, target);

Console.WriteLine($"Indices: {result[0]}, {result[1]}");
