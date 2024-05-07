// See https://aka.ms/new-console-template for more information
using Decorator.Concept;
using Decorator.Exercise;

Console.WriteLine("Decorator Design Pattern!");
StoreCreditCard(new EncrytedCloudStream(new CompressedCloudStream(new CloudStream())));
static void StoreCreditCard(IStream stream)
{
    stream.Write("123-123-123-123");
}

Demo.Show();