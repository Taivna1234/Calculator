using System;
using System.Windows.Forms;
using Calculator;
using Calculator.Memory;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        private BasicCalculator calc;
        private Memori memory;

        public Form1()
        {
            InitializeComponent();
            calc = new BasicCalculator(new Memori());
            memory = new Memori();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateMemoryDisplay()
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
            calc.Add(double.Parse(lblDisplay.Text));
            lblDisplay.Text = calc.Result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            calc.Subtract(double.Parse(lblDisplay.Text));
            lblDisplay.Text = calc.Result.ToString();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = calc.Result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            calc = new BasicCalculator(new Memori());
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memory.Save(calc.Result);
            UpdateMemoryDisplay();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            memory.Save(calc.Result + double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            memory.Save(calc.Result - double.Parse(lblDisplay.Text));
            UpdateMemoryDisplay();
        }

    }
}
