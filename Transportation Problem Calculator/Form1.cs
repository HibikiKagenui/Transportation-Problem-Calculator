using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation_Problem_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            supplyInput.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuatButton_Click(object sender, EventArgs e)
        {
            int supply = (int)supplyInput.Value;
            int demand = (int)demandInput.Value;

            if(supply == 0 || demand == 0)
            {
                MessageBox.Show("Mohon isi dengan angka lebih besar dari 0", "Error");
            }
            else
            {
                Form2 form2 = new Form2(supply, demand);
                form2.ShowDialog();
            }
        }

        private void supplyInput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
