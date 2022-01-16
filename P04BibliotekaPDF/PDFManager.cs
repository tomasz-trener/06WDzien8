using P03AplikacjaZawodnicy.ViewModels;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Tools
{
     public class PDFManager
    {
        public string StworzPDF(ZawodnikVM[] zawodnicy)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            for (int i = 0; i < zawodnicy.Length; i++)
                gfx.DrawString(zawodnicy[i].ImieNazwisko, font, XBrushes.Black, 20, 20+40*i);
            
            

            // Save the document...
            string filename = DateTime.Now.ToString("ddMMyyyyHHmm")+ "HelloWorld.pdf";
            document.Save(filename);
            // ...and start a viewer.
            //  Process.Start(filename);

            return filename;
        }
    }
}
