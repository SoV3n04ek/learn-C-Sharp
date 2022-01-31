namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OilTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OilPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OilTotalPriceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OilTypeComboBox
            // 
            this.OilTypeComboBox.FormattingEnabled = true;
            this.OilTypeComboBox.Items.AddRange(new object[] {
            "A92",
            "A95"});
            this.OilTypeComboBox.Location = new System.Drawing.Point(76, 24);
            this.OilTypeComboBox.Name = "OilTypeComboBox";
            this.OilTypeComboBox.Size = new System.Drawing.Size(100, 23);
            this.OilTypeComboBox.TabIndex = 0;
            this.OilTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.OilTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бензин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OilTotalPriceLabel);
            this.panel1.Controls.Add(this.NumericUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OilPriceTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.OilTypeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 194);
            this.panel1.TabIndex = 1;
            // 
            // OilPriceTextBox
            // 
            this.OilPriceTextBox.Location = new System.Drawing.Point(76, 61);
            this.OilPriceTextBox.Name = "OilPriceTextBox";
            this.OilPriceTextBox.ReadOnly = true;
            this.OilPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.OilPriceTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Литров";
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(76, 90);
            this.NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.NumericUpDown.TabIndex = 4;
            this.NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(30, 294);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(176, 94);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Посчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OilTotalPriceLabel
            // 
            this.OilTotalPriceLabel.AutoSize = true;
            this.OilTotalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OilTotalPriceLabel.Location = new System.Drawing.Point(18, 136);
            this.OilTotalPriceLabel.Name = "OilTotalPriceLabel";
            this.OilTotalPriceLabel.Size = new System.Drawing.Size(0, 47);
            this.OilTotalPriceLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox OilTypeComboBox;
        private Label label1;
        private Panel panel1;
        private TextBox OilPriceTextBox;
        private Label label2;
        private NumericUpDown NumericUpDown;
        private Label label3;
        private Label OilTotalPriceLabel;
        private Button CalculateButton;
    }
}