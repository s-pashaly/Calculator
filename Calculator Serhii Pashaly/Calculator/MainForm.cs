using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        enum ArithmaticOperation { Addition,Subtraction,Multiplication,Division,None};
        bool intStream;
        bool dotPressed;
        double fisrtOperand;
        double secondOperand;
        double memoryOperand;      
        ArithmaticOperation currentOperation;

        public MainForm()
        {
            InitializeComponent();
            intStream = true;
            currentOperation = ArithmaticOperation.None;
            fisrtOperand = 0.0;
            ResetMemory();
            dotPressed = false;
        }

        void ResetMemory()
        {
            memoryOperand = 0.0;
        }

        double ExtractNumber(string name)
        {
            return Convert.ToDouble((name[name.Length - 1]).ToString());
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            double number = ExtractNumber(currentButton.Name);
            if (intStream)
            {
                if (this.txtMonitor.Text == "0")
                    PutStringOnScreen(number.ToString());
                else
                    AppendStringOnString(number.ToString());
            }
            else
            {
                this.intStream = true;
                fisrtOperand = Convert.ToDouble(this.txtMonitor.Text);
                PutStringOnScreen(number.ToString());
            }
        }

        void AppendStringOnString(string text)
        {
            this.txtMonitor.Text += text;
        }

        void PutStringOnScreen(string text)
        {
            this.txtMonitor.Text = text;
        }

        void GetStringFromScreen()
        { 
        
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.PutStringOnScreen(this.CalculateResult().ToString());
            Button currentButton = (Button)sender;          
            if( currentButton == this.btnPlus)
                    this.currentOperation = ArithmaticOperation.Addition;
            else if(currentButton == this.btnMultiply)
                    this.currentOperation = ArithmaticOperation.Multiplication;
            else if(currentButton == this.btnDivide)
                this.currentOperation = ArithmaticOperation.Division;          
            else if(currentButton == this.btnSubtract)
                this.currentOperation = ArithmaticOperation.Subtraction;
            this.intStream = false;
            dotPressed = false;
        }

        double CalculateResult()
        {
            if(this.intStream)
                secondOperand = Convert.ToDouble(this.txtMonitor.Text);
            if (fisrtOperand == 0.0)
                fisrtOperand = secondOperand;
            else
            {
                switch (this.currentOperation)
                {
                    case ArithmaticOperation.Addition:
                        fisrtOperand += secondOperand;
                        break;
                    case ArithmaticOperation.Subtraction:
                        fisrtOperand -= secondOperand;
                        break;
                    case ArithmaticOperation.Multiplication:
                        fisrtOperand *= secondOperand;
                        break;
                    case ArithmaticOperation.Division:
                        fisrtOperand /= secondOperand;
                        break;
                }
            }
            return fisrtOperand;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.PutStringOnScreen(this.CalculateResult().ToString());
            this.intStream = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefershAll();
        }

        void RefershAll()
        {
            this.fisrtOperand = 0.0;
            this.txtMonitor.Text = "0";
            intStream = true;
            dotPressed = false;
            currentOperation = ArithmaticOperation.None;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!dotPressed)
            {
                if (intStream)
                {
                    if (this.txtMonitor.Text != "0")
                        AppendStringOnString(".");
                    else
                        PutStringOnScreen(".");
                }
                else
                    PutStringOnScreen(".");
                dotPressed = true;
            }
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            double currentOperand = Convert.ToDouble(this.txtMonitor.Text);
            if (currentOperand != 0)
                currentOperand = 1.0 / currentOperand;
            PutStringOnScreen(currentOperand.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double currentOperand = Convert.ToDouble(this.txtMonitor.Text);
            currentOperand = Math.Sqrt(currentOperand);
            PutStringOnScreen(currentOperand.ToString());
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (intStream && this.txtMonitor.Text != "0")
            {
                if (this.txtMonitor.Text[0] == '-')
                    this.txtMonitor.Text = this.txtMonitor.Text.Substring(1);
                else
                    this.txtMonitor.Text = "-" + this.txtMonitor.Text;
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoryOperand += Convert.ToDouble(this.txtMonitor.Text.ToString());
            this.lblMemory.Text = "M";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            this.txtMonitor.Text = memoryOperand.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            this.memoryOperand = 0.0;          
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memoryOperand = Convert.ToDouble(this.txtMonitor.Text.ToString());
            this.lblMemory.Text = "M";
        }

        private void txtMonitor_KeyDown(object sender, KeyEventArgs e)
        {
            int keyCode = (int)e.KeyCode;
            int key0 = (int)Keys.D0;
            int key9 = (int)Keys.D9;
            int k0 = (int)Keys.NumPad0;
            int k9 = (int)Keys.NumPad9;
            if (keyCode >= key0 && keyCode <= key9)
            {
                if (intStream)
                {
                    if (this.txtMonitor.Text == "0")
                        PutStringOnScreen((keyCode - key0).ToString());
                    else
                        AppendStringOnString((keyCode - key0).ToString());
                }
                else
                {
                    intStream = true;
                    PutStringOnScreen((keyCode - key0).ToString());
                }
            }
            else if (keyCode >= k0 && keyCode <= k9)
            {
                if (intStream)
                {
                    if (this.txtMonitor.Text == "0")
                        PutStringOnScreen((keyCode - k0).ToString());
                    else
                        AppendStringOnString((keyCode - k0).ToString());
                }
                else
                {
                    intStream = true;
                    PutStringOnScreen((keyCode - k0).ToString());
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.btnEqual_Click(null, null);
            }
            else if (e.KeyCode == Keys.Back)
                this.button3_Click(null, null);
            else
            {
                Button currentButton = null;
                switch (e.KeyCode)
                {
                    case Keys.Divide:
                        currentButton = this.btnDivide;
                        break;
                    case Keys.Multiply:
                        currentButton = this.btnMultiply;
                        break;
                    case Keys.Add:
                        currentButton = this.btnPlus;
                        break;
                    case Keys.Subtract:
                        currentButton = this.btnSubtract;
                        break;
                }
                if (currentButton != null)
                    this.btnDivide_Click(currentButton, null);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.txtMonitor.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (intStream)
            {
                if (this.txtMonitor.Text == "")
                    this.txtMonitor.Text = "0";
                else if (Convert.ToDouble(this.txtMonitor.Text) != 0.0)
                {
                    this.txtMonitor.Text = this.txtMonitor.Text.Substring(0, this.txtMonitor.Text.Length - 1);
                    if (this.txtMonitor.Text == "")
                        this.txtMonitor.Text = "0";
                }
            }
        }
    }
}