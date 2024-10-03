using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure
{
    internal class ReceiptBuilder : IPDFBuilder
    {
        private PdfDocument _pdf;
        private XGraphics _graph;
        private XFont _font;
        private PdfPage _pdfPage;

        public void CreatePDF()
        {
            this._pdf = new PdfDocument();
        }

        public void SetTitle(string str)
        {
            this._pdf.Info.Title = str;
        }

        public void AddPage()
        {
            this._pdfPage = this._pdf.AddPage();
            this._graph = XGraphics.FromPdfPage(this._pdfPage);
            this._font = new XFont("Verdana", 12, XFontStyleEx.Bold);

            double rightMargin = 10; // Margin from the right edge
            double topMargin = 10;   // Margin from the top edge
            XRect dateRect = new XRect(this._pdfPage.Width - rightMargin, topMargin, 0, 0);
            string currentDate = DateTime.Today.ToString("d");

            this._graph.DrawString(currentDate, this._font, XBrushes.Black, dateRect, XStringFormats.TopRight);
        }

        public void AddItem(string desc, double price)
        {
            this._graph.DrawString($"Item desc: {desc}\nPrice: {price}", this._font, XBrushes.Black, new XRect(0, 0, this._pdfPage.Width.Point, this._pdfPage.Height.Point), XStringFormats.Center);
        }

        public void PrintReceipt()
        {
            string pdfFilename = "invoice.pdf";
            this._pdf.Save("C:\\Users\\mikae\\source\\repos\\Shop\\Shop\\Files\\" + pdfFilename);
        }
    }
}
