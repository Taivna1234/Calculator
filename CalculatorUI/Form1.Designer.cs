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
            components = new System.ComponentModel.Container();
            lblDisplay = new Label();
            grpMemory = new GroupBox();
            lblMemoryLast = new Label();
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
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button2 = new Button();
            button3 = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            standardToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Name1 = new Button();
            titlebtn = new Button();
            grpMemory.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 20F);
            lblDisplay.Location = new Point(298, 167);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 37);
            lblDisplay.TabIndex = 0;
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpMemory
            // 
            grpMemory.BackColor = Color.Azure;
            grpMemory.Controls.Add(lblMemoryLast);
            grpMemory.Controls.Add(btnMemoryAdd);
            grpMemory.Controls.Add(btnMemorySubstract);
            grpMemory.Font = new Font("Segoe UI", 9F);
            grpMemory.Location = new Point(486, 38);
            grpMemory.Name = "grpMemory";
            grpMemory.Size = new Size(290, 128);
            grpMemory.TabIndex = 1;
            grpMemory.TabStop = false;
            grpMemory.Enter += grpMemory_Enter;
            // 
            // lblMemoryLast
            // 
            lblMemoryLast.AutoSize = true;
            lblMemoryLast.Font = new Font("Segoe UI", 15F);
            lblMemoryLast.Location = new Point(6, 68);
            lblMemoryLast.Name = "lblMemoryLast";
            lblMemoryLast.Size = new Size(23, 28);
            lblMemoryLast.TabIndex = 18;
            lblMemoryLast.Text = "0";
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.BackColor = Color.Transparent;
            btnMemoryAdd.ForeColor = Color.Black;
            btnMemoryAdd.Location = new Point(83, 99);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(75, 23);
            btnMemoryAdd.TabIndex = 16;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = false;
            btnMemoryAdd.Click += btnMemoryAdd_Click;
            // 
            // btnMemorySubstract
            // 
            btnMemorySubstract.BackColor = Color.Transparent;
            btnMemorySubstract.Location = new Point(0, 99);
            btnMemorySubstract.Name = "btnMemorySubstract";
            btnMemorySubstract.Size = new Size(75, 23);
            btnMemorySubstract.TabIndex = 17;
            btnMemorySubstract.Text = "M-";
            btnMemorySubstract.UseVisualStyleBackColor = false;
            btnMemorySubstract.Click += btnMemorySubtract_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(112, 411);
            btn0.Name = "btn0";
            btn0.Size = new Size(92, 40);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(19, 368);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 40);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(112, 368);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 40);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(205, 368);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 40);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(19, 322);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 40);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(112, 322);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 40);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(205, 322);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 40);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(19, 276);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 40);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(112, 276);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 40);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(205, 276);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 40);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(298, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(298, 322);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(92, 40);
            btnSubstract.TabIndex = 13;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnSubtract_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(298, 411);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(92, 40);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(205, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 40);
            btnClear.TabIndex = 15;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.BackColor = Color.Transparent;
            btnMemorySave.FlatAppearance.BorderSize = 0;
            btnMemorySave.FlatStyle = FlatStyle.Flat;
            btnMemorySave.Location = new Point(298, 207);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(92, 23);
            btnMemorySave.TabIndex = 16;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // button1
            // 
            button1.Location = new Point(298, 276);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 17;
            button1.Text = "*";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button2
            // 
            button2.Location = new Point(205, 411);
            button2.Name = "button2";
            button2.Size = new Size(92, 40);
            button2.TabIndex = 18;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(19, 414);
            button3.Name = "button3";
            button3.Size = new Size(92, 37);
            button3.TabIndex = 19;
            button3.Text = "+/-";
            button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { standardToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(122, 26);
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(121, 22);
            standardToolStripMenuItem.Text = "Standard";
            // 
            // Name1
            // 
            Name1.BackColor = Color.Transparent;
            Name1.FlatAppearance.BorderSize = 0;
            Name1.FlatStyle = FlatStyle.Flat;
            Name1.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name1.Location = new Point(1, 1);
            Name1.Name = "Name1";
            Name1.Size = new Size(223, 65);
            Name1.TabIndex = 20;
            Name1.Text = "≡Standard Calculator";
            Name1.UseVisualStyleBackColor = false;
            // 
            // titlebtn
            // 
            titlebtn.BackColor = Color.Transparent;
            titlebtn.FlatAppearance.BorderSize = 0;
            titlebtn.FlatStyle = FlatStyle.Flat;
            titlebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlebtn.Location = new Point(486, 12);
            titlebtn.Name = "titlebtn";
            titlebtn.Size = new Size(75, 23);
            titlebtn.TabIndex = 21;
            titlebtn.Text = "Memory";
            titlebtn.UseVisualStyleBackColor = true;
            titlebtn.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(808, 450);
            Controls.Add(titlebtn);
            Controls.Add(Name1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            grpMemory.PerformLayout();
            contextMenuStrip3.ResumeLayout(false);
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
        private Label lblMemoryLast;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private Button button3;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem standardToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Name1;
        private Button titlebtn;
    }
}
