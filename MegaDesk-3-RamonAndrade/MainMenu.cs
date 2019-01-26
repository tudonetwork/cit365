using System;
using System.Windows.Forms;

namespace MegaDesk_3_RamonAndrade
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuoteForm addNewQuoteForm = new AddQuoteForm();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();


        }

        private void openViewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void openSearchQuoteButton_Click(object sender, EventArgs e)
        {

            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
