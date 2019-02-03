using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_RamonAndrade
{
    public partial class DisplayQuote : Form
    {

        public DisplayQuote(Desk desk, DeskQuotes deskQuote)
        {
            InitializeComponent();

            quoteName.Text = deskQuote.name.ToString();
            width.Text = desk.width.ToString();
            depth.Text = desk.depth.ToString();
            surface.Text = desk.surface.ToString();
            drawers.Text = desk.drawers.ToString();
            rushLabel.Text = desk.rush.ToString() + " days";

            cost.Text = "$ " + deskQuote.calcTotalCost().ToString();

        }

        private void cancelDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        
    }
}
