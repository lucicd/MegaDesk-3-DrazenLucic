using System;
using System.Windows.Forms;

namespace MegaDesk_3_DrazenLucic
{
    public partial class AddQuote : Form
    {
        bool cancelInProgress = false;

        public AddQuote()
        {
            InitializeComponent();
            cancelInProgress = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelInProgress = true;
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
            if (!ValidForm()) return;
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

            newDesk.SurfaceMaterial = Program.SurfaceMaterialId(cboSurfaceMaterial.Text);

            Program.Quotes.Add(newDesk.Quote);

            DisplayQuote displayQuoteForm = new DisplayQuote(newDesk.Quote);
            displayQuoteForm.Tag = mainMenu;
            displayQuoteForm.Show(mainMenu);
            Close();
        }

        private void nupField_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            selectBoxValue(answerBox);
        }

        private void nupDeskWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidWidth();
        }

        private void nupDeskDepth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidDepth();
        }

        // Set the ErrorProvider error with the text to display for desk width. 
        private bool ValidWidth()
        {
            int width = (int)nupDeskWidth.Value;
            if (width > Desk.MAX_WIDTH)
            {
                errorProvider1.SetError(nupDeskWidth,
                    "Maximum allowed width is " + Desk.MAX_WIDTH + " inches.");
                return false;
            }

            if (width < Desk.MIN_WIDTH)
            {
                errorProvider1.SetError(nupDeskWidth, 
                    "Minimum allowed width is " + Desk.MIN_WIDTH + " inches.");
                return false;
            }

            errorProvider1.SetError(nupDeskWidth, "");
            return true;
        }

        // Set the ErrorProvider error with the text to display for desk depth. 
        private bool ValidDepth()
        {
            int depth = (int)nupDeskDepth.Value;
            if (depth > Desk.MAX_DEPTH)
            {
                errorProvider1.SetError(nupDeskDepth,
                    "Maximum allowed depth is " + Desk.MAX_DEPTH + " inches.");
                return false;
            }

            if (depth < Desk.MIN_DEPTH)
            {
                errorProvider1.SetError(nupDeskDepth,
                    "Minimum allowed depth is " + Desk.MIN_DEPTH + " inches.");
                return false;
            }

            errorProvider1.SetError(nupDeskDepth, "");
            return true;
        }

        private void selectBoxValue(NumericUpDown box)
        {
            if (box != null)
            {
                int lengthOfAnswer = box.Value.ToString().Length;
                box.Select(0, lengthOfAnswer);
            }
        }

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;

        private void cboNumberOfDrawers_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = NumberKeyValidator.CheckKeyDown(sender, e);
        }

        private void cboNumberOfDrawers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                errorProvider1.SetError(cboNumberOfDrawers, "Only numbers are allowed.");
            }
            else
            {
                errorProvider1.SetError(cboNumberOfDrawers, "");
            }
        }

        private void txtCustomerName_Validating(object sender,
            System.ComponentModel.CancelEventArgs e)
        {
            ValidCustomerName();
        }

        private bool ValidCustomerName()
        {
            if (txtCustomerName.Text.Length == 0)
            {
                errorProvider1.SetError(txtCustomerName,
                    "Customer name is mandatory.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCustomerName, "");
                return true;
            }
        }

        private bool ValidForm()
        {
            if (!ValidCustomerName())
            {
                txtCustomerName.Focus();
                return false;
            }
            if (!ValidWidth())
            {
                nupDeskWidth.Focus();
                return false;
            }
            if (!ValidDepth())
            {
                nupDeskDepth.Focus();
                return false;
            }
            return true;
        }
    }
}