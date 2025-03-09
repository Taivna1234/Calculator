namespace CalculatorUI
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
            lblDisplay = new Label();
            grpMemory = new GroupBox();
            btnMemoryAdd = new Button();
            btnMemorySubstract = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSubstract = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            btnMemorySave = new Button();
            grpMemory.SuspendLayout();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.BorderStyle = BorderStyle.FixedSingle;
            lblDisplay.Font = new Font("Segoe UI", 20F);
            lblDisplay.Location = new Point(329, 76);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(2, 39);
            lblDisplay.TabIndex = 0;
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            lblDisplay.Click += label1_Click;
            // 
            // grpMemory
            // 
            grpMemory.Controls.Add(btnMemoryAdd);
            grpMemory.Controls.Add(btnMemorySubstract);
            grpMemory.Location = new Point(529, 51);
            grpMemory.Name = "grpMemory";
            grpMemory.Size = new Size(200, 100);
            grpMemory.TabIndex = 1;
            grpMemory.TabStop = false;
            grpMemory.Text = "Memory";
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.Location = new Point(81, 77);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(75, 23);
            btnMemoryAdd.TabIndex = 16;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = true;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // btnMemorySubstract
            // 
            btnMemorySubstract.Location = new Point(0, 77);
            btnMemorySubstract.Name = "btnMemorySubstract";
            btnMemorySubstract.Size = new Size(75, 23);
            btnMemorySubstract.TabIndex = 17;
            btnMemorySubstract.Text = "M-";
            btnMemorySubstract.UseVisualStyleBackColor = true;
            btnMemorySubstract.Click += btnMemorySubtract_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(223, 368);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 50);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(117, 312);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 50);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(223, 312);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 50);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(329, 312);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 50);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(117, 257);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 50);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(223, 257);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 50);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(329, 257);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 50);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(117, 201);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 50);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(223, 201);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 50);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(329, 201);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 50);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(435, 312);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(435, 257);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(100, 50);
            btnSubstract.TabIndex = 13;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubtract_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(435, 368);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(100, 50);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(329, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 50);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.BackColor = Color.Transparent;
            btnMemorySave.Location = new Point(329, 118);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(100, 23);
            btnMemorySave.TabIndex = 16;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = false;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(btnMemorySave);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnSubstract);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(grpMemory);
            Controls.Add(lblDisplay);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            grpMemory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisplay;
        private GroupBox grpMemory;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSubstract;
        private Button btnEquals;
        private Button btnClear;
        private Button btnMemoryAdd;
        private Button btnMemorySubstract;
        private Button btnMemorySave;
    }
}
