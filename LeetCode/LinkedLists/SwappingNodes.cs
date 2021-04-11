using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedLists
{
	public static class SwappingNodes
	{
		public static ListNode ListNodeExample1 =
			new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
		public static ListNode SwapNodes(ListNode head, int k)
		{
			var length = LengthListNode(head);
			var endToSwap = length - k + 1;

			var i = 1;
			ListNode firstSwap = null;
			ListNode lastSwap = null;

			ListNode current = head;
			do
			{

				if (i == k)
					firstSwap = current;
				if (i == endToSwap)
					lastSwap = current;
				current = current.next;
				i++;

			} while (current.next != null);

			ListNode result = null;
			i = 1;
			current = head;
			result = head;
			do
			{

				if (i == k-1)
					result.next = lastSwap;
				else if (i == endToSwap-1)
					result.next = firstSwap;
				else
					result.next = current.next;
				current = current.next;
				i++;

			} while (current.next != null);

			return result;
		}

		private static int LengthListNode(ListNode head)
		{
			var length = 1;
			ListNode currentNode = head;
			if (head.next == null)
				return length;
			do
			{
				length++;
				currentNode = currentNode.next;


			} while (currentNode.next != null);

			return length;
		}
	}
}
