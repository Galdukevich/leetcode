using System;
namespace LeetCode
{
    public class RomanToInt
    {
        //https://leetcode.com/problems/roman-to-integer/description/

        public int RomanToIntMethod(string s)
        {
            int result = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i + 1 <= s.Length - 1)
                        {
                            if (s[i + 1] == 'V')
                            {
                                i++;
                                result += 4;
                                break;
                            }
                            if (s[i + 1] == 'X')
                            {
                                i++;
                                result += 9;
                                break;
                            }
                            else
                            {
                                result += 1;
                                break;
                            }
                        }
                        else
                        {
                            result += 1;
                            break;
                        }

                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (i + 1 <= s.Length - 1)
                        {
                            if (s[i + 1] == 'L')
                            {
                                i++;
                                result += 40;
                                break;
                            }
                            if (s[i + 1] == 'C')
                            {
                                i++;
                                result += 90;
                                break;
                            }
                            else
                            {
                                result += 10;
                                break;
                            }
                        }
                        else
                        {
                            result += 10;
                            break;
                        }
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (i + 1 <= s.Length - 1)
                        {
                            if (s[i + 1] == 'D')
                            {
                                i++;
                                result += 400;
                                break;
                            }
                            if (s[i + 1] == 'M')
                            {
                                i++;
                                result += 900;
                                break;
                            }
                            else
                            {
                                result += 100;
                                break;
                            }
                        }
                        else
                        {
                            result += 100;
                            break;
                        }
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }
            return result;

        }


    }
}

