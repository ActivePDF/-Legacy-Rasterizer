using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasterizer_Examples.Examples
{
    class ImageRotation
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

                for (int currentPage = 1; currentPage <= pageCount; currentPage++)
                {
                    // Image Format
                    rasterizer.ImageFormat = APRasterizerNET.ImageType.ImgJPEG;

                    // Output Type
                    rasterizer.OutputFormat =
                        APRasterizerNET.OutputFormatType.OutFile;

                    // Rotate the image 180 degrees
                    rasterizer.Rotation = 180;

                    // Other settings
                    rasterizer.OutputFileName =
                        $@"..\..\..\Output\RotateImage.Page.{currentPage}.jpg";

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
