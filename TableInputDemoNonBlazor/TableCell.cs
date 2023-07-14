namespace TableInputDemoNonBlazor
    {
    public class TableCell
        {
        public string ColName { get; set; } = string.Empty;
        public string CSSClass { get; set; } = string.Empty;
        public int Index_Col { get; set; }
        public int Index_Row { get; set; }
        public decimal Value_Dec { get; set; }
        public string Value_Formatted { get; set; } = string.Empty;

        public TableCell()
            {
            }
        }
    }
