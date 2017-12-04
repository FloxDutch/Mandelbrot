namespace Mandelbrot
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
      if(disposing && (components != null))
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
            this.goButton = new System.Windows.Forms.Button();
            this.XmiddenTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.YmiddenTextBox = new System.Windows.Forms.TextBox();
            this.schaalTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.kleurComboBox = new System.Windows.Forms.ComboBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.mandelbrotPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(634, 37);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(90, 37);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button_Click);
            // 
            // XmiddenTextBox
            // 
            this.XmiddenTextBox.Location = new System.Drawing.Point(73, 16);
            this.XmiddenTextBox.Name = "XmiddenTextBox";
            this.XmiddenTextBox.Size = new System.Drawing.Size(85, 20);
            this.XmiddenTextBox.TabIndex = 2;
            this.XmiddenTextBox.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(10, 19);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(57, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X - midden";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(10, 57);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(57, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y - midden";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(208, 20);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(38, 13);
            this.scaleLabel.TabIndex = 5;
            this.scaleLabel.Text = "schaal";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(208, 58);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 6;
            this.maxLabel.Text = "max";
            // 
            // YmiddenTextBox
            // 
            this.YmiddenTextBox.Location = new System.Drawing.Point(73, 54);
            this.YmiddenTextBox.Name = "YmiddenTextBox";
            this.YmiddenTextBox.Size = new System.Drawing.Size(84, 20);
            this.YmiddenTextBox.TabIndex = 7;
            this.YmiddenTextBox.Text = "0";
            // 
            // schaalTextBox
            // 
            this.schaalTextBox.Location = new System.Drawing.Point(250, 19);
            this.schaalTextBox.Name = "schaalTextBox";
            this.schaalTextBox.Size = new System.Drawing.Size(64, 20);
            this.schaalTextBox.TabIndex = 8;
            this.schaalTextBox.Text = "0.01";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(250, 57);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(64, 20);
            this.maxTextBox.TabIndex = 9;
            this.maxTextBox.Text = "100";
            // 
            // kleurComboBox
            // 
            this.kleurComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kleurComboBox.FormattingEnabled = true;
            this.kleurComboBox.Items.AddRange(new object[] {
            "zwart-wit",
            "rood-blauw"});
            this.kleurComboBox.Location = new System.Drawing.Point(390, 19);
            this.kleurComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.kleurComboBox.Name = "kleurComboBox";
            this.kleurComboBox.Size = new System.Drawing.Size(92, 21);
            this.kleurComboBox.TabIndex = 10;
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(356, 21);
            this.colourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(30, 13);
            this.colourLabel.TabIndex = 11;
            this.colourLabel.Text = "kleur";
            // 
            // mandelbrotPicture
            // 
            this.mandelbrotPicture.Location = new System.Drawing.Point(155, 154);
            this.mandelbrotPicture.Name = "mandelbrotPicture";
            this.mandelbrotPicture.Size = new System.Drawing.Size(400, 400);
            this.mandelbrotPicture.TabIndex = 13;
            this.mandelbrotPicture.TabStop = false;
            this.mandelbrotPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mandelbrotPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.mandelbrotPicture);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.kleurComboBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.schaalTextBox);
            this.Controls.Add(this.YmiddenTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.XmiddenTextBox);
            this.Controls.Add(this.goButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mandelbrotPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox XmiddenTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox YmiddenTextBox;
        private System.Windows.Forms.TextBox schaalTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.ComboBox kleurComboBox;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.PictureBox mandelbrotPicture;
    }
}

