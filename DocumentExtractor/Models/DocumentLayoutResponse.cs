using Azure.AI.FormRecognizer.DocumentAnalysis;

namespace DocumentExtractor.Models;

public class DocumentLayoutResponse
{
    public DocumentLayoutResponse()
    {
        pageResponses = new List<DocumentPageResponse>();
        tables = new List<DocumentTable>();
    }
    public List<DocumentPageResponse> pageResponses { get; set; }
    public List<DocumentParagraph> Paragraphs { get; set; }
    public List<DocumentTable>  tables { get; set; }

    public List<TableCell> tableCells { get; set; }
}

public class TableCell
{
    //public Kind Kind { get; set; }
    //public int RowSpan { get; set; }
    //public int ColumnSpan { get; set; }
    //public int RowIndex { get; set; }
    //public int ColumnIndex { get; set; }
    public List<Dictionary<string, string>> Cell { get; set; } = new List<Dictionary<string, string>>();
    //public List<BoundingRegion> BoundingRegions { get; set; }
    //public List<Span> Spans { get; set; }
}

public class DocumentPageResponse
{
    public DocumentPageResponse()
    {
        
    }
    public DocumentPage pages { get; set; }
    public int LineCount { get; set; }
    public int WordCount { get; set; }
    
    
}