using System;
namespace test
{
	public class ValidParentheses
	{
        public bool IsValid_1(string s)

        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }

        public bool IsValid_2(string s)
        {
        string allowedChars = "(){}[]";
        string openPar = "";
        string closingPar = "";
        int counter = 0;
        bool result = false;
        bool stop = false;

        if (s.Length % 2 != 0 ||
            s.Where(x => x.ToString() == "{").Count() != s.Where(x => x.ToString() == "}").Count() ||
            s.Where(x => x.ToString() == "[").Count() != s.Where(x => x.ToString() == "]").Count() ||
            s.Where(x => x.ToString() == "(").Count() != s.Where(x => x.ToString() == ")").Count())
        {
            return false;
        }

        foreach (char c in s)
        {
            if (stop)
            {
                break;
            }

            if (!allowedChars.Contains(c.ToString()))
            {
                break;
            }

            if (c.ToString() == "{" || c.ToString() == "(" || c.ToString() == "[")
            {
                openPar += c.ToString();
                counter++;
                continue;
            }

            closingPar = s.Substring(counter, openPar.Length);

            if(openPar.Length == 0 && closingPar.Length == 0)
            {
                result = false;
                break;
            }

            for (int i = 0; i < openPar.Length; i++)
            {
                if (stop)
                {
                    break;
                }
                for (int k = closingPar.Length - 1; k >= 0; k--)
                {
                    if (openPar[i].ToString() == "(")
                    {
                        if (closingPar[k].ToString() != ")")
                        {
                            stop = true;
                            break;
                        }
                        result = true;
                        i++;
                        continue;
                    }
                    if (openPar[i].ToString() == "{")
                    {
                        if (closingPar[k].ToString() != "}")
                        {
                            stop = true;
                            break;
                        }
                        result = true;
                        i++;
                        continue;
                    }
                    if (openPar[i].ToString() == "[")
                    {
                        if (closingPar[k].ToString() != "]")
                        {
                            stop = true;
                            break;
                        }
                        result = true;
                        i++;
                        continue;
                    }

                }
                counter++;
            }
            if(openPar.Length + closingPar.Length == s.Length)
            {
                break;
            }
            openPar = "";
            closingPar = "";                
        }
        return result;
    }

        public List<string> CreateTestData()
        {
            return new List<string>
            {
                "()",
                "()[]{}",
                "(]",
                "(){}}{",
                "{[]}",
                "({{{{}}}))",
                "(([]){})"
            };
        }
    }
}

