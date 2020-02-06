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
  public partial class AddQuote : Form
  {
    MainMenu mainMenu;
    public AddQuote(MainMenu mainM)
    {
      mainMenu = mainM;
      InitializeComponent();

      List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                                                          .Cast<DesktopMaterial>()
                                                            .ToList();
      ComDesktopMaterial.DataSource = materials;
      ComDesktopMaterial.SelectedIndex = -1;
      List<Delivery> delivery = Enum.GetValues(typeof(Delivery))
                                                  .Cast<Delivery>()
                                                    .ToList();
      ComDelivery.DataSource = delivery;
      ComDelivery.SelectedIndex = -1;
    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
      mainMenu.Show();
      this.Close();
    }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
          mainMenu.Show();
        }

    private void BtnSaveExit_Click(object sender, EventArgs e)
    {
      Desk userDesk = new Desk();
      userDesk.Width = (int)(NumDeskWidth.Value);
      userDesk.Depth = (int)(NumDeskHeight.Value);
      userDesk.NumberOfDrawers = (int)(NumDrawerTotal.Value);
      userDesk.DesktopMaterial = (DesktopMaterial)ComDesktopMaterial.SelectedItem;
      DeskQuote userQuote = new DeskQuote();
      userQuote.CustomerName = TxtCustomerName.Text;
      userQuote.Delivery = Convert.ToInt32(ComDelivery.SelectedValue);
      userQuote.Desk = userDesk;
      userQuote.getRushOrderPrices();
      userQuote.CalculateDeskQuote();
      outputQuote.Text = "Quote: $" + userQuote.FinalPrice.ToString();
    }
  }
}
