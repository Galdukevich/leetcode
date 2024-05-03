using LeetCode.AddTwoNumbers;

namespace LeetCode
{
    public class Solution
    {
        //https://leetcode.com/problems/add-two-numbers/description/

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return Sort(Sum(l1, l2));
        }

        public ListNode Sort(ListNode l)
        {
            int counter = 0;
            ListNode result = new ListNode();
            while (l.next != null)
            {
                var temp = new ListNode(l.val);
                l = l.next;
                result = new ListNode(temp.val, result);
                if (counter == 0)
                {
                    result.next = null;
                }
                counter++;
            }
            if (l.next == null && counter == 0)
            {
                result = new ListNode(l.val);
            }
            else
            {
                result = new ListNode(l.val, result);
            }
            return result;
        }

        public ListNode Sum(ListNode l1, ListNode l2)
        {
            if (l1.next == null && l2.next == null)
            {
                return SumSupport();
            }
            return SumSupport();

            ListNode SumSupport()
            {
                int counter = 0;
                bool add = false;
                ListNode result = new ListNode();
                while (add || l1 != null || l2 != null)
                {
                    var temp = new ListNode((l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val));
                    if (l1 != null)
                    {
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        l2 = l2.next;
                    }

                    if (add)
                    {
                        temp.val += 1;
                        add = false;
                    }

                    if (temp.val >= 10)
                    {
                        temp.val = temp.val % 10;
                        add = true;
                    }
                    result = new ListNode(temp.val, result);
                    if (counter == 0)
                    {
                        result.next = null;
                    }
                    counter++;
                }
                if (l1 != null || l2 != null)
                {
                    result = new ListNode(add ? l1.val + l2.val + 1 : l1.val + l2.val, result);
                }
                return result;
            }
        }
    }
}

