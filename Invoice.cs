using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsigurariDeViataSiBunuri
{
    public partial class Invoice : Form
    {
        Bitmap memorying;
        public Invoice(Client c, double sum)
        {
            InitializeComponent();
            tbClientName.Text = c.FamilyName + " " + c.GivenName;
            tbPayment.Text = sum.ToString();
        }

        private void printPanel(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            panel.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle r = e.PageBounds;
            e.Graphics.DrawImage(memorying, (r.Width / 2) - (this.panel.Width / 2), this.panel.Location.Y);
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel = pnl;
            printPanel(pnl);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Print(panel);
        }
    }
}
