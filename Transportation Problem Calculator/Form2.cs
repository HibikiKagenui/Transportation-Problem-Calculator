using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation_Problem_Calculator
{
    public partial class Form2 : Form
    {
        int supply;
        int demand;

        int column;
        int row;

        TextBox[] supplies;
        TextBox[] demands;
        TextBox[,] cells;

        Button buttonCalculate;

        int[] arrDemand;
        int[] arrDemand2;
        int[] arrSupply;
        int[] arrSupply2;
        int[,] arrCost;
        int[,] arrCost2;
        int[,] arrValue;

        public Form2(int supply, int demand)
        {
            InitializeComponent();

            this.supply = supply;
            this.demand = demand;

            supplies = new TextBox[supply];
            demands = new TextBox[demand];
            cells = new TextBox[supply, demand];

            arrDemand = new int[demand + 1];
            arrDemand2 = new int[demand + 1];
            arrSupply = new int[supply + 1];
            arrSupply2 = new int[supply + 1];
            arrCost = new int[supply + 1, demand + 1];
            arrCost2 = new int[supply + 1, demand + 1];
            arrValue = new int[supply + 1, demand + 1];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 70;
            int y = 50;

            int width = 50;
            int height = 30;
            
            // Labels
            for(int j = 0; j < demand; j++)
            {
                Label labelCol = new Label()
                {
                    Location = new Point(x, y),
                    Width = 40,
                    Height = 20,
                    Text = "D" + (j + 1).ToString()
                };
                Controls.Add(labelCol);
                x += 60;
            }
            x += 20;
            Label labelSupply = new Label()
            {
                Location = new Point(x, y),
                Width = 40,
                Height = 20,
                Text = "Supply"
            };
            Controls.Add(labelSupply);
            x = 70;
            y += 30;

            // loop untuk membuat textbox
            for(int i = 0; i < supply; i++)
            {
                Label labelRow = new Label()
                {
                    Location = new Point(x - 40, y),
                    Width = 40,
                    Height = 20,
                    Text = "S" + (i + 1).ToString()
                };
                Controls.Add(labelRow);
                for(int j = 0; j < demand; j++)
                {
                    TextBox input = new TextBox()
                    {
                        Name = "input" + (i + 1).ToString() + "" + (j + 1).ToString(),
                        Location = new Point(x, y),
                        Multiline = true,
                        Width = width,
                        Height = height
                    };
                    Controls.Add(input);
                    cells[i,j] = input;
                    x += 60;
                }
                x += 20;
                TextBox inputSupply = new TextBox()
                {
                    Name = "inputSupply" + (i + 1).ToString(),
                    Location = new Point(x, y),
                    Multiline = true,
                    Width = width,
                    Height = height
                };
                Controls.Add(inputSupply);
                supplies[i] = inputSupply;
                x = 70;
                y += 50;
            }

            // loop terakhir untuk row textbox demand
            y += 10;
            Label labelDemand = new Label()
            {
                Location = new Point(x - 60, y),
                Width = 60,
                Height = 20,
                Text = "Demand"
            };
            Controls.Add(labelDemand);
            for (int j = 0; j < demand; j++)
            {
                TextBox inputDemand = new TextBox()
                {
                    Name = "inputDemand" + (j + 1).ToString(),
                    Location = new Point(x, y),
                    Multiline = true,
                    Width = width,
                    Height = height
                };
                Controls.Add(inputDemand);
                demands[j] = inputDemand;
                x += 60;
            }

            // tombol calculate
            x = 70;
            y += 60;
            buttonCalculate = new Button()
            {
                Text = "Hitung",
                Location = new Point(x, y),
                Enabled = false
            };
            buttonCalculate.Click += new EventHandler(ButtonCalculate_Click);
            Controls.Add(buttonCalculate);
            x += 100;
            Button buttonClear = new Button()
            {
                Text = "Hapus",
                Location = new Point(x, y)
            };
            buttonClear.Click += new EventHandler(ButtonClear_Click);
            Controls.Add(buttonClear);

            // set textbox listeners
            foreach (TextBox tb in cells)       tb.TextChanged += new EventHandler(TextBox_TextChanged);
            foreach (TextBox tb in supplies)    tb.TextChanged += new EventHandler(TextBox_TextChanged);
            foreach (TextBox tb in demands)     tb.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            bool status = true;

            if (status)
            {
                foreach (TextBox tb in cells)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        status = false;
                        break;
                    }
                }
            }
            if (status)
            {
                foreach (TextBox tb in demands)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        status = false;
                        break;
                    }
                }
            }
            if (status)
            {
                foreach (TextBox tb in supplies)
                {
                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        status = false;
                        break;
                    }
                }
            }

            if(status) buttonCalculate.Enabled = true;
            else buttonCalculate.Enabled = false;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in cells)       tb.Text = String.Empty;
            foreach (TextBox tb in supplies)    tb.Text = String.Empty;
            foreach (TextBox tb in demands)     tb.Text = String.Empty;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                MessageBox.Show("Mohon pastikan semua diisi dengan angka", "Error");
                return;
            }

            int i;
            int j;

            column = demand;
            row = supply;

            for (i = 0;i < demand; i++)
            {
                arrDemand[i] = Convert.ToInt32(demands[i].Text);
                arrDemand2[i] = Convert.ToInt32(demands[i].Text);
            }

            for (i = 0;i < supply; i++)
            {
                arrSupply[i] = Convert.ToInt32(supplies[i].Text);
                arrSupply2[i] = Convert.ToInt32(supplies[i].Text);
            }

            int totalDemand = arrDemand.Sum();
            int totalSupply = arrSupply.Sum();

            if (totalDemand < totalSupply)
            {
                arrDemand[demand] = totalSupply - totalDemand;
                arrDemand2[demand] = totalSupply - totalDemand;
                arrSupply[supply] = 0;
                arrSupply2[supply] = 0;
                column = demand + 1;
            }
            else if (totalSupply < totalDemand)
            {
                arrSupply[supply] = totalDemand - totalSupply;
                arrSupply2[supply] = totalDemand - totalSupply;
                arrDemand[demand] = 0;
                arrDemand2[demand] = 0;
                row = supply + 1;
            }
            else
            {
                arrSupply[supply] = 0;
                arrSupply2[supply] = 0;
                arrDemand[demand] = 0;
                arrDemand2[demand] = 0;
            }

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    arrCost[i, j] = 0;
                    arrCost2[i, j] = 0;
                }
            }

            for (i = 0; i <  supply;i++)
            {
                for (j = 0;j < demand; j++)
                {
                    arrCost[i, j] = Convert.ToInt32(cells[i, j].Text);
                    arrCost2[i, j] = Convert.ToInt32(cells[i, j].Text);
                }
            }

            LeastCost();
        }

        private bool ValidateInput()
        {
            bool returnValue = true;

            if (returnValue)
            {
                foreach(TextBox tb in cells)
                {
                    if (!int.TryParse(tb.Text, out int temp))
                    {
                        returnValue = false;
                        break;
                    }
                }
            }
            if (returnValue)
            {
                foreach (TextBox tb in demands)
                {
                    if (!int.TryParse(tb.Text, out int temp))
                    {
                        returnValue = false;
                        break;
                    }
                }
            }
            if (returnValue)
            {
                foreach (TextBox tb in supplies)
                {
                    if (!int.TryParse(tb.Text, out int temp))
                    {
                        returnValue = false;
                        break;
                    }
                }
            }

            return returnValue;
        }

        private void LeastCost()
        {
            int i;
            int j;

            int totalDemand = arrDemand.Sum();
            int totalSupply = arrSupply.Sum();

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    arrValue[i, j] = 0;
                }
            }

            while (totalDemand > 0)
            {
                int min = 1000000;
                int indexI = 0;
                int indexJ = 0;

                for (i = 0; i < row; i++)
                {
                    for (j = 0; j < column; j++)
                    {
                        if (min > arrCost[i, j])
                        {
                            if (arrCost[i, j] != -99)
                            {
                                min = arrCost[i, j];
                                indexI = i;
                                indexJ = j;
                            }
                        }
                    }
                }

                int dem = arrDemand[indexJ];
                int sup = arrSupply[indexI];

                int diff = dem - sup;

                if (diff > 0)
                {
                    arrValue[indexI, indexJ] = sup;
                }
                else
                {
                    arrValue[indexI, indexJ] = dem;
                }
                
                
                if (dem < sup)
                {
                    for (i = 0; i < row; i++)
                    {
                        arrCost[i, indexJ] = -99;
                    }
                }
                else if (dem > sup)
                {
                    for (i = 0; i < column; i++)
                    {
                        arrCost[indexI, i] = -99;
                    }
                }
                else if (dem == sup)
                {
                    for (i = 0; i < column; i++)
                    {
                        arrCost[indexI, i] = -99;
                    }
                    for (i = 0; i < row; i++)
                    {
                        arrCost[i, indexJ] = -99;
                    }
                }


                if (diff > 0)
                {
                    totalDemand = totalDemand - sup;
                    arrDemand[indexJ] = arrDemand[indexJ] - sup;
                    arrSupply[indexI] = arrSupply[indexI] - sup;
                }
                else
                {
                    totalDemand = totalDemand - dem;
                    arrDemand[indexJ] = arrDemand[indexJ] - dem;
                    arrSupply[indexI] = arrSupply[indexI] - dem;
                }

                arrCost[indexI, indexJ] = -99;

            }

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write(arrCost2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write(arrValue[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(totalDemand);

            Console.WriteLine("===================================");

            Form3 form2 = new Form3(arrCost2, arrValue, row, column, arrDemand2, arrSupply2);
            form2.ShowDialog();
        }
    }
}
