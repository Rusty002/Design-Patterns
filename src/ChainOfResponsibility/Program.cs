// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility.Concept;
using ChainOfResponsibility.Exercise;

Console.WriteLine("Chain Of Resposibility Pattern!");

// authentication --> Logger --> Compressor --> Encryptor
var encryptor = new Encryptor(null);
var compressor = new Compressor(encryptor);
var logger = new Logger(compressor);
var authenticator  = new Authenticator(logger);

var request = new WebServer(authenticator);

request.Handle(new HTTPRequest("admin", "1234"));


// Compressor --> authenticate --> logger


var logger2 = new Logger(null);
var authenticator2 = new Authenticator(logger2);
var compressor2 = new Compressor(authenticator2);

var request2 = new WebServer(compressor2);
request2.Handle(new HTTPRequest("admin", "1234"));

// Authenticate --> Mac --> Excel --> QuickBook
var quickbook = new QuickBooks(null);
var excel = new ExcelSpreadSheet(quickbook);
var mac = new MacSpreadSheet(excel);
var fileAuthenticator = new FileAuthenticate(mac);

var fileRequest = new MemoryBlock(fileAuthenticator);
fileRequest.Handle(new DataReader("MySpreadSheet"));