﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1CS
{
    public class LCquestion
    {
        // LC1
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[nums[i]] = i;
            }
            return null;
        } 
        //LC9
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int reversed = 0;
            int original = x;
            while (original != 0)
            {
                reversed = reversed * 10 + original % 10;
                original /= 10;
            }
            return x == reversed;
        }
        //LC217
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }
                set.Add(num);
            }
            return false;
        }

        //LC412

        public IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }

        //LC15
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums); // sort the array
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue; // skip duplicates
                int j = i + 1, k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    { // found a triplet
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++; k--;
                        while (j < k && nums[j] == nums[j - 1]) j++; // skip duplicates
                        while (j < k && nums[k] == nums[k + 1]) k--; // skip duplicates
                    }
                    else if (sum < 0)
                    {
                        j++; // need to increase the sum
                    }
                    else
                    {
                        k--; // need to decrease the sum
                    }
                }
            }

            return result;
        }


    }


}
