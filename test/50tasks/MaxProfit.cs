using System;
namespace test.tasks
{
	public class MaxProfit
	{
        public int MaxProfitMethod(int[] prices)
        {
            int[] a = {};
            prices.Reverse(a, 0);
            var temp = prices.ToList();
            int start = temp[0];
            int max = 0;
            for (int i = 1; i < temp.Count; i++) // [7,1,5,3,6,4]
            {
                //temp.RemoveAt
                var next = temp[i];
                if (start < temp[i])
                {
                    max += temp[i] - start;
                }
                start = temp[i];
            }
            return max;
        }
        
        public List<int[]> CreateTestData()
        {
            return new List<int[]>
            {
                new int[] { 7,1,5,3,6,4 },
            };
        }
    }
}

