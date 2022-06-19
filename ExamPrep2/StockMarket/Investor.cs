namespace StockMarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Investor
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public List<Stock> Portfolio { get; set; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
            this.Portfolio = new List<Stock>();
        }

        public int Count { get => this.Portfolio.Count; }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                this.MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (Portfolio.Where(s => s.CompanyName == companyName).Count() == 0)
            {
                return $"{companyName} does not exist.";
            }
            else if (sellPrice < Portfolio.Find(s => s.CompanyName == companyName).PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }
            else
            {
                this.Portfolio.Remove(Portfolio.Find(s => s.CompanyName == companyName));
                this.MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
            }
        }

        public Stock FindStock(string companyName)
        {
            return this.Portfolio.FirstOrDefault(s => s.CompanyName == companyName);

        }
        public Stock FindBiggestCompany()
        {
            return this.Portfolio.OrderByDescending(s => s.MarketCapitalization).FirstOrDefault(); 
        }
        public string InvestorInformation()
        {
            return $"The investor {this.FullName} with a broker {this.BrokerName} has stocks:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, this.Portfolio)}";
        }
    }
}
