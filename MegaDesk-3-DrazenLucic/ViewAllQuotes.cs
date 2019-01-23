using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void ViewAllQuotes_Activated(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            List<DeskQuote> quotes = mainMenu.DeskQuotes.getAll();
            foreach (DeskQuote quote in quotes)
            {
                Desk desk = quote.QuotedDesk;
                string[] row = {
                    desk.CustomerName,
                    String.Format("{0,10:dd-MMM-yy}", quote.QuoteDate),
                    desk.Width.ToString(),
                    desk.Depth.ToString(),
                    desk.SurfaceArea.ToString(),
                    desk.SurfaceMaterialDescr,
                    desk.NumberOfDrawers.ToString(),
                    desk.ProductionTime.ToString() + " days",
                    String.Format("{0,10:$0.00}", quote.QuoteAmount)
                };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
