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

            if (rboProductionTime3.Checked)
            {
                newDesk.ProductionTime = 3;
            }
            else if (rboProductionTime5.Checked)
            {
                newDesk.ProductionTime = 5;
            }
            else if (rboProductionTime7.Checked)
            {
                newDesk.ProductionTime = 7;
            }
            else
            {
                newDesk.ProductionTime = 14;
            }

            newDesk.SurfaceMaterial = newDesk.SurfaceMaterialId(cboSurfaceMaterial.Text);

            DisplayQuote displayQuoteForm = new DisplayQuote(newDesk.Quote);
            displayQuoteForm.Tag = mainMenu;
            displayQuoteForm.Show(mainMenu);
            Close();
        }

        private void nupField_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}