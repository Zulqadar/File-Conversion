//For PDF Focus Follow The Below Nuget Package URL
//URL=> https://www.nuget.org/packages/sautinsoft.pdffocus/
  
  public static void PdfToExcelAsByteArray()
        {
            string pdfFile = @"d:\Table.pdf";
            byte[] pdfBytes = File.ReadAllBytes(pdfFile);
            byte[] excelBytes = null;

            PdfFocus f = new PdfFocus();

            f.OpenPdf(pdfBytes);
            // 'true' = Convert all data to spreadsheet (tabular and even textual).
            // 'false' = Skip textual data and convert only tabular (tables) data.
            f.ExcelOptions.ConvertNonTabularDataToSpreadsheet = true;

            // 'true'  = Preserve original page layout.
            // 'false' = Place tables before text.
            f.ExcelOptions.PreservePageLayout = true;

            if (f.PageCount > 0)
            {
                excelBytes = f.ToExcel();
            }
        }
