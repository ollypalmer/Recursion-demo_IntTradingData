using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternationalTradingData
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {

        Boolean flag = false;
        T smallest;

        public BSTree()
        {
            root = null;
        }
        
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(height(tree.Left), height(tree.Right)) + 1;
            }
        }

        public Boolean Contains(T item)
        {
            return contains(root, item);
        }

        private Boolean contains(Node<T> tree, T item)
        {
            if (tree == null)
            {
                return false;
            }
            else
            {
                contains(tree.Left, item);
                if (item.CompareTo(tree.Data) == 0)
                {
                    flag = true;
                }
                contains(tree.Right, item);
                if (item.CompareTo(tree.Data) == 0)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {

            }
            else if (item.CompareTo(tree.Data) == 0)
            {
                if (tree.Left == null && tree.Right == null)
                {
                    tree = null;
                }
                else if (tree.Left != null && tree.Right == null)
                {
                    tree = tree.Left;
                }
                else if (tree.Right != null && tree.Left == null)
                {
                    tree = tree.Right;
                }
                else if (tree.Left != null && tree.Right != null)
                {
                    tree.Data = smallestItem(ref tree.Right);
                    removeItem(smallest, ref tree.Right);
                }

            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }
        }

        private T smallestItem(ref Node<T> tree)
        {
            if (tree.Left == null)
            {
                smallest = tree.Data;
            }
            else
            {
                smallestItem(ref tree.Left);
            }

            return smallest;
        }
    }
}
