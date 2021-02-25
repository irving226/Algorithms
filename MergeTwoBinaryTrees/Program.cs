using System;
using System.Collections;

namespace MergeTwoBinaryTrees
{
    class Program
    {
         public class TreeNode
        {
     public int val;
      public TreeNode left;
     public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                     }
  }
        static void Main(string[] args)
        {
            
        }
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 != null && root2 != null)
            {
                root1.val = root1.val + root2.val;
                root1.left = MergeTrees(root1.left, root2.left);
                root2.right = MergeTrees(root1.right, root2.right);
                return root1;
            }
            else if (root1 != null && root2 == null)
            {
                return root1;
            }
            else if (root1 == null && root2 != null)
            {
                return root2;
            }
            else
                return null;
        }

        public static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
           
