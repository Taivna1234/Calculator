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

        private void Form1_Load(object sender, EventArgs e)
        {
            grpMemory.FlatStyle = FlatStyle.Flat;


            Panel borderlessPanel = new Panel();
            borderlessPanel.BackColor = Color.Azure;
            borderlessPanel.Size = grpMemory.Size;
            borderlessPanel.Location = new Point(0, 0);


            borderlessPanel.Controls.Add(lblMemoryLast);
            borderlessPanel.Controls.Add(btnMemoryAdd);
            borderlessPanel.Controls.Add(btnMemorySubstract);


            grpMemory.Controls.Add(borderlessPanel);
            titlebtn.Paint += (sender, e) =>
            {
                var g = e.Graphics;
                var rect = titlebtn.ClientRectangle;
                rect.Inflate(-1, -1);  

                // Draw the violet bottom border
                using (var pen = new Pen(Color.Violet, 2))  
                {
                    g.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                }
            };


        }

        public void UpdateMemoryDisplay()
        {
            double? lastMemory = calc.GetLastMemory();
            lblMemoryLast.Text = lastMemory.HasValue ? lastMemory.ToString() : "No memory";
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
            calc = new BasicCalculator(memory);
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            calc.MS(double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            calc.MPlus(double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            calc.MMinus(double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

        private void grpMemory_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
