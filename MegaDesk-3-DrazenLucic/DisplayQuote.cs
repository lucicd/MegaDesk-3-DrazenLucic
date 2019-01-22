using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote quote;

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }



        private void ShowQuote()
        {
            Desk desk = quote.QuotedDesk;
            lblCustomerName.Text = desk.CustomerName;
            lblDeskWidth.Text = desk.Width.ToString();
            lblDeskDepth.Text = desk.Depth.ToString();
            lblSurfaceArea.Text = desk.SurfaceArea.ToString();
            lblNumberOfDrawers.Text = desk.NumberOfDrawers.ToString();
            lblNumberOfDrawers.Text = desk.SurfaceMaterialDescr;
            lblProductionTime.Text = desk.ProductionTime.ToString();

            lblOrderDate.Text = quote.QuoteDate.ToShortTimeString();
            lblBasePrice.Text = quote.BasePrice.ToString("C");
            lblAreaSurcharge.Text = quote.SurfaceAddon.ToString("C");
            lblMaterialSurcharge.Text = quote.MaterialAddon.ToString("C");
            lblDrawersSurcharge.Text = quote.DrawersAddon.ToString("C");
            lblRushOrderSurcharge.Text = quote.RushOrderAddon.ToString("C");
            lblTotalPrice.Text = quote.QuoteAmount.ToString("C");
        }

        private void DisplayQuote_Shown(object sender, EventArgs e)
        {
            ShowQuote();
        }
    }
}
