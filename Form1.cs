using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InternationalTradingData
{
    public partial class Form1 : Form
    {
        static string[] headers = new string[6];

        AVLTree<Country> tree;
        LinkedList<Country> countries = new LinkedList<Country>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to populate the list view, called when the tree is edited or searched
        /// </summary>
        /// <param name="search">Boolean determines if method called as a search</param>
        private void populateListView(Boolean search)
        {
            listView1.Items.Clear();
            if (search == true && CountryinfoCB.Checked == true)
            {
                countries = tree.search(searchBox.Text.Trim(), false);
            }
            else if (search == true && tradePartCB.Checked == true)
            {
                countries = tree.search(searchBox.Text.Trim(), true);
            }
            else
            {
                 countries = tree.inOrder();
            }
            foreach (Country c in countries)
            {
                string tPart = "";
                foreach (String s in c.TradePartners)
                {
                    tPart += s + " ";
                }

                string[] row = {c.Name, c.GDP, c.Inflation, c.TradeBalance, c.HDI, tPart};
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
            }
        }

        private void treeDepth()
        {
            int depth = tree.Height();
            label3.Text = depth.ToString();
            int count = tree.count();
            label4.Text = count.ToString();
            label6.Text = tree.tradePotential();
        }

        /// <summary>
        /// Load button click
        /// Reads csv file and creates country objects to be added to the tree
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];
            tree = new AVLTree<Country>();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv files (*.csv)|*.csv";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AllLines = File.ReadAllLines(openFile.FileName);

                    foreach (string line in AllLines)
                    {
                        if (line.StartsWith("Country"))
                        {
                            headers = line.Split(',');
                        }
                        else
                        {
                            string[] columns = line.Split(',');
                            string[] partners = columns[5].Split(';', '[', ']');
                            LinkedList<String> tPartners = new LinkedList<string>();
                            for (int i = 1; i < partners.Length - 1; i++)
                            {
                                tPartners.AddLast(partners[i]);
                            }
                            //Creates a new country object and adds to tree
                            Country country = new Country(columns[0], columns[1], columns[2], columns[3], columns[4], tPartners);
                            tree.InsertItem(country);
                        }
                    }
                    populateListView(false);
                    treeDepth();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Remove button click event
        /// Removes the selected item from the tree
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    String countryName = listView1.SelectedItems[0].Text;
                    tree.RemoveItem(tree.returnCountry(countryName));

                    populateListView(false);
                    treeDepth();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please load data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Edit Button click event
        /// Opens up the Edit form containing the relative country information of the country selected
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    String countryName = listView1.SelectedItems[0].Text;

                    editForm eform = new editForm(tree.returnCountry(countryName));
                    if (eform.ShowDialog() == DialogResult.OK)
                    {
                        tree.RemoveItem(tree.returnCountry(countryName));
                        Country newCountry = eform.getCountry;

                        tree.InsertItem(newCountry);
                    }
                    populateListView(false);
                    treeDepth();
                }
                else
                {
                    MessageBox.Show("Please select an item to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please load data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Check box click event
        /// Repopulates listview appropriately if a search is being conducted
        /// </summary>
        private void CountryinfoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryinfoCB.Checked == true)
            {
                tradePartCB.Checked = false;
                if (!string.IsNullOrWhiteSpace(searchBox.Text) && tree != null)
                {
                    populateListView(true);
                }
            }
            else
            {
                tradePartCB.Checked = true;
            }
        }

        /// <summary>
        /// Check box click event
        /// Repopulates listview appropriately if a search is being conducted
        /// </summary>
        private void tradePartCB_CheckedChanged(object sender, EventArgs e)
        {
            if (tradePartCB.Checked == true)
            {
                CountryinfoCB.Checked = false;
                if (!string.IsNullOrWhiteSpace(searchBox.Text) && tree != null)
                {
                    populateListView(true);
                }
            }
            else
            {
                CountryinfoCB.Checked = true;
            }
        }

        /// <summary>
        /// Search box, if text is entered searches the tree for data containing the text entered
        /// </summary>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (tree != null    )
            {
                if (!string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    populateListView(true);
                }
                else
                {
                    populateListView(false);
                }
            }  
        }
    }
}
