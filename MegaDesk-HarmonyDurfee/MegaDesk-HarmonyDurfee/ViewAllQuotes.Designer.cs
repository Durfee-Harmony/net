namespace MegaDesk_HarmonyDurfee
{
  partial class ViewAllQuotes
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
      this.SuspendLayout();
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(293, 185);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(214, 80);
      this.BtnExit.TabIndex = 16;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // ViewAllQuotes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.BtnExit);
      this.Name = "ViewAllQuotes";
      this.Text = "ViewAllQuotes";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button BtnExit;
    }
}