/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
    public int MaxDepth(TreeNode root, int depth = 0)
    {
        if (root == null) return depth;
        return Math.Max(MaxDepth(root.right, depth + 1), MaxDepth(root.left, depth + 1));
    }
}