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
    public partial class SearchQuotes : Form
    {
        MainMenu mainMenu;
        public SearchQuotes(MainMenu mainM)
        {
            InitializeComponent();

            mainMenu = mainM;

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                  .Cast<DesktopMaterial>()
                  .ToList();
            
            comboBox1.DataSource = materials;
            comboBox1.SelectedIndex = -1;
            
            loadGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((DesktopMaterial)combo.SelectedValue);
            }
        }

        /* Notes from Class */
        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                searchDataGridView.DataSource = deskQuotes
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

        private void loadGrid(DesktopMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                searchDataGridView.DataSource = deskQuotes
                      .Select(d => new
                      {
                          Date = d.QuoteDate,
                          Customer = d.CustomerName,
                          Depth = d.Desk.Depth,
                          Width = d.Desk.Width,
                          Drawers = d.Desk.NumberOfDrawers,
                          SurfaceMaterial = d.Desk.DesktopMaterial,
                          DeliveryType = d.Delivery,
                          QuoteAmount = d.FinalPrice
                      })
                      .Where(q => q.SurfaceMaterial == desktopMaterial)
                      .ToList();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.Show();
        }
    }
}
