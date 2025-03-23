using System;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Calculator;
using Calculator.Memory;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        private BasicCalculator calc;
        private Memori memory;
        private string currentOperation = "";
        private double LastMemoryItem;




        public Form1()
        {
            InitializeComponent();
            memory = new Memori();
            calc = new BasicCalculator(memory);
        }
        private void UpdateMemoryDisplay()
        {
            panelMemoryContainer.Controls.Clear();
            int yOffset = 10;

            foreach (var item in calc.GetMemoryItems())
            {
                Panel memoryPanel = new Panel
                {
                    Size = new Size(panelMemoryContainer.Width - 20, 80),
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = item 
                };

                Label lblMemoryValue = new Label
                {
                    Text = item.Value.ToString("F2"),
                    Size = new Size(100, 20),
                    Location = new Point(10, 10),
                    Tag = item 
                };

                Button btnMemoryAdd = new Button
                {
                    Text = "M+",
                    Size = new Size(60, 23),
                    Location = new Point(memoryPanel.Width - 170, 40),
                    Tag = lblMemoryValue 
                };
                btnMemoryAdd.Click += btnMemoryAdd_Click;

                Button btnMemorySubtract = new Button
                {
                    Text = "M-",
                    Size = new Size(60, 23),
                    Location = new Point(memoryPanel.Width - 100, 40),
                    Tag = lblMemoryValue 
                };
                btnMemorySubtract.Click += btnMemorySubtract_Click;

                memoryPanel.Controls.Add(lblMemoryValue);
                memoryPanel.Controls.Add(btnMemoryAdd);
                memoryPanel.Controls.Add(btnMemorySubtract);

                panelMemoryContainer.Controls.Add(memoryPanel);

                yOffset += memoryPanel.Height + 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            titlebtn.Paint += (sender, e) =>
            {
                var g = e.Graphics;
                var rect = titlebtn.ClientRectangle;
                rect.Inflate(-1, -1);

                
                using (var pen = new Pen(Color.Violet, 2))
                {
                    g.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                }
            };


        }
        



        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblDisplay.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.Result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            currentOperation = "add";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.Result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            currentOperation = "subtract";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {


            if (currentOperation == "add")
            {
                calc.Add(double.Parse(lblDisplay.Text));
            }
            else if (currentOperation == "subtract")
            {
                calc.Subtract(double.Parse(lblDisplay.Text));
            }
            lblDisplay.Text = calc.Result.ToString();
            currentOperation = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "";
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            calc.MS(double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Label lblMemoryValue)
            {
                double currentValue = double.Parse(lblDisplay.Text);

                MemoryItem memoryItem = (MemoryItem)lblMemoryValue.Tag;

                calc.MPlus(currentValue, memoryItem.ID);

                lblMemoryValue.Text = memoryItem.Value.ToString("F2");
            }
        }


        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Label lblMemoryValue)
            {
              
                double currentValue = double.Parse(lblDisplay.Text);

            
                MemoryItem memoryItem = (MemoryItem)lblMemoryValue.Tag;

                calc.MMinus(currentValue, memoryItem.ID);
                lblMemoryValue.Text = memoryItem.Value.ToString("F2");
            }
        }


        private void Remove(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblDisplay.Text))
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }

        }
    }
}
