﻿class Book
{
    public string Text { get; set; }
    public ConsolePrinter Printer { get; set; }
 
    public void Print()
    {
        Printer.Print(Text);
    }
}

class ConsolePrinter
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}