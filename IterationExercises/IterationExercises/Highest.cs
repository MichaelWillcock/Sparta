using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            if (nums.Length == 0)
            {
                throw new Exception("Array contains no values");
            }
            else
            {
                int i = 0;
                int x = nums[0];
                while (i < nums.Length)
                {
                    if (nums[i] > x)
                    {
                        x = nums[i];
                    }
                    i++;
                }
                return x;
            }
                
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            if (nums.Length == 0)
            {
                throw new Exception("Array contains no values");
            }
            else
            {
                int x = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > x)
                    {
                        x = nums[i];
                    }
                }

                return x;
            }
        }

        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            if (nums.Length == 0)
            {
                throw new Exception("Array contains no values");
            }
            else
            {
                int x = nums[0];
                foreach (int num in nums)
                {
                    if (num > x)
                    {
                        x = num;
                    }
                }
                return x;
            } 
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            if (nums.Length == 0)
            {
                throw new Exception("Array contains no values");
            }
            else
            {
                int i = 0;
                int x = nums[0];
                do
                {
                    if (nums[i] > x)
                    {
                        x = nums[i];
                    }
                    i++;
                } while (i < nums.Length);
                return x;
            }
        }
    }
}