using System;
using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            cboNumberOfDrawers.SelectedItem = "0";
            cboSurfaceMaterial.SelectedItem = "Oak";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            Desk newDesk = new Desk();
            newDesk.CustomerName = txtCustomerName.Text;
            newDesk.Depth = (int)nupDeskDepth.Value;
            newDesk.Width = (int)nupDeskWidth.Value;
            newDesk.NumberOfDrawers = Int32.Parse(cboNumberOfDrawers.Text);
            newDesk.ProductionTime = 14;
            newDesk.SurfaceMaterial = Materials.Laminate;

            DisplayQuote displayQuoteForm = new DisplayQuote(newDesk.Quote);
            displayQuoteForm.Tag = mainMenu;
            displayQuoteForm.Show(mainMenu);
            Close();
        }
    }
}