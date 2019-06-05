using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasterizer_Examples.Examples
{
    class CreateMultipageTIFF
    {
        public static void Example()
        {
            using (APRasterizerNET.Rasterizer rasterizer =
                new APRasterizerNET.Rasterizer())
            {
                // Open PDF
                rasterizer.OpenFile(@"..\..\..\Input\Rasterizer.Input.pdf");

                // Output Type
                rasterizer.OutputFormat = APRasterizerNET.OutputFormatType.OutFile;

                // Set the file path for the created TIFF
                rasterizer.OutputFileName = @"..\..\..\Output\Rasterizer.Output.tiff";

                // Set the pages to convert
                rasterizer.AddPageRange(1, 2);

                // Create the TIFF
                rasterizer.CreateMultipageTIFF();               

                // Check for errors
                if (rasterizer.LastError != 0)
                {
                    Console.WriteLine($"Error converting to TIFF: {rasterizer.LastErrorMessage}");
                }
            }

            // Process Complete
            Console.WriteLine("PDF conversion to TIFF complete.");
        }
    }
}
