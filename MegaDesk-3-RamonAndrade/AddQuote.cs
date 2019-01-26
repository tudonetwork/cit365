using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void buttonSendAddQuote_Click(object sender, EventArgs e)
        {

            // Here will be the send form

        }


        private void widthInput_Validating(object sender, EventArgs e)
        {
            string errorMsg;

            if(widthInput.Text.Length > 0)
            {
     
                double w;
                if (Double.TryParse(widthInput.Text.Trim(), out w))
                {
                    double widthInp = double.Parse(widthInput.Text);

                    if (!ValidWidthInput(widthInp, out errorMsg))
                    {
                        widthInput.Select(0, widthInput.Text.Length);
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

        public bool ValidWidthInput(double width, out string errorMessage)
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

                double d;
                if (Double.TryParse(depthInput.Text.Trim(), out d))
                {
                    double depthInp = double.Parse(depthInput.Text);

                    if (!ValidWidthInput(depthInp, out errorMsg2))
                    {
                        depthInput.Select(0, depthInput.Text.Length);
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

        public bool ValidDepthInput(double depth, out string errorMessage)
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
