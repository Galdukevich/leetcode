using LeetCode;
using LeetCode.AddTwoNumbers;
using test;
using test.tasks;

//RomanToInt
//Console.WriteLine(new RomanToInt().RomanToIntMethod("MCMXCIV"));

////AddTwoNumbers
//foreach (var test in new ListNode().CreateTestData())
//{
//    var resultAddTwoNumbers = new Solution().AddTwoNumbers(test.First(), test.Last());
//}

////LongestCommonPrefix
//foreach (var test in new LongestCommonPrefix().CreateTestData())
//{
//    var resultLongestCommonPrefix = new LongestCommonPrefix().LongestCommonPrefixMethod(test);
//}

////LongestCommonPrefix
//foreach (var test in new ValidParentheses().CreateTestData())
//{
//    var resultValidParentheses = new ValidParentheses().IsValid_1(test);
//}

//RemoveDuplicatesFromSortedArray
//foreach (var test in new RemoveDuplicatesFromSortedArray().CreateTestData())
//{
//    var resultRemoveDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray().RemoveDuplicates(test);
//}

//RemoveDuplicatesFromSortedArray
foreach (var test in new MaxProfit().CreateTestData())
{
    var resultMaxProfit = new MaxProfit().MaxProfitMethod(test);
}