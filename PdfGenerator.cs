using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;

public class PdfGenerator
{
    public static byte[] CreatePdf()
    {
        using (var memoryStream = new MemoryStream())
        {

            if (Capabilities.Build.IsCoreBuild)
                GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Generated with PDFsharp";
            document.Info.Subject = "Just a simple Hello-World program.";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Draw two lines with a red default pen.
            var width = page.Width;
            var height = page.Height;
            gfx.DrawLine(XPens.Red, 0, 0, width, height);
            gfx.DrawLine(XPens.Red, width, 0, 0, height);

            // Draw a circle with a red pen and white brush.
            var radius = width / 5;
            gfx.DrawEllipse(new XPen(XColors.Red, 1.5), XBrushes.White, new XRect(width / 2 - radius, height / 2 - radius, 2 * radius, 2 * radius));

            // Create a font.
            XFont font = new XFont("Times New Roman", 20, XFontStyleEx.BoldItalic);

            // Draw the text.
            gfx.DrawString("Hello, PDFsharp!", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            // Save the document to the memory stream
            document.Save(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
