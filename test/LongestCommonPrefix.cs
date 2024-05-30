using System;
namespace test
{
	public class LongestCommonPrefix
	{
        public string LongestCommonPrefixMethod(string[] strs)
        {
            char prev = '\0';
            string result = "";
            int counter = 0;
            bool stop = false;
            foreach (var word in strs)
            {
                if (stop)
                {
                    break;
                }
                foreach (var ch in word)
                {
                    for (int i = 0; i < strs.Length; i++)
                    {
                        counter = 0;
                        string current = strs[i];
                        if (current.Length == 0 || stop)
                        {
                            prev = '\0';
                            break;
                        }

                        for (int k = 0; k < 1; k++)
                        {
                            if (i == 0)
                            {
                                prev = current[k];
                            }
                            if (prev == current[k])
                            {
                                continue;
                            }
                            else
                            {
                                prev = '\0';
                                stop = true;
                                break;
                            }
                        }
                    }
                    if (stop)
                    {
                        break;
                    }
                    foreach (var x in strs)
                    {
                        if (strs[counter].Length > 0)
                        {
                            strs[counter] = x.Substring(1);
                        }
                        counter++;
                    }
                    if (prev != '\0')
                    {
                        result += prev;
                    }
                }
            }
            return result;
        }

        public List<string[]> CreateTestData()
        {
            return new List<string[]>
            {
                new string[] { "flower","flow","flight" },
                new string[] { "dog","racecar","car" },
                new string[] { "ab", "a" },
                new string[] { "", "b" },
                new string[] { "flower","flower","flower","flower" },
                new string[] { "cir","car" },
            };
        }
    }
}

