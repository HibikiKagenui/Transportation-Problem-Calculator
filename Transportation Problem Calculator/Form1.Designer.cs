namespace Transportation_Problem_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buatButton = new System.Windows.Forms.Button();
            this.demandInput = new System.Windows.Forms.NumericUpDown();
            this.supplyInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.demandInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Supply";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Demand";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // buatButton
            // 
            this.buatButton.Location = new System.Drawing.Point(93, 114);
            this.buatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buatButton.Name = "buatButton";
            this.buatButton.Size = new System.Drawing.Size(56, 19);
            this.buatButton.TabIndex = 2;
            this.buatButton.Text = "Buat";
            this.buatButton.UseVisualStyleBackColor = true;
            this.buatButton.Click += new System.EventHandler(this.BuatButton_Click);
            // 
            // demandInput
            // 
            this.demandInput.Location = new System.Drawing.Point(129, 73);
            this.demandInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.demandInput.Name = "demandInput";
            this.demandInput.Size = new System.Drawing.Size(75, 20);
            this.demandInput.TabIndex = 3;
            // 
            // supplyInput
            // 
            this.supplyInput.Location = new System.Drawing.Point(129, 34);
            this.supplyInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplyInput.Name = "supplyInput";
            this.supplyInput.Size = new System.Drawing.Size(75, 20);
            this.supplyInput.TabIndex = 3;
            this.supplyInput.ValueChanged += new System.EventHandler(this.supplyInput_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 164);
            this.Controls.Add(this.supplyInput);
            this.Controls.Add(this.demandInput);
            this.Controls.Add(this.buatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator Transportation Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demandInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buatButton;
        private System.Windows.Forms.NumericUpDown demandInput;
        private System.Windows.Forms.NumericUpDown supplyInput;
    }
}

