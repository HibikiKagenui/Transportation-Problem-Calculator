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
    public partial class Form3 : Form
    {

        int[,] arrCost;
        int[,] arrValue;
        int row;
        int column;
        int[] arrDemand;
        int[] arrSupply;

        TextBox[] supplies;
        TextBox[] demands;
        TextBox[,] cells;
        TextBox[,] cellss;

        public Form3(int[,] arrCost, int[,] arrValue, int row, int column, int[] arrDemand, int[] arrSupply)
        {
            InitializeComponent();

            this.arrCost = arrCost;
            this.arrValue = arrValue;
            this.arrDemand = arrDemand;
            this.arrSupply = arrSupply;
            this.row = row;
            this.column = column;

            supplies = new TextBox[row];
            demands = new TextBox[column];
            cells = new TextBox[row, column];
            cellss = new TextBox[row, column];

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x = 70;
            int y = 50;

            int width = 50;
            int height = 30;

            // Labels
            for (int j = 0; j < column; j++)
            {
                Label labelCol = new Label()
                {
                    Location = new Point(x, y),
                    Width = 40,
                    Height = 20,
                    Text = "D" + (j + 1).ToString()
                };
                Controls.Add(labelCol);
                x += 120;
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
            for (int i = 0; i < row; i++)
            {
                Label labelRow = new Label()
                {
                    Location = new Point(x - 40, y),
                    Width = 40,
                    Height = 20,
                    Text = "S" + (i + 1).ToString()
                };
                Controls.Add(labelRow);
                for (int j = 0; j < column; j++)
                {
                    TextBox input = new TextBox()
                    {
                        Name = "input" + (i + 1).ToString() + "" + (j + 1).ToString(),
                        Location = new Point(x, y),
                        Multiline = true,
                        Width = width,
                        Height = height,
                        Text = arrCost[i,j].ToString(),
                    };
                    Controls.Add(input);
                    cells[i, j] = input;
                    x += 60;

                    TextBox input2 = new TextBox()
                    {
                        Name = "input" + (i + 1).ToString() + "" + (j + 1).ToString(),
                        Location = new Point(x, y),
                        Multiline = true,
                        Width = width-10,
                        Height = height-10,
                        Text = arrValue[i,j].ToString(),
                    };
                    Controls.Add(input2);
                    cellss[i, j] = input2;
                    x += 60;
                }
                x += 30;
                TextBox inputSupply = new TextBox()
                {
                    Name = "inputSupply" + (i + 1).ToString(),
                    Location = new Point(x, y),
                    Multiline = true,
                    Width = width,
                    Height = height,
                    Text = arrSupply[i].ToString(),
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
            for (int j = 0; j < column; j++)
            {
                TextBox inputDemand = new TextBox()
                {
                    Name = "inputDemand" + (j + 1).ToString(),
                    Location = new Point(x, y),
                    Multiline = true,
                    Width = width,
                    Height = height,
                    Text = arrDemand[j].ToString(),
                };
                Controls.Add(inputDemand);
                demands[j] = inputDemand;
                x += 120;
            }


            int totalCost = 0;

            for (int i = 0;i < row;i++)
            {
                for (int j = 0; j < column; j++)
                {
                    totalCost = (arrValue[i, j] * arrCost[i, j]) + totalCost;
                }
            }


            Label label = new Label()
            {
                Location = new Point(100, y + 100),
                Text = "Minimum Transportation Cost = " + totalCost,
                Width = 300,
                Height = 300,
            };

            Controls.Add(label);
        }
    }
}
