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

    private void BtnExit_Click(object sender, EventArgs e)
    {
      mainMenu.Show();
      this.Close();
    }
  }
}
