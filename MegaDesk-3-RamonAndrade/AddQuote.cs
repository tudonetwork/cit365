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
    public partial class AddQuoteForm : Form
    {

        public AddQuoteForm()
        {
            InitializeComponent();

            Desk desk = new Desk();

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopMaterialComboBox.DataSource = materials;

            var _rush = desk.rushList;
            rushInput.DataSource = _rush;

            var _drawers = desk.drawerList;
            this.drawersInput.DataSource = _drawers;
           
        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void buttonSendAddQuote_Click(object sender, EventArgs e)
        {

            if (checkFields())
            {

                try
                {

                    Desk deskObj = new Desk(
                         Convert.ToInt32(widthInput.Text.ToString()),
                         Convert.ToInt32(depthInput.Text.ToString()),
                         Convert.ToInt32(drawersInput.SelectedIndex.ToString()),
                         Convert.ToInt32(rushInput.SelectedIndex.ToString()),
                         (DesktopMaterial)desktopMaterialComboBox.SelectedItem
                     );
      
                    DeskQuotes quote = new DeskQuotes(customerInput.Text, deskObj);

                    // Write in a file
                    StreamWriter writer = new StreamWriter("quotes.txt", true);
                    writer.WriteLine(customerInput.Text + ',' + DateTime.Now.ToString("MM/dd/yyyy") + ',' + deskObj.width + ',' + deskObj.depth + ',' + deskObj.surface + ',' + deskObj.drawers + ',' + deskObj.rush + ',' + quote.calcTotalCost().ToString());
                    writer.Close();


                    DisplayQuote displayQuote = new DisplayQuote(deskObj, quote)
                    {
                        Tag = this
                    };
                    displayQuote.Show(this);
                    Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Make sure the inputs are correct, and try submitting again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Please fill all fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public bool checkFields()
        {
            if (customerInput.Text != "" && depthInput.Text != "" && widthInput.Text != ""
                && drawersInput.Text != "" && rushInput.Text != "")
            {
                return true;
            }

            return false;
        }


        private void widthInput_Validating(object sender, EventArgs e)
        {
            string errorMsg;

            if(widthInput.Text.Length > 0)
            {
     
                int w;
                if (int.TryParse(widthInput.Text.Trim(), out w))
                {
                    int widthInp = int.Parse(widthInput.Text);

                    if (!ValidWidthInput(widthInp, out errorMsg))
                    {
                        this.errorProvider2.SetError(widthInput, errorMsg);
                    }
                } else {
                    this.errorProvider2.SetError(widthInput, "The input must be numbers!");
                }

            } else {
                this.errorProvider2.SetError(widthInput, "You must input numbers!");
            }

        }

        private void widthInput_Validated(object sender, EventArgs e)
        {

            errorProvider2.SetError(widthInput, "");
        }

        public bool ValidWidthInput(int width, out string errorMessage)
        {
 
            if (width < 24 || width > 96)
            {
                errorMessage = "Invalid input. The width must be between 24' and 96' ";
                return false;
            }
            else {
                errorMessage = "";
                return true;
            }

        }


        private void depthInput_Validating(object sender, EventArgs e)
        {
            string errorMsg2;

            if (depthInput.Text.Length > 0)
            {

                int d;
                if (int.TryParse(depthInput.Text.Trim(), out d))
                {
                    int depthInp = int.Parse(depthInput.Text);

                    if (!ValidDepthInput(depthInp, out errorMsg2))
                    {
                        this.errorProvider3.SetError(depthInput, errorMsg2);
                    }
                }
                else
                {
                    this.errorProvider3.SetError(depthInput, "The input must be numbers!");
                }

            }
            else
            {
                this.errorProvider3.SetError(depthInput, "You must input numbers!");
            }

        }

        private void depthInput_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(depthInput, "");
        }

        public bool ValidDepthInput(int depth, out string errorMessage)
        {

            if (depth < 12 || depth > 48)
            {
                errorMessage = "Invalid input. The depth must be between 12' and 48' ";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }

        }

   
    }
}
