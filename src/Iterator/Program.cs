// See https://aka.ms/new-console-template for more information
using Iterator.Exercise;
using Iterator.Iterator;

Console.WriteLine("Hello, this solution contains implementation for iterator pattern");

var myBrowserHistory = new BrowserHistory();
myBrowserHistory.PushUrl("abc.com");
myBrowserHistory.PushUrl("playland.com");
myBrowserHistory.PushUrl("stayle.com");

//for (int i = 0; i < myBrowserHistory.GetUrls().Count; i++)
//    Console.WriteLine(myBrowserHistory.GetUrls()[i]);

ITerator iterator = myBrowserHistory.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}


var myProductCollection = new ProductCollection();
myProductCollection.AddProduct(new Product(1, "Chilli Milli"));
myProductCollection.AddProduct(new Product(2, "Cocomo"));
myProductCollection.AddProduct(new Product(3, "Choclate"));

ITERATOR iteratorForProducts = myProductCollection.CreateIterator();
while (iteratorForProducts.HasNext())
{
    Console.WriteLine(iteratorForProducts.Current().InString());
    iteratorForProducts.Next();
}
