namespace MegaDesk_HarmonyDurfee
{
  partial class MainMenu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnAddQuote = new System.Windows.Forms.Button();
      this.BtnViewQuotes = new System.Windows.Forms.Button();
      this.BtnSearchQuotes = new System.Windows.Forms.Button();
      this.BtnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnAddQuote
      // 
      this.BtnAddQuote.Location = new System.Drawing.Point(141, 105);
      this.BtnAddQuote.Name = "BtnAddQuote";
      this.BtnAddQuote.Size = new System.Drawing.Size(337, 131);
      this.BtnAddQuote.TabIndex = 1;
      this.BtnAddQuote.Text = "Add New Quote";
      this.BtnAddQuote.UseVisualStyleBackColor = true;
      this.BtnAddQuote.Click += new System.EventHandler(this.BtnAddQuote_Click);
      // 
      // BtnViewQuotes
      // 
      this.BtnViewQuotes.Location = new System.Drawing.Point(141, 299);
      this.BtnViewQuotes.Name = "BtnViewQuotes";
      this.BtnViewQuotes.Size = new System.Drawing.Size(337, 131);
      this.BtnViewQuotes.TabIndex = 2;
      this.BtnViewQuotes.Text = "View Quotes";
      this.BtnViewQuotes.UseVisualStyleBackColor = true;
      this.BtnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes_Click);
      // 
      // BtnSearchQuotes
      // 
      this.BtnSearchQuotes.Location = new System.Drawing.Point(141, 498);
      this.BtnSearchQuotes.Name = "BtnSearchQuotes";
      this.BtnSearchQuotes.Size = new System.Drawing.Size(337, 131);
      this.BtnSearchQuotes.TabIndex = 3;
      this.BtnSearchQuotes.Text = "Search Quotes";
      this.BtnSearchQuotes.UseVisualStyleBackColor = true;
      this.BtnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes_Click);
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(141, 693);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(337, 131);
      this.BtnExit.TabIndex = 4;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(613, 930);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.BtnSearchQuotes);
      this.Controls.Add(this.BtnViewQuotes);
      this.Controls.Add(this.BtnAddQuote);
      this.Name = "MainMenu";
      this.Text = "Main Menu";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnAddQuote;
    private System.Windows.Forms.Button BtnViewQuotes;
    private System.Windows.Forms.Button BtnSearchQuotes;
    private System.Windows.Forms.Button BtnExit;
  }
}

