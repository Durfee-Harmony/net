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
  public partial class MainMenu : Form
  {
    public MainMenu()
    {
      InitializeComponent();



    }
    private void BtnAddQuote_Click(object sender, EventArgs e)
    {
      // add quote
      AddQuote addQuote = new AddQuote(this);
      addQuote.Tag = this;
      addQuote.Show();
      this.Hide();
    }

    private void BtnViewQuotes_Click(object sender, EventArgs e)
    {
      // view all quotes
      ViewAllQuotes viewAllQuotes = new ViewAllQuotes(this);
      viewAllQuotes.Tag = this;
      viewAllQuotes.Show();
      this.Hide();
    }

    private void BtnSearchQuotes_Click(object sender, EventArgs e)
    {
      // search quotes
      SearchQuotes searchQuotes = new SearchQuotes(this);
      searchQuotes.Tag = this;
      searchQuotes.Show();
      this.Hide();
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
