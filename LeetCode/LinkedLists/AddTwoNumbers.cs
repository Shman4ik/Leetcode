using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedLists
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
	}

	class AddTwoNumbersTasks
	{
		//l1 = [9,9,9,9,9,9,9], 
		//l2 = [9,9,9,9]
		//     [8,9,9,9,0,0,0,1]
		//     9999
		//+99999999

		//[1,8,4,3], 
		//[5,6,4]
		//[6,4,9,3]
		// 3481 
		//+ 465 = 3946
		public AddTwoNumbersTasks()
		{
			//L1 = new ListNode(2, new ListNode(4, new ListNode(3)));
			//L2 = new ListNode(5, new ListNode(6, new ListNode(4)));
			L1 = new ListNode(9,
				new ListNode(9,
				new ListNode(9,
				new ListNode(9,
				new ListNode(9,
				new ListNode(9,
				new ListNode(9)))))));
			L2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
		}

		public ListNode L1 { get; set; }
		public ListNode L2 { get; set; }

		public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var rootNode = new ListNode();
			sumToList(rootNode, l1, l2, 0);
			return rootNode;
		}

		private static void sumToList(ListNode root, ListNode l1, ListNode l2, int add)
		{
			if (l1 != null)
				root.val += l1.val;
			if (l2 != null)
				root.val += l2.val;
			root.val += add;

			var nextNode = new ListNode();
			if (l1?.next != null || l2?.next != null || root.val >= 10)
			{
				root.next = nextNode;
				if (root.val >= 10)
				{
					root.val -= 10;
					sumToList(nextNode, l1?.next, l2?.next, 1);
				}
				else
				{
					sumToList(nextNode, l1?.next, l2?.next, 0);
				}
			}
		}

		private static int ListNodeLength(ListNode l1)
		{
			int letgth = 0;
			if (l1 == null)
				return 0;
			do
			{
				var temp = l1.next;
				if (temp != null)
					letgth++;
				else
					break;
			} while (true);
			return letgth;
		}
	}
}
