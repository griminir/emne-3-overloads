// See https://aka.ms/new-console-template for more information
using emne_3_overloads;

Console.WriteLine("Hello, World!");

var Mann1 = new Person("Oskar");
var Mann2 = new Person("kåre", 56);

Mann1.PrintWelcomeMsg();
Mann1.PrintWelcomeMsg("Henrik");

Mann1.PrintInfo();
Mann2.PrintInfo();