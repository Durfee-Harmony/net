using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
      mainMenu = mainM;
      InitializeComponent();
    }

    /* Notes from Class
    private void loadGrid(Desk.DesktopMaterial desktopMaterial)
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
            etc
          }
      }
    }
    */

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
