using Document;
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter key (basic, pro, expert):");
        string key = Console.ReadLine();

        DocumentProgram docProgram;

        switch (key.ToLower())
        {
            case "pro":
                docProgram = new ProDocumentProgram();
                break;
            case "expert":
                docProgram = new ExpertDocument();
                break;
            case "basic":
            default:
                docProgram = new DocumentProgram();
                break;
        }

        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }
}
