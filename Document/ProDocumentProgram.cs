namespace Document;

internal class ProDocumentProgram:DocumentProgram
{
    public override void EditDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public override  void SaveDocument()
    {
        Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }
}
