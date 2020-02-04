namespace LeetCodeSolutions
{
    public partial class Solution
    {
        /// <summary>
        /// You are given two non-empty linked lists representing two non-negative integers. 
        /// The digits are stored in reverse order and each of their nodes contain a single digit. 
        /// Add the two numbers and return it as a linked list.
        /// 
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// 
        /// Example:
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// Explanation: 342 + 465 = 807.
        /// </summary>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var sum = l1.val + l2.val;
            var carry = 0;
            if (sum > 9)
            {
                sum %= 10;
                carry = 1;
            }
            var headNode = new ListNode(sum);
            var tmpNode = headNode;
            l1 = l1.next;
            l2 = l2.next;

            while (l1 != null || l2 != null || carry != 0)
            {
                var leftValue = 0;
                var rightValue = 0;
                if (l1 != null)
                {
                    leftValue = l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    rightValue = l2.val;
                    l2 = l2.next;
                }
                sum = leftValue + rightValue + carry;
                if (sum > 9)
                {
                    sum %= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                tmpNode = tmpNode.next = new ListNode(sum);
            }

            return headNode;
        }   
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}
