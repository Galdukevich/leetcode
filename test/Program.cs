using LeetCode;
using LeetCode.AddTwoNumbers;

//RomanToInt
Console.WriteLine(new RomanToInt().RomanToIntMethod("MCMXCIV"));

//AddTwoNumbers
foreach (var test in new ListNode().CreateTestData())
{
    var result = new Solution().AddTwoNumbers(test.First(), test.Last());
}