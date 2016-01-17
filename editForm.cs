using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTradingData
{
    public partial class editForm : Form
    {
        Country newCountry;

        /// <summary>
        /// Initialize edit form with country data
        /// </summary>
        /// <param name="c">The Country to be edited</param>
        public editForm(Country c)
        {
            InitializeComponent();
            countrytb.Text = c.Name;
            gdptb.Text = c.GDP;
            inflationtb.Text = c.Inflation;
            tradeBaltb.Text = c.TradeBalance;
            hditb.Text = c.HDI;

            tradePartlv.HeaderStyle = ColumnHeaderStyle.None;
            foreach (String s in c.TradePartners)
            {
                tradePartlv.Items.Add(s);
            }
        }
        
        public Country getCountry
        {
            set { newCountry = value; }
            get { return newCountry; }
        }
        
        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Checks to see if all changes are acceptable, creates new country item with the new data 
        /// </summary>
        private void saveButt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(countrytb.Text) && !string.IsNullOrWhiteSpace(gdptb.Text) && !string.IsNullOrWhiteSpace(inflationtb.Text) && !string.IsNullOrWhiteSpace(tradeBaltb.Text) && !string.IsNullOrWhiteSpace(hditb.Text))
            {
                LinkedList<string> newTradePart = new LinkedList<string>();
                foreach (ListViewItem lvi in tradePartlv.Items)
                {
                    if (!string.IsNullOrWhiteSpace(lvi.SubItems[0].Text))
                    {
                        newTradePart.AddLast(lvi.SubItems[0].Text);
                    }
                }
                newCountry = new Country(countrytb.Text, gdptb.Text, inflationtb.Text, tradeBaltb.Text, hditb.Text, newTradePart);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Some fields still require an entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void gdptb_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInput(sender, e);
        }

        private void inflationtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInput(sender, e);
        }

        private void tradeBaltb_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInput(sender, e);
        }

        private void hditb_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericInput(sender, e);
        }

        /// <summary>
        /// Method to handle input into fields that should only accept numbers
        /// </summary>
        private void numericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
