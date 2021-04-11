using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
	public class BinaryTree
	{
		public TreeNode TreeNode { get; set; }

		public BinaryTree(int?[] root)
		{
			var treeNodes = new TreeNode[root.Length];
			for (int i = 0; i < root.Length; i++)
			{
				if (root[i].HasValue)
					treeNodes[i] = new TreeNode(root[i].Value);
			}

			for (int i = 0; i < root.Length - 2; i++)
			{
				if (treeNodes[i] != null)
				{
					if (2 * i + 1 < treeNodes.Length)
					{
						treeNodes[i].left = treeNodes[2 * i + 1];
						treeNodes[i].right = treeNodes[2 * i + 2];
					}
				}
			}
			treeNodes.ToString();

			TreeNode = treeNodes[0];
		}

		public bool IsBalanced(TreeNode root)
		{
			if (root == null)
				return true;
			var leftMaxHeight = MaxChildHeight(root.left);
			var rightMaxHeight = MaxChildHeight(root.right);
			if (rightMaxHeight - leftMaxHeight > 1 || rightMaxHeight - leftMaxHeight < -1)
				return false;

			if (root.left != null)
				if (!IsBalanced(root.left))
					return false;
			if (root.right != null)
				if (!IsBalanced(root.right))
					return false;
			return true;
		}

		private int MaxChildHeight(TreeNode node)
		{
			if (node != null)
			{
				return 1 + Math.Max(MaxChildHeight(node.left), MaxChildHeight(node.right));
			}
			return 0;
		}
	}
}
