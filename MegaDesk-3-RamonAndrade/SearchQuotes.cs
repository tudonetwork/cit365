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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<DesktopMaterial> materialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            materialBox.DataSource = materialList;
        }

        private void searchCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void materialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quoteList.Items.Clear();
            StreamReader reader = new StreamReader("quotes.txt");
            List<string> orders = new List<string>();
            while (!reader.EndOfStream)
            {
                orders.Add(reader.ReadLine());
            }

            for (int i = 0; i < orders.Count; ++i)
            {
                if (orders[i].Contains(materialBox.Text))
                {
                    string[] w = orders[i].Split(',');
                    quoteList.Items.Add(
                        w[0] + " | Date: " +
                        w[1] + " | Width: " +
                        w[2] + " | Depth: " +
                        w[3] + " | Material: " +
                        w[4] + " | Drawers: " +
                        w[5] + " | Rush: " +
                        w[6] + " Days | Total: $" +
                        w[7]);
                }
            }
        }
    }
}
