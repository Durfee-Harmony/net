namespace MathQuiz
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.timeLabel = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.leftAdd = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.rightAdd = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.sumAdd = new System.Windows.Forms.NumericUpDown();
      this.sumMinus = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.rightMinus = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.leftMinus = new System.Windows.Forms.Label();
      this.sumMultiply = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.rightMultiply = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.leftMultiply = new System.Windows.Forms.Label();
      this.sumDivide = new System.Windows.Forms.NumericUpDown();
      this.label12 = new System.Windows.Forms.Label();
      this.rightDivide = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.leftDivide = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.date = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.sumAdd)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumMinus)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumMultiply)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumDivide)).BeginInit();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.timeLabel.Location = new System.Drawing.Point(270, 9);
      this.timeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(200, 30);
      this.timeLabel.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(165, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Time Left";
      // 
      // leftAdd
      // 
      this.leftAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leftAdd.Location = new System.Drawing.Point(50, 75);
      this.leftAdd.Name = "leftAdd";
      this.leftAdd.Size = new System.Drawing.Size(60, 50);
      this.leftAdd.TabIndex = 2;
      this.leftAdd.Text = "?";
      this.leftAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(116, 75);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 50);
      this.label1.TabIndex = 3;
      this.label1.Text = "+";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rightAdd
      // 
      this.rightAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rightAdd.Location = new System.Drawing.Point(182, 75);
      this.rightAdd.Name = "rightAdd";
      this.rightAdd.Size = new System.Drawing.Size(60, 50);
      this.rightAdd.TabIndex = 4;
      this.rightAdd.Text = "?";
      this.rightAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(248, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 50);
      this.label3.TabIndex = 5;
      this.label3.Text = "=";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sumAdd
      // 
      this.sumAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sumAdd.Location = new System.Drawing.Point(314, 84);
      this.sumAdd.Name = "sumAdd";
      this.sumAdd.Size = new System.Drawing.Size(100, 35);
      this.sumAdd.TabIndex = 2;
      this.sumAdd.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // sumMinus
      // 
      this.sumMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sumMinus.Location = new System.Drawing.Point(314, 134);
      this.sumMinus.Name = "sumMinus";
      this.sumMinus.Size = new System.Drawing.Size(100, 35);
      this.sumMinus.TabIndex = 3;
      this.sumMinus.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(248, 125);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 50);
      this.label4.TabIndex = 10;
      this.label4.Text = "=";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rightMinus
      // 
      this.rightMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rightMinus.Location = new System.Drawing.Point(182, 125);
      this.rightMinus.Name = "rightMinus";
      this.rightMinus.Size = new System.Drawing.Size(60, 50);
      this.rightMinus.TabIndex = 9;
      this.rightMinus.Text = "?";
      this.rightMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(116, 125);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(60, 50);
      this.label6.TabIndex = 8;
      this.label6.Text = "-";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // leftMinus
      // 
      this.leftMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leftMinus.Location = new System.Drawing.Point(50, 125);
      this.leftMinus.Name = "leftMinus";
      this.leftMinus.Size = new System.Drawing.Size(60, 50);
      this.leftMinus.TabIndex = 7;
      this.leftMinus.Text = "?";
      this.leftMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sumMultiply
      // 
      this.sumMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sumMultiply.Location = new System.Drawing.Point(314, 184);
      this.sumMultiply.Name = "sumMultiply";
      this.sumMultiply.Size = new System.Drawing.Size(100, 35);
      this.sumMultiply.TabIndex = 4;
      this.sumMultiply.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(248, 175);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(60, 50);
      this.label8.TabIndex = 15;
      this.label8.Text = "=";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rightMultiply
      // 
      this.rightMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rightMultiply.Location = new System.Drawing.Point(182, 175);
      this.rightMultiply.Name = "rightMultiply";
      this.rightMultiply.Size = new System.Drawing.Size(60, 50);
      this.rightMultiply.TabIndex = 14;
      this.rightMultiply.Text = "?";
      this.rightMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(116, 175);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(60, 50);
      this.label10.TabIndex = 13;
      this.label10.Text = "×";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // leftMultiply
      // 
      this.leftMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leftMultiply.Location = new System.Drawing.Point(50, 175);
      this.leftMultiply.Name = "leftMultiply";
      this.leftMultiply.Size = new System.Drawing.Size(60, 50);
      this.leftMultiply.TabIndex = 12;
      this.leftMultiply.Text = "?";
      this.leftMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sumDivide
      // 
      this.sumDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sumDivide.Location = new System.Drawing.Point(314, 231);
      this.sumDivide.Name = "sumDivide";
      this.sumDivide.Size = new System.Drawing.Size(100, 35);
      this.sumDivide.TabIndex = 5;
      this.sumDivide.Enter += new System.EventHandler(this.answer_Enter);
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(248, 222);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(60, 50);
      this.label12.TabIndex = 20;
      this.label12.Text = "=";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rightDivide
      // 
      this.rightDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rightDivide.Location = new System.Drawing.Point(182, 222);
      this.rightDivide.Name = "rightDivide";
      this.rightDivide.Size = new System.Drawing.Size(60, 50);
      this.rightDivide.TabIndex = 19;
      this.rightDivide.Text = "?";
      this.rightDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(116, 222);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(60, 50);
      this.label14.TabIndex = 18;
      this.label14.Text = "÷";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // leftDivide
      // 
      this.leftDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.leftDivide.Location = new System.Drawing.Point(50, 222);
      this.leftDivide.Name = "leftDivide";
      this.leftDivide.Size = new System.Drawing.Size(60, 50);
      this.leftDivide.TabIndex = 17;
      this.leftDivide.Text = "?";
      this.leftDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // startButton
      // 
      this.startButton.AutoSize = true;
      this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.Location = new System.Drawing.Point(177, 311);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(131, 34);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "Start the Quiz";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // date
      // 
      this.date.AutoSize = true;
      this.date.Location = new System.Drawing.Point(12, 324);
      this.date.Name = "date";
      this.date.Size = new System.Drawing.Size(30, 13);
      this.date.TabIndex = 22;
      this.date.Text = "Date";
      this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 357);
      this.Controls.Add(this.date);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.sumDivide);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.rightDivide);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.leftDivide);
      this.Controls.Add(this.sumMultiply);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.rightMultiply);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.leftMultiply);
      this.Controls.Add(this.sumMinus);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.rightMinus);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.leftMinus);
      this.Controls.Add(this.sumAdd);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.rightAdd);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.leftAdd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.timeLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(1);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Harmony Durfee\'s Math Quiz";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.sumAdd)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumMinus)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumMultiply)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sumDivide)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label leftAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rightAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sumAdd;
        private System.Windows.Forms.NumericUpDown sumMinus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rightMinus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label leftMinus;
        private System.Windows.Forms.NumericUpDown sumMultiply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rightMultiply;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label leftMultiply;
        private System.Windows.Forms.NumericUpDown sumDivide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label rightDivide;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label leftDivide;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
    }
}

