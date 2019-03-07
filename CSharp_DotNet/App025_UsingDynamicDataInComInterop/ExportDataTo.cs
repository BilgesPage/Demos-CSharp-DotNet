using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exc = Microsoft.Office.Interop.Excel;

//Referenced Interop library of Excel

namespace App025_UsingDynamicDataInComInterop
{
    class ExportDataTo
    {
        public static void ExportToExcel<T>(List<T> data)
        {
            // Create Excell application
            Exc.Application excApp = new Exc.Application();

            // Create empty excel workbook
            excApp.Workbooks.Add();

            // Identify worksheet
            Exc.Worksheet worksheet = excApp.ActiveSheet;

            // Identify column headings
            worksheet.Cells[1, "A"] = "COLOR";
            worksheet.Cells[1, "B"] = "BRAND";

            // Insert Car List data into excel cells
            int row = 2;
            foreach(var item in data as List<Car>)
            {
                worksheet.Cells[row, "A"] = item.Color;
                worksheet.Cells[row, "B"] = item.Brand;
                row++;   
            }

            worksheet.SaveAs($@"{Environment.CurrentDirectory}\Garage.xlsx");
            excApp.Quit();

            Console.WriteLine($"The garage list has been saved under this directory: {Environment.CurrentDirectory }");

        }
    }
}
