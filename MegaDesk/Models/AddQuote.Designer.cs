namespace MegaDesk
{
  partial class AddQuote
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
      this.TxtCustomerName = new System.Windows.Forms.TextBox();
      this.LblCustomerName = new System.Windows.Forms.Label();
      this.TxtDeskWidth = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.NumDeskWidth = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.NumDeskDepth = new System.Windows.Forms.NumericUpDown();
      this.NumNumberOfDrawers = new System.Windows.Forms.NumericUpDown();
      this.ComDesktopMaterial = new System.Windows.Forms.ComboBox();
      this.ComDaysToComplete = new System.Windows.Forms.ComboBox();
      this.BtnSaveQuote = new System.Windows.Forms.Button();
      this.BtnExit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskDepth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumNumberOfDrawers)).BeginInit();
      this.SuspendLayout();
      // 
      // TxtCustomerName
      // 
      this.TxtCustomerName.Location = new System.Drawing.Point(273, 63);
      this.TxtCustomerName.Name = "TxtCustomerName";
      this.TxtCustomerName.Size = new System.Drawing.Size(119, 22);
      this.TxtCustomerName.TabIndex = 0;
      // 
      // LblCustomerName
      // 
      this.LblCustomerName.AutoSize = true;
      this.LblCustomerName.Location = new System.Drawing.Point(101, 63);
      this.LblCustomerName.Name = "LblCustomerName";
      this.LblCustomerName.Size = new System.Drawing.Size(117, 17);
      this.LblCustomerName.TabIndex = 1;
      this.LblCustomerName.Text = "Enter your name:";
      // 
      // TxtDeskWidth
      // 
      this.TxtDeskWidth.AutoSize = true;
      this.TxtDeskWidth.Location = new System.Drawing.Point(101, 104);
      this.TxtDeskWidth.Name = "TxtDeskWidth";
      this.TxtDeskWidth.Size = new System.Drawing.Size(116, 17);
      this.TxtDeskWidth.TabIndex = 3;
      this.TxtDeskWidth.Text = "Enter desk width:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(101, 148);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 17);
      this.label2.TabIndex = 5;
      this.label2.Text = "Enter desk depth:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(101, 190);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(124, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "Enter drawer total:";
      // 
      // NumDeskWidth
      // 
      this.NumDeskWidth.Location = new System.Drawing.Point(273, 104);
      this.NumDeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
      this.NumDeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
      this.NumDeskWidth.Name = "NumDeskWidth";
      this.NumDeskWidth.Size = new System.Drawing.Size(120, 22);
      this.NumDeskWidth.TabIndex = 8;
      this.NumDeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(101, 240);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(146, 17);
      this.label1.TabIndex = 9;
      this.label1.Text = "Select desk materials:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(101, 290);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(121, 17);
      this.label4.TabIndex = 11;
      this.label4.Text = "Days to complete:";
      // 
      // NumDeskDepth
      // 
      this.NumDeskDepth.Location = new System.Drawing.Point(272, 148);
      this.NumDeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
      this.NumDeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.NumDeskDepth.Name = "NumDeskDepth";
      this.NumDeskDepth.Size = new System.Drawing.Size(120, 22);
      this.NumDeskDepth.TabIndex = 13;
      this.NumDeskDepth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      // 
      // NumNumberOfDrawers
      // 
      this.NumNumberOfDrawers.Location = new System.Drawing.Point(272, 192);
      this.NumNumberOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.NumNumberOfDrawers.Name = "NumNumberOfDrawers";
      this.NumNumberOfDrawers.Size = new System.Drawing.Size(120, 22);
      this.NumNumberOfDrawers.TabIndex = 14;
      this.NumNumberOfDrawers.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
      // 
      // ComDesktopMaterial
      // 
      this.ComDesktopMaterial.AllowDrop = true;
      this.ComDesktopMaterial.FormattingEnabled = true;
      this.ComDesktopMaterial.Location = new System.Drawing.Point(272, 242);
      this.ComDesktopMaterial.MaxDropDownItems = 5;
      this.ComDesktopMaterial.Name = "ComDesktopMaterial";
      this.ComDesktopMaterial.Size = new System.Drawing.Size(120, 24);
      this.ComDesktopMaterial.TabIndex = 15;
      this.ComDesktopMaterial.Text = "[Choose one]";
      // 
      // ComDaysToComplete
      // 
      this.ComDaysToComplete.AllowDrop = true;
      this.ComDaysToComplete.FormattingEnabled = true;
      this.ComDaysToComplete.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
      this.ComDaysToComplete.Location = new System.Drawing.Point(271, 289);
      this.ComDaysToComplete.MaxDropDownItems = 5;
      this.ComDaysToComplete.Name = "ComDaysToComplete";
      this.ComDaysToComplete.Size = new System.Drawing.Size(121, 24);
      this.ComDaysToComplete.TabIndex = 16;
      this.ComDaysToComplete.Text = "[Choose one]";
      // 
      // BtnSaveQuote
      // 
      this.BtnSaveQuote.Location = new System.Drawing.Point(297, 348);
      this.BtnSaveQuote.Name = "BtnSaveQuote";
      this.BtnSaveQuote.Size = new System.Drawing.Size(96, 23);
      this.BtnSaveQuote.TabIndex = 17;
      this.BtnSaveQuote.Text = "Save Quote";
      this.BtnSaveQuote.UseVisualStyleBackColor = true;
      this.BtnSaveQuote.Click += new System.EventHandler(this.BtnSaveQuote_Click);
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(104, 348);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(75, 23);
      this.BtnExit.TabIndex = 19;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // AddQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 450);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.BtnSaveQuote);
      this.Controls.Add(this.ComDaysToComplete);
      this.Controls.Add(this.ComDesktopMaterial);
      this.Controls.Add(this.NumNumberOfDrawers);
      this.Controls.Add(this.NumDeskDepth);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.NumDeskWidth);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TxtDeskWidth);
      this.Controls.Add(this.LblCustomerName);
      this.Controls.Add(this.TxtCustomerName);
      this.Name = "AddQuote";
      this.Text = "Add New Quote";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskDepth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumNumberOfDrawers)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.Label TxtDeskWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumDeskWidth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown NumDeskDepth;
    private System.Windows.Forms.NumericUpDown NumNumberOfDrawers;
    private System.Windows.Forms.ComboBox ComDesktopMaterial;
    private System.Windows.Forms.ComboBox ComDaysToComplete;
    private System.Windows.Forms.Button BtnSaveQuote;
    private System.Windows.Forms.Button BtnExit;
  }
}