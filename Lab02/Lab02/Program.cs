using Lab02;

var hryvnia = new Hryvnia(15, 15);

hryvnia.PrintMoney();

var dollar = new Dollar(11, 11);

dollar.PrintMoney();


var products = new List<Product>()
{
    new Product(new Guid(), "Name1", "Desc1", "ProducerName1", 11, 5),
    new Product(new Guid(), "Name2", "Desc2", "ProducerName2", 15, 7),
    new Product(new Guid(), "Name3", "Desc3", "ProducerName3", 32, 8),
    new Product(new Guid(), "Name4", "Desc4", "ProducerName4", 3, 4),
};

var warehouse = new Warehouse(products);

warehouse.AddProduct(new Product(new Guid(), "Name5", "Desc5", "ProducerName5", 11, 2));

var reportingApi = new Reporting();

var departReport = reportingApi.DepartProductReport(products[0]);
warehouse.RemoveProduct(products[0]);
Console.WriteLine(departReport.ReportContent);

var addReport = reportingApi.AddProductReport(products[0]);
warehouse.AddProduct(products[0]);
Console.WriteLine(addReport.ReportContent);

var warehouseReport = reportingApi.GetWarehouseReport(warehouse.Products);
Console.WriteLine(warehouseReport.ReportContent);   

