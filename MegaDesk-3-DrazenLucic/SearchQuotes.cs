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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void populateGrid(string materialDescr)
        {
            dataGridView1.Rows.Clear();
            List<DeskQuote> quotes = Program.Quotes.GetFiltered(materialDescr);
            foreach (DeskQuote quote in quotes)
            {
                dataGridView1.Rows.Add(quote.GridRow);
            }
        }

        private void cboSurfaceMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            populateGrid(cboSurfaceMaterial.Text);
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            cboSurfaceMaterial.SelectedItem = "All";
            populateGrid("All");
        }
    }
}
