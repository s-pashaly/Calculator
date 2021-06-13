namespace Calculator
{
    partial class MainForm
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
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnOver = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.lblMemory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonitor
            // 
            this.txtMonitor.BackColor = System.Drawing.Color.White;
            this.txtMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonitor.Enabled = false;
            this.txtMonitor.ForeColor = System.Drawing.Color.Black;
            this.txtMonitor.Location = new System.Drawing.Point(162, 61);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(209, 20);
            this.txtMonitor.TabIndex = 1;
            this.txtMonitor.Text = "0";
            this.txtMonitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(304, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(233, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(162, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Backspace";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Black;
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.ForeColor = System.Drawing.Color.Gold;
            this.btnSqrt.Location = new System.Drawing.Point(352, 127);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 23);
            this.btnSqrt.TabIndex = 5;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            this.btnSqrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Black;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPercent.ForeColor = System.Drawing.Color.Gold;
            this.btnPercent.Location = new System.Drawing.Point(352, 156);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(40, 23);
            this.btnPercent.TabIndex = 6;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnOver
            // 
            this.btnOver.BackColor = System.Drawing.Color.Black;
            this.btnOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOver.ForeColor = System.Drawing.Color.Gold;
            this.btnOver.Location = new System.Drawing.Point(352, 185);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(40, 23);
            this.btnOver.TabIndex = 7;
            this.btnOver.Text = "1/x";
            this.btnOver.UseVisualStyleBackColor = false;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            this.btnOver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Black;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqual.ForeColor = System.Drawing.Color.Gold;
            this.btnEqual.Location = new System.Drawing.Point(352, 214);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(40, 23);
            this.btnEqual.TabIndex = 8;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Black;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.ForeColor = System.Drawing.Color.Gold;
            this.btnPlus.Location = new System.Drawing.Point(306, 214);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Black;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.ForeColor = System.Drawing.Color.Gold;
            this.btnSubtract.Location = new System.Drawing.Point(306, 185);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(40, 23);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnSubtract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Black;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.ForeColor = System.Drawing.Color.Gold;
            this.btnMultiply.Location = new System.Drawing.Point(306, 156);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 23);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnMultiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Black;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.ForeColor = System.Drawing.Color.Gold;
            this.btnDivide.Location = new System.Drawing.Point(306, 127);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 23);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnDivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(164, 127);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 23);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(164, 156);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 23);
            this.btn5.TabIndex = 19;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(164, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 23);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnInvert
            // 
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvert.Location = new System.Drawing.Point(164, 214);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(40, 23);
            this.btnInvert.TabIndex = 17;
            this.btnInvert.Text = "+/-";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            this.btnInvert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Location = new System.Drawing.Point(210, 214);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(40, 23);
            this.btnDot.TabIndex = 16;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(210, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 23);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(210, 156);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 23);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(210, 127);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 23);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.Black;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMC.ForeColor = System.Drawing.Color.Gold;
            this.btnMC.Location = new System.Drawing.Point(260, 127);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(40, 23);
            this.btnMC.TabIndex = 28;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            this.btnMC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.Black;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMR.ForeColor = System.Drawing.Color.Gold;
            this.btnMR.Location = new System.Drawing.Point(260, 156);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 23);
            this.btnMR.TabIndex = 27;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            this.btnMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.Black;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMS.ForeColor = System.Drawing.Color.Gold;
            this.btnMS.Location = new System.Drawing.Point(260, 185);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 23);
            this.btnMS.TabIndex = 26;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            this.btnMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.Color.Black;
            this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMPlus.ForeColor = System.Drawing.Color.Gold;
            this.btnMPlus.Location = new System.Drawing.Point(260, 214);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(40, 23);
            this.btnMPlus.TabIndex = 25;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            this.btnMPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(118, 214);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 23);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(118, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 23);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(118, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 23);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(118, 127);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 23);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(71, 61);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(44, 16);
            this.lblMemory.TabIndex = 29;
            this.lblMemory.Text = "         ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 314);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonitor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Label lblMemory;
    }
}

