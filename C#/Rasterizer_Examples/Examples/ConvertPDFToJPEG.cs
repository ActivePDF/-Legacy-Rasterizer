
using System;

namespace Rasterizer_Examples.Examples
{
    class ConvertPDFToJPEG
    {
        public static void Example()
        {
            using (APRasterizerNET.Rasterizer rasterizer =
                new APRasterizerNET.Rasterizer())
            {
                // Open PDF
                rasterizer.OpenFile(@"..\..\..\Input\Rasterizer.Input.pdf");

                // Get page count of open file
                int pageCount = rasterizer.NumPages();

                for (int currentPage=1; currentPage<=pageCount; currentPage++)
                {
                    // Image Format
                    rasterizer.ImageFormat = APRasterizerNET.ImageType.ImgJPEG;

                    // Output Type
                    rasterizer.OutputFormat =
                        APRasterizerNET.OutputFormatType.OutFile;

                    // Other settings
                    rasterizer.OutputFileName =
                        $@"..\..\..\Output\ConvertPDFToJPEG.Page.{currentPage}.jpg";

                    // Render the current page
                    rasterizer.RenderPage(currentPage);

                    // Check for errors
                    if (rasterizer.LastError != 0)
                    {
                        Console.WriteLine($"Error rendering page {currentPage}: {rasterizer.LastErrorMessage}");
                    }
                }
            }

            // Process Complete
            Console.WriteLine("PDF conversion to JPEG complete.");
        }
    }
}
