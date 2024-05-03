using System;
namespace LeetCode.AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public List<List<ListNode>> CreateTestData()
        {
            return new List<List<ListNode>> {
                new List<ListNode> {
                    new ListNode(2, new ListNode(4, new ListNode(3))), //[2,4,3]
                    new ListNode(5, new ListNode(6, new ListNode(4))), //[5,6,4]
                },
                new List<ListNode> {
                    new ListNode(),
                    new ListNode(),
                },
                new List<ListNode> {
                    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))), //[9,9,9,9,9,9,9]
                    new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))), //[9,9,9,9]
                },
                new List<ListNode> {
                    new ListNode(2, new ListNode(4, new ListNode(9))), //[2,4,9]
                    new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(9)))), //[5,6,4,9]
                },
                new List<ListNode> {
                    new ListNode(5),
                    new ListNode(5),
                },
            };
        }
    }
}

