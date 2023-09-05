namespace DocumentExtractor.Models
{
   


   

    public class BoundingPolygon
    {
        public bool IsEmpty { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class BoundingRegion
    {
        public int PageNumber { get; set; }
        public List<BoundingPolygon> BoundingPolygon { get; set; }
    }

    //public class TableCell
    //{
        //public Kind Kind { get; set; }
        //public int RowSpan { get; set; }
        //public int ColumnSpan { get; set; }
        //public int RowIndex { get; set; }
        //public int ColumnIndex { get; set; }
       // public List<Dictionary<string, string>> Cell { get; set; } = new List<Dictionary<string, string>>();
        //public List<BoundingRegion> BoundingRegions { get; set; }
        //public List<Span> Spans { get; set; }
   // }

    //public class Cell
    //{
      
    //    public List<Header> header { get; set; } = new List<Header>();
       
    //}



    public class Kind
    {
    }

    public class DocumentModel
    {
        //public int RowCount { get; set; }
        //public int ColumnCount { get; set; }
        public List<TableCell> Cells { get; set; }
        //public List<BoundingRegion> BoundingRegions { get; set; }
        //public List<Span> Spans { get; set; }
    }

    public class Span
    {
        public int Index { get; set; }
        public int Length { get; set; }
    }


}
