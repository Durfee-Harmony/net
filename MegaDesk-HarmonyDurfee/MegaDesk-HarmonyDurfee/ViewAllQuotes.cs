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
  public partial class ViewAllQuotes : Form
  {
    MainMenu mainMenu;
    public ViewAllQuotes(MainMenu mainM)
    {
      mainMenu = mainM;
      InitializeComponent();
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      mainMenu.Show();
      this.Close();
    }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
          mainMenu.Show();
        }
    }
}
