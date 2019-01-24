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
            lblSurfaceMaterial.Text = desk.SurfaceMaterialDescr;
            lblProductionTime.Text = desk.ProductionTime.ToString() + " days";

            lblOrderDate.Text = String.Format("{0,10:dd-MMM-yy}", quote.QuoteDate);
            lblBasePrice.Text = String.Format("{0,10:$0.00}", quote.BasePrice);
            lblAreaSurcharge.Text = String.Format("{0,10:$0.00}", quote.SurfaceAddon);
            lblMaterialSurcharge.Text = String.Format("{0,10:$0.00}", quote.MaterialAddon);
            lblDrawersSurcharge.Text = String.Format("{0,10:$0.00}", quote.DrawersAddon);
            lblRushOrderSurcharge.Text = String.Format("{0,10:$0.00}", quote.RushOrderAddon);
            lblTotalPrice.Text = String.Format("{0,10:$0.00}", quote.QuoteAmount);
        }

        private void DisplayQuote_Shown(object sender, EventArgs e)
        {
            ShowQuote();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var nextForm = (Form)Tag;
            nextForm.Show();
        }
    }
}
