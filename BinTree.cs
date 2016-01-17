using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public LinkedList<Country> preOrder()
        {
            LinkedList<Country> countries = new LinkedList<Country>();
            PreOrder(root, ref countries);
            return countries;
        }

        private void PreOrder(Node<T> tree, ref LinkedList<Country> countries)
        {
            if (tree != null)
            {
                countries.AddLast(tree.getCountry);
                PreOrder(tree.Left, ref countries);
                PreOrder(tree.Right, ref countries);
            }
        }

        public LinkedList<Country> inOrder()
        {
            LinkedList<Country> countries = new LinkedList<Country>();
            InOrder(root, ref countries);
            return countries;
        }

        private void InOrder(Node<T> tree, ref LinkedList<Country> countries)
        {
            if (tree != null)
            {
                InOrder(tree.Left, ref countries);
                countries.AddLast(tree.getCountry);
                InOrder(tree.Right, ref countries);
            }
        }

        public LinkedList<Country> postOrder()
        {
            LinkedList<Country> countries = new LinkedList<Country>();
            PostOrder(root, ref countries);
            return countries;
        }

        private void PostOrder(Node<T> tree, ref LinkedList<Country> countries)
        {
            if (tree != null)
            {
                PostOrder(tree.Left, ref countries);
                PostOrder(tree.Right, ref countries);
                countries.AddLast(tree.getCountry);
            }
        }

        public Country returnCountry(String cName)
        {
            Country country = new Country();
            ReturnCountry(root, ref country, cName);
            return country;
        }

        private void ReturnCountry(Node<T> tree, ref Country country, String cName)
        {
            if (tree != null)
            {
                if (cName.Equals(tree.getCountry.Name))
                {
                    country = tree.getCountry;
                }
                ReturnCountry(tree.Left, ref country, cName);
                ReturnCountry(tree.Right, ref country, cName);
            }
        }

        public int count()
        {
            int count = 0;
            Count(root, ref count);
            return count;
        }

        private void Count(Node<T> tree, ref int count)
        {
            if (tree != null)
            {
                Count(tree.Left, ref count);
                Count(tree.Right, ref count);
                count = count + 1;
            }
        }

        public LinkedList<Country> search(String item, Boolean tSearch)
        {
            LinkedList<Country> countries = new LinkedList<Country>();
            if (tSearch != true)
            {
                Search(root, ref countries, item);
            }
            else
            {
                tradeSearch(root, ref countries, item);
            }
            return countries;
        }

        private void Search(Node<T> tree, ref LinkedList<Country> countries, String item)
        {
            if (tree != null)
            {
                Search(tree.Left, ref countries, item);
                if (tree.getCountry.Name.IndexOf(item, StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    countries.AddLast(tree.getCountry);
                } 
                Search(tree.Right, ref countries, item);
            }
        }

        private void tradeSearch(Node<T> tree, ref LinkedList<Country> countries, String item)
        {
            if (tree != null)
            {
                tradeSearch(tree.Left, ref countries, item);
                foreach (String s in tree.getCountry.TradePartners)
                {
                    if (s.IndexOf(item, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        countries.AddLast(tree.getCountry);
                    }
                }
                tradeSearch(tree.Right, ref countries, item);
            }
        }

        public String tradePotential()
        {
            if (root != null)
            {
                Country c = root.getCountry;
                TradePotential(root, ref c);
                return c.Name;
            }
            return "n/a";
        }

        private void TradePotential(Node<T> tree, ref Country c)
        {
            if (tree != null)
            {
                TradePotential(tree.Left, ref c);
                if (gdpGrowth(c) < gdpGrowth(tree.getCountry))
                {
                    c = tree.getCountry;
                }
                TradePotential(tree.Right, ref c);
            }
        }

        private double gdpGrowth(Country c)
        {
            double gdpSum = 0;
            foreach (String s in c.TradePartners)
            {
                Country tempCountry = returnCountry(s);
                if (tempCountry.GDP != null)
                {
                    gdpSum += Double.Parse(tempCountry.GDP);
                }
                
            }
            return gdpSum;
        }
    }
}
