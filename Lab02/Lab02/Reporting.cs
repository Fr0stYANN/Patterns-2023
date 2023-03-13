using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public static class ReportType
    {
        public const string Add = "AddReport";
        public const string Departure = "DepartureReport";
        public const string WarehouseProducts = "WarhouseProductsReport";
    }


    // Single Responsibility - class operates only with reports, it generates them by getting list of products
    // Liskov Substitution Principle - by default in c#
    // Open-Closed can be extended by c# extension methods and inheritance
    public class Reporting
    {
        public Report AddProductReport(Product product)
        {
            return CreateReport(new List<Product>() { product } , ReportType.Add);
        }

        public Report DepartProductReport(Product product)
        {
            return CreateReport(new List<Product>() { product }, ReportType.Departure);
        }

        public Report GetWarehouseReport(IList<Product> products)
        {
            return CreateReport(products, ReportType.WarehouseProducts);
        }

        private Report CreateReport(IList<Product> products, string reportType)
        {
            var report = new Report(reportType, products);
            report.ReportContent = report.GetReportContent(); 
            
            return report;
        }
    }
}
