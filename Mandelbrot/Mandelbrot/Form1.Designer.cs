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
            this.button = new System.Windows.Forms.Button();
            this.XmiddenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.YmiddenTextBox = new System.Windows.Forms.TextBox();
            this.schaalTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.kleurComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(634, 37);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(90, 37);
            this.button.TabIndex = 1;
            this.button.Text = "GO!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // XmiddenTextBox
            // 
            this.XmiddenTextBox.Location = new System.Drawing.Point(73, 16);
            this.XmiddenTextBox.Name = "XmiddenTextBox";
            this.XmiddenTextBox.Size = new System.Drawing.Size(85, 20);
            this.XmiddenTextBox.TabIndex = 2;
            this.XmiddenTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X - midden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y - midden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "schaal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "max";
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
            this.schaalTextBox.Text = "1,00";
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
            this.kleurComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kleurComboBox.Name = "kleurComboBox";
            this.kleurComboBox.Size = new System.Drawing.Size(92, 21);
            this.kleurComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "kleur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kleurComboBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.schaalTextBox);
            this.Controls.Add(this.YmiddenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XmiddenTextBox);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox XmiddenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YmiddenTextBox;
        private System.Windows.Forms.TextBox schaalTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.ComboBox kleurComboBox;
        private System.Windows.Forms.Label label5;
    }
}

