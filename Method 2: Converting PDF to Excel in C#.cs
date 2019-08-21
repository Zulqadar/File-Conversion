//For PDF Focus Follow The Below Nuget Package URL
//URL=> https://www.nuget.org/packages/sautinsoft.pdffocus/

public static void PdfToExcelAsMemoryStream()
        {
            string pdfFile = @"d:\Table.pdf";

            PdfFocus f = new PdfFocus();

            using (FileStream pdfStream = new FileStream(pdfFile, FileMode.Open))
            {
                f.OpenPdf(pdfStream);
                // 'true' = Convert all data to spreadsheet (tabular and even textual).
                // 'false' = Skip textual data and convert only tabular (tables) data.
                f.ExcelOptions.ConvertNonTabularDataToSpreadsheet = true;

                // 'true'  = Preserve original page layout.
                // 'false' = Place tables before text.
                f.ExcelOptions.PreservePageLayout = true;

                if (f.PageCount > 0)
                {
                    using (MemoryStream excelStream = new MemoryStream(f.ToExcel()))
                    {
                        // Here we have the .xls result as MemoryStream.
                    }
                }
            }
        }
