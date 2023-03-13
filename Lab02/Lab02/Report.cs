using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    // Single Responsibility - class operates only with report
    // Liskov Substitution Principle - by default in c#
    // Open-Closed can be extended by c# extension methods and inheritance
    public class Report
    {
        public string Type { get; set; } = string.Empty;

        public IList<Product> ProductsInReport { get; set; } = new List<Product>();

        public string ReportContent { get; set; } = string.Empty;

        public Report(string type, IList<Product> productsInReport)
        {
            this.Type = type;
            this.ProductsInReport = productsInReport;
        }

        public string GetReportContent()
        {
            string resultString = string.Empty;

            foreach (var product in ProductsInReport)
            {
                resultString += $"\n{product.ToString()}";
            }

            return resultString;
        }
    }
}
