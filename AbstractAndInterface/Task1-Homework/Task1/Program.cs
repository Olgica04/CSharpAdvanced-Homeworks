using Task1.Domain.Models;

WebPage webPage = new WebPage(1, "www.page.com/index.html", " This Page contains words of any  kind! How many words? ExAmPle: one, two, three");
Console.WriteLine($"Word you are searching for is: {webPage.Search("kind")}");
Console.WriteLine($"Word you are searching for is: {webPage.Search(",")}");

Document document = new Document(1, "FirstDocument", "This is a shrot description for document! This document contains names: Ivana, Dejan Dimitar...");
Console.WriteLine($"Word you are searching for is: {document.Search("description")}");
Console.WriteLine($"Word you are searching for is: {document.Search("want")}");

