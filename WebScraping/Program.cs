using EasyAutomationFramework;
using EasyAutomationFramework.Model;
using WebScraping.Drive;

var web = new WebScraper();
var computers = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers");
var laptops = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers/laptops");
var tablets = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers/tablets");

var myParams = new ParamsDataTable("Dados", @"C:\Users\Frederico Garcêz\Downloads", new List<DataTables>
{
    new DataTables("computers", computers),
    new DataTables("laptops", laptops),
    new DataTables("tablets", tablets)
});

Base.GenerateExcel(myParams);

