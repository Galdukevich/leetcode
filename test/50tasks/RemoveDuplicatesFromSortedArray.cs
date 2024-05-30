using System;
namespace test
{
	public class RemoveDuplicatesFromSortedArray
	{
        public int RemoveDuplicates(int[] nums)
        {
            var temp = nums.ToList();
            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int k = 1; k < temp.Count; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        temp.RemoveAt(k);
                    }
                }
            }
            nums = temp.ToArray();
            return nums.Length;
        }

        public List<int[]> CreateTestData()
        {
            return new List<int[]>
            {
                new int[] { 1, 1, 2 },
            };
        }
    }
}

