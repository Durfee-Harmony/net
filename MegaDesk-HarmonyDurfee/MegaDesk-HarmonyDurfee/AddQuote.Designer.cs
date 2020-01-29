namespace MegaDesk_HarmonyDurfee
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
      this.LblCustomerName = new System.Windows.Forms.Label();
      this.TxtCustomerName = new System.Windows.Forms.TextBox();
      this.LblDeskWidth = new System.Windows.Forms.Label();
      this.LblDeskHeight = new System.Windows.Forms.Label();
      this.LblDrawerTotal = new System.Windows.Forms.Label();
      this.NumDeskWidth = new System.Windows.Forms.NumericUpDown();
      this.NumDeskHeight = new System.Windows.Forms.NumericUpDown();
      this.NumDrawerTotal = new System.Windows.Forms.NumericUpDown();
      this.LblDeskMaterial = new System.Windows.Forms.Label();
      this.ComboDeskMaterials = new System.Windows.Forms.ComboBox();
      this.ComboDaysToCompletion = new System.Windows.Forms.ComboBox();
      this.LblDaysToCompletion = new System.Windows.Forms.Label();
      this.BtnExit = new System.Windows.Forms.Button();
      this.BtnSaveExit = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDrawerTotal)).BeginInit();
      this.SuspendLayout();
      // 
      // LblCustomerName
      // 
      this.LblCustomerName.AutoSize = true;
      this.LblCustomerName.Location = new System.Drawing.Point(197, 114);
      this.LblCustomerName.Name = "LblCustomerName";
      this.LblCustomerName.Size = new System.Drawing.Size(275, 37);
      this.LblCustomerName.TabIndex = 0;
      this.LblCustomerName.Text = "Enter Your Name:";
      // 
      // TxtCustomerName
      // 
      this.TxtCustomerName.Location = new System.Drawing.Point(545, 114);
      this.TxtCustomerName.Name = "TxtCustomerName";
      this.TxtCustomerName.Size = new System.Drawing.Size(321, 44);
      this.TxtCustomerName.TabIndex = 1;
      // 
      // LblDeskWidth
      // 
      this.LblDeskWidth.AutoSize = true;
      this.LblDeskWidth.Location = new System.Drawing.Point(197, 202);
      this.LblDeskWidth.Name = "LblDeskWidth";
      this.LblDeskWidth.Size = new System.Drawing.Size(275, 37);
      this.LblDeskWidth.TabIndex = 2;
      this.LblDeskWidth.Text = "Enter Desk Width:";
      // 
      // LblDeskHeight
      // 
      this.LblDeskHeight.AutoSize = true;
      this.LblDeskHeight.Location = new System.Drawing.Point(197, 302);
      this.LblDeskHeight.Name = "LblDeskHeight";
      this.LblDeskHeight.Size = new System.Drawing.Size(284, 37);
      this.LblDeskHeight.TabIndex = 4;
      this.LblDeskHeight.Text = "Enter Desk Height:";
      // 
      // LblDrawerTotal
      // 
      this.LblDrawerTotal.AutoSize = true;
      this.LblDrawerTotal.Location = new System.Drawing.Point(197, 398);
      this.LblDrawerTotal.Name = "LblDrawerTotal";
      this.LblDrawerTotal.Size = new System.Drawing.Size(295, 37);
      this.LblDrawerTotal.TabIndex = 6;
      this.LblDrawerTotal.Text = "Enter Drawer Total:";
      // 
      // NumDeskWidth
      // 
      this.NumDeskWidth.Location = new System.Drawing.Point(545, 200);
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
      this.NumDeskWidth.Size = new System.Drawing.Size(321, 44);
      this.NumDeskWidth.TabIndex = 8;
      this.NumDeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      // 
      // NumDeskHeight
      // 
      this.NumDeskHeight.Location = new System.Drawing.Point(545, 300);
      this.NumDeskHeight.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
      this.NumDeskHeight.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.NumDeskHeight.Name = "NumDeskHeight";
      this.NumDeskHeight.Size = new System.Drawing.Size(321, 44);
      this.NumDeskHeight.TabIndex = 9;
      this.NumDeskHeight.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
      // 
      // NumDrawerTotal
      // 
      this.NumDrawerTotal.Location = new System.Drawing.Point(545, 396);
      this.NumDrawerTotal.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.NumDrawerTotal.Name = "NumDrawerTotal";
      this.NumDrawerTotal.Size = new System.Drawing.Size(321, 44);
      this.NumDrawerTotal.TabIndex = 10;
      // 
      // LblDeskMaterial
      // 
      this.LblDeskMaterial.AutoSize = true;
      this.LblDeskMaterial.Location = new System.Drawing.Point(197, 502);
      this.LblDeskMaterial.Name = "LblDeskMaterial";
      this.LblDeskMaterial.Size = new System.Drawing.Size(332, 37);
      this.LblDeskMaterial.TabIndex = 11;
      this.LblDeskMaterial.Text = "Select Desk Materials:";
      // 
      // ComboDeskMaterials
      // 
      this.ComboDeskMaterials.AllowDrop = true;
      this.ComboDeskMaterials.FormattingEnabled = true;
      this.ComboDeskMaterials.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
      this.ComboDeskMaterials.Location = new System.Drawing.Point(545, 502);
      this.ComboDeskMaterials.Name = "ComboDeskMaterials";
      this.ComboDeskMaterials.Size = new System.Drawing.Size(321, 45);
      this.ComboDeskMaterials.TabIndex = 12;
      this.ComboDeskMaterials.Text = "[Choose one]";
      // 
      // ComboDaysToCompletion
      // 
      this.ComboDaysToCompletion.AllowDrop = true;
      this.ComboDaysToCompletion.FormattingEnabled = true;
      this.ComboDaysToCompletion.Items.AddRange(new object[] {
            "Rush3Days",
            "Rush5Days",
            "Rush7Days",
            "Normal14Days"});
      this.ComboDaysToCompletion.Location = new System.Drawing.Point(545, 598);
      this.ComboDaysToCompletion.Name = "ComboDaysToCompletion";
      this.ComboDaysToCompletion.Size = new System.Drawing.Size(321, 45);
      this.ComboDaysToCompletion.TabIndex = 14;
      this.ComboDaysToCompletion.Text = "[Choose one]";
      // 
      // LblDaysToCompletion
      // 
      this.LblDaysToCompletion.AutoSize = true;
      this.LblDaysToCompletion.Location = new System.Drawing.Point(197, 598);
      this.LblDaysToCompletion.Name = "LblDaysToCompletion";
      this.LblDaysToCompletion.Size = new System.Drawing.Size(138, 37);
      this.LblDaysToCompletion.TabIndex = 13;
      this.LblDaysToCompletion.Text = "Delivery:";
      // 
      // BtnExit
      // 
      this.BtnExit.Location = new System.Drawing.Point(204, 698);
      this.BtnExit.Name = "BtnExit";
      this.BtnExit.Size = new System.Drawing.Size(214, 80);
      this.BtnExit.TabIndex = 15;
      this.BtnExit.Text = "Exit";
      this.BtnExit.UseVisualStyleBackColor = true;
      this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
      // 
      // BtnSaveExit
      // 
      this.BtnSaveExit.Location = new System.Drawing.Point(545, 698);
      this.BtnSaveExit.Name = "BtnSaveExit";
      this.BtnSaveExit.Size = new System.Drawing.Size(321, 80);
      this.BtnSaveExit.TabIndex = 16;
      this.BtnSaveExit.Text = "Add New Quote";
      this.BtnSaveExit.UseVisualStyleBackColor = true;
      // 
      // AddQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1094, 860);
      this.Controls.Add(this.BtnSaveExit);
      this.Controls.Add(this.BtnExit);
      this.Controls.Add(this.ComboDaysToCompletion);
      this.Controls.Add(this.LblDaysToCompletion);
      this.Controls.Add(this.ComboDeskMaterials);
      this.Controls.Add(this.LblDeskMaterial);
      this.Controls.Add(this.NumDrawerTotal);
      this.Controls.Add(this.NumDeskHeight);
      this.Controls.Add(this.NumDeskWidth);
      this.Controls.Add(this.LblDrawerTotal);
      this.Controls.Add(this.LblDeskHeight);
      this.Controls.Add(this.LblDeskWidth);
      this.Controls.Add(this.TxtCustomerName);
      this.Controls.Add(this.LblCustomerName);
      this.Name = "AddQuote";
      this.Text = "Add New Quote";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDeskHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.NumDrawerTotal)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblDeskWidth;
        private System.Windows.Forms.Label LblDeskHeight;
        private System.Windows.Forms.Label LblDrawerTotal;
    private System.Windows.Forms.NumericUpDown NumDeskWidth;
    private System.Windows.Forms.NumericUpDown NumDeskHeight;
    private System.Windows.Forms.NumericUpDown NumDrawerTotal;
    private System.Windows.Forms.Label LblDeskMaterial;
    private System.Windows.Forms.ComboBox ComboDeskMaterials;
    private System.Windows.Forms.ComboBox ComboDaysToCompletion;
    private System.Windows.Forms.Label LblDaysToCompletion;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSaveExit;
    }
}