using Newtonsoft.Json;
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

namespace MegaDesk_HarmonyDurfee
{
    public partial class ViewAllQuotes : Form
    {
        MainMenu mainMenu;
        public ViewAllQuotes(MainMenu mainM)
        {
            mainMenu = mainM;
            InitializeComponent();

            loadGrid();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes
                      .Select(d => new
                      {
                          Date = d.QuoteDate,
                          Customer = d.CustomerName,
                          Depth = d.Desk.Depth,
                          Width = d.Desk.Width,
                          Drawers = d.Desk.NumberOfDrawers,
                          SurfaceMaterial = d.Desk.DesktopMaterial,
                          DeliveryType = d.Delivery,
                          QuoteAmount = d.FinalPrice.ToString("c")
                      }).ToList();
            }
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
