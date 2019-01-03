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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demandInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Supply";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Demand";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // buatButton
            // 
            this.buatButton.Location = new System.Drawing.Point(125, 170);
            this.buatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buatButton.Name = "buatButton";
            this.buatButton.Size = new System.Drawing.Size(75, 29);
            this.buatButton.TabIndex = 2;
            this.buatButton.Text = "Buat";
            this.buatButton.UseVisualStyleBackColor = true;
            this.buatButton.Click += new System.EventHandler(this.BuatButton_Click);
            // 
            // demandInput
            // 
            this.demandInput.Location = new System.Drawing.Point(173, 120);
            this.demandInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.demandInput.Name = "demandInput";
            this.demandInput.Size = new System.Drawing.Size(100, 22);
            this.demandInput.TabIndex = 3;
            // 
            // supplyInput
            // 
            this.supplyInput.Location = new System.Drawing.Point(173, 72);
            this.supplyInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplyInput.Name = "supplyInput";
            this.supplyInput.Size = new System.Drawing.Size(100, 22);
            this.supplyInput.TabIndex = 3;
            this.supplyInput.ValueChanged += new System.EventHandler(this.supplyInput_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalkulator Transportation Problem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Metode Least-Cost)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 220);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplyInput);
            this.Controls.Add(this.demandInput);
            this.Controls.Add(this.buatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

