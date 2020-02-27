using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk
{
  public partial class ViewAllQuotes : Form
  {
    MainMenu mainMenu;
    public ViewAllQuotes(MainMenu mainMenu)
    {
      InitializeComponent();
      this.mainMenu = mainMenu;
            loadGrid();
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.DaysToComplete,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    DaysToComplete = d.DaysToComplete,
                    QuoteAmount = d.FinalPrice.ToString("C")
                }).ToList();

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
          this.mainMenu.Show();
          this.Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
          this.mainMenu.Show();
        }
    }
}
