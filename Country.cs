using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    public class Country : IComparable
    {
        String name;
        String hdi;
        String gdp, inflation, tradeBalance;
        LinkedList<string> tradePartners;

        public Country()
        {
        
        }

        public Country(String name, String gdp, String inflation, String tradeBalance, String hdi, LinkedList<string> tradePartners)
        {
            this.name = name;
            this.gdp = gdp;
            this.inflation = inflation;
            this.tradeBalance = tradeBalance;
            this.hdi = hdi;
            this.tradePartners = tradePartners;
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public String GDP
        {
            set { gdp = value; }
            get { return gdp; }
        }

        public String Inflation
        {
            set { inflation = value; }
            get { return inflation; }
        }

        public String TradeBalance
        {
            set { tradeBalance = value; }
            get { return tradeBalance; }
        }

        public String HDI
        {
            set { hdi = value; }
            get { return hdi; }
        }

        public LinkedList<string> TradePartners
        {
            set { tradePartners = value; }
            get { return tradePartners; }
        }

        public int CompareTo(Object other)
        {
            Country temp = (Country)other;
            return Name.CompareTo(temp.Name);
        }
    }
}
