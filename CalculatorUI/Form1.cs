using System;
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
            calc = new BasicCalculator(new Memori());
            memory = new Memori();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void UpdateMemoryDisplay()
        {
            double? lastMemory = memory.GetLastMemory();
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
           double? LastMemoryItem = memory.GetLastMemory();
            lblDisplay.Text = "";
            calc = new BasicCalculator(new Memori());
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            double? lastMemoryValue = memory.GetLastMemory();

            // If there is a last memory value
            if (lastMemoryValue.HasValue)
            {
                // If the current result is equal to the last memory value
                if (calc.Result == lastMemoryValue.Value)
                {
                    memory.Save(double.Parse(lblDisplay.Text));
                }
                else
                {
                    memory.Save(calc.Result);
                }
            }
            else
            {

                if (calc.Result == LastMemoryItem)
                {
                    memory.Save(double.Parse(lblDisplay.Text));
                }
                else
                {
                    memory.Save(calc.Result);
                }
            }

            UpdateMemoryDisplay();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            double? lastMemoryValue = memory.GetLastMemory();

            if (lastMemoryValue.HasValue)
            {
                double newMemoryValue = lastMemoryValue.Value + double.Parse(lblDisplay.Text);

                memory.Save(newMemoryValue);
            }
            else
            {
                memory.Save(double.Parse(lblDisplay.Text));
            }

            UpdateMemoryDisplay();
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            double? lastMemoryValue = memory.GetLastMemory();

            if (lastMemoryValue.HasValue)
            {
                double newMemoryValue = lastMemoryValue.Value - double.Parse(lblDisplay.Text);

                memory.Save(newMemoryValue);
            }
            else
            {
                memory.Save(double.Parse(lblDisplay.Text));
            }

            UpdateMemoryDisplay();
        }

    }
}
