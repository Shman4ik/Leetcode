using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
	public class ValidateBinarySearchTree
	{
		public TreeNode treeNode { get; set; }

		public ValidateBinarySearchTree()
		{
			//var root = new int?[] { 2, 1, 3 };
			//var root = new int?[] { 1,1 };
			var root = new int?[] { 5, 4, 6, null, null, 3, 7 };
			//var root = new int?[] { 3, 1, 5, 0, 2, 4, 6 };

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

			treeNode = treeNodes[0];

			//var temp = root.Select(p => new TreeNode(p)).ToArray();
			//for (int i = 0; i < temp.Length - 1; i++)
			//{
			//	temp[i].next = temp[i + 1];
			//}

			//TreeNode treeNode = new TreeNode();
			////[5,1,4,null,null,3,6]
			//int i = 0;
			//while (true)
			//{
			//	treeNode.val = root[i].Value;
			//	treeNode.left = new TreeNode(root[i + 1].Value);
			//	treeNode.right = new TreeNode(root[i + 2].Value);
			//}

		}

		public static bool IsValidBST(TreeNode root)
		{
			if (root.left != null)
			{
				if (root.val <= root.left?.val)
					return false;
				if (!IsValidBST(root.left))
					return false;
			}
			if (root.right != null)
			{
				if (root.val >= root.right?.val)
					return false;
				if (!IsValidBST(root.right))
					return false;
			}
			return true;
		}

		//public static bool IsValidBST(TreeNode root, List<int> rootNode, bool? isRight)
		//{
		//	if (root.left != null)
		//	{
		//		if (root.val <= root.left?.val || (isRight.HasValue && isRight.Value && root.left?.val <= rootNode))
		//			return false;
		//		if (!IsValidBST(root.left, , false))
		//			return false;
		//	}
		//	if (root.right != null)
		//	{
		//		if (root.val >= root.right?.val || (isRight.HasValue && !isRight.Value && root.right?.val >= rootNode))
		//			return false;
		//		if (!IsValidBST(root.right, root.val, true))
		//			return false;
		//	}
		//	return true;
		//}

		public static bool IsValidBST(TreeNode node, long MIN, long MAX)
		{
			if (node == null)
				return true;
			if (node.val > MIN
				&& node.val < MAX
				&& IsValidBST(node.left, MIN, node.val)
				&& IsValidBST(node.right, node.val, MAX))
				return true;
			else
				return false;
		}
	}
}
