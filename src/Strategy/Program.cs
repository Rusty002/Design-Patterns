// See https://aka.ms/new-console-template for more information
using Strategy.Concept;
using Strategy.Exercise;

Console.WriteLine("Hello, World!");

ImageStorage imageStorage = new ImageStorage();
imageStorage.Store("text.txt", new PNGCompressor(), new BlackFilter());
imageStorage.Store("text.txt", new JPEGCompressor(), new WhiteFilter());

ChatClient chatClient = new ChatClient();

chatClient.Send("This is a test message", new AESEncryption());
chatClient.Send("This is a test message", new DESEncryption());