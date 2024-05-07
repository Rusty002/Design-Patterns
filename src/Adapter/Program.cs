// See https://aka.ms/new-console-template for more information
using Adapter.Concept;
using Adapter.Concept.AvaFilters;
using Adapter.Exercise;
using Adapter.Exercise.Gmail;

Console.WriteLine("Adaptor Design Pattern!");

var imageView = new ImageView(new Image());
imageView.Apply(new VividFilter());
imageView.Apply(new CaramelAdapter(new Caramel()));

var emailProvider = new EmailClient();
emailProvider.AddProvider(new GmailAdapter(new GmailClient()));
emailProvider.DownLoadEmails();