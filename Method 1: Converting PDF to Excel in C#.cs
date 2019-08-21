public static void PdfToExcelAsFiles()
        {
            string pdfFile = @"d:\Table.pdf";
            string excelFile = Path.ChangeExtension(pdfFile, ".xls");

            PdfFocus f = new PdfFocus();
            // 'true' = Convert all data to spreadsheet (tabular and even textual).
            // 'false' = Skip textual data and convert only tabular (tables) data.
            f.ExcelOptions.ConvertNonTabularDataToSpreadsheet = false;

            // 'true'  = Preserve original page layout.
            // 'false' = Place tables before text.
            f.ExcelOptions.PreservePageLayout = true;

            f.OpenPdf(pdfFile);

            if (f.PageCount > 0)
            {
                f.ToExcel(excelFile);
            }
        }
