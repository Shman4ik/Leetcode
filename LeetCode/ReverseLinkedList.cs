using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
	public class ReverseLinkedList
	{
		//Input: head = [1,2,3,4,5]
		//Output: [5,4,3,2,1]
		public static ListNode ReverseList(ListNode head)
		{
			if (head == null)
				return null;
			List<int> result = new List<int>();
			getValue(head, result);
			var temp = result.Select(p => new ListNode(p)).ToArray();
			for (int i = 0; i < temp.Length - 1; i++)
			{
				temp[i].next = temp[i + 1];
			}
			return temp[0];
		}

		public static ListNode ReverseList1(ListNode head)
		{
			ListNode prev = null;
			ListNode curr = head;
			while (curr != null)
			{
				ListNode nextTemp = curr.next;
				curr.next = prev;
				prev = curr;
				curr = nextTemp;
			}
			return prev;
		}

		private static void getValue(ListNode head, List<int> result)
		{
			if (head.next == null)
			{
				result.Add(head.val);
				return;
			}
			else
			{
				getValue(head.next, result);
				head.next = null;
				result.Add(head.val);
			}
		}
	}



	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}
}
