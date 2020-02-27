namespace MegaDesk
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
      this.BtnExit = new System.Windows.Forms.Button();
      this.BtnSearchQuotes = new System.Windows.Forms.Button();
      this.BtnViewQuotes = new System.Windows.Forms.Button();
      this.BtnAddNewQuote = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(117, 318);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(177, 84);
      this.BtnExit.TabIndex = 7;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // BtnSearchQuotes
      // 
      this.BtnSearchQuotes.Location = new System.Drawing.Point(117, 228);
      this.BtnSearchQuotes.Name = "BtnSearchQuotes";
      this.BtnSearchQuotes.Size = new System.Drawing.Size(177, 84);
      this.BtnSearchQuotes.TabIndex = 6;
      this.BtnSearchQuotes.Text = "Search Quotes";
      this.BtnSearchQuotes.UseVisualStyleBackColor = true;
      this.BtnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes_Click);
      // 
      // BtnViewQuotes
      // 
      this.BtnViewQuotes.Location = new System.Drawing.Point(117, 138);
      this.BtnViewQuotes.Name = "BtnViewQuotes";
      this.BtnViewQuotes.Size = new System.Drawing.Size(177, 84);
      this.BtnViewQuotes.TabIndex = 5;
      this.BtnViewQuotes.Text = "View Quotes";
      this.BtnViewQuotes.UseVisualStyleBackColor = true;
      this.BtnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes_Click);
      // 
      // BtnAddNewQuote
      // 
      this.BtnAddNewQuote.Location = new System.Drawing.Point(117, 48);
      this.BtnAddNewQuote.Name = "BtnAddNewQuote";
      this.BtnAddNewQuote.Size = new System.Drawing.Size(177, 84);
      this.BtnAddNewQuote.TabIndex = 4;
      this.BtnAddNewQuote.Text = "Add New Quote";
      this.BtnAddNewQuote.UseVisualStyleBackColor = true;
      this.BtnAddNewQuote.Click += new System.EventHandler(this.BtnAddNewQuote_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(405, 446);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.BtnSearchQuotes);
      this.Controls.Add(this.BtnViewQuotes);
      this.Controls.Add(this.BtnAddNewQuote);
      this.Name = "MainMenu";
      this.Text = "MegaDesk";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSearchQuotes;
        private System.Windows.Forms.Button BtnViewQuotes;
        private System.Windows.Forms.Button BtnAddNewQuote;
    }
}

