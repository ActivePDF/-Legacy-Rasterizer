using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasterizer_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!System.IO.Directory.Exists(@"..\..\..\Output\"))
                {
                    System.IO.Directory.CreateDirectory(@"..\..\..\Output\");
                }

                Console.WriteLine("Converting PDF to JPG ...");
                Examples.ConvertPDFToJPEG.Example();
                Console.WriteLine("");

                Console.WriteLine("Converting PDF to multi page TIFF ...");
                Examples.CreateMultipageTIFF.Example();
                Console.WriteLine("");

                Console.WriteLine("Rotate image in output PDF ...");
                Examples.ImageRotation.Example();
                Console.WriteLine("");

                Console.WriteLine("Converting PDF to JPG with annotations ...");
                Examples.IncludeAnnotations.Example();
                Console.WriteLine("");

                Console.WriteLine("Invert the colors in the output image ...");
                Examples.InvertColors.Example();
                Console.WriteLine("");

                Console.WriteLine("Set the quality for output images ...");
                Examples.JPEGQuality.Example();
                Console.WriteLine("");

                Console.WriteLine("Set the size for output images ...");
                Examples.SetImageSize.Example();
                Console.WriteLine("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
