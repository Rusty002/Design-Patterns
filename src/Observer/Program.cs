// See https://aka.ms/new-console-template for more information

using Observer.Concept;
using Observer.Exercise;

var mySource = new DataSource();
var sheet1 = new SpreadSheet(mySource);
var sheet2 = new SpreadSheet(mySource);
var chart = new Chart(mySource);

mySource.AddObserver(sheet1);
mySource.AddObserver(sheet2);
mySource.AddObserver(chart);

mySource.SetValue(1);


var myStock = new Stock();
var stock1 = new StockList(myStock);
var stock2 = new StockList(myStock);
var statusBar = new StatusBar(myStock);

myStock.AddObserver(stock1);
myStock.AddObserver(stock2);
myStock.AddObserver(statusBar);

myStock.SetPrice(10);