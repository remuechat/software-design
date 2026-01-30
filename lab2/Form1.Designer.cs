namespace lab2
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
            factorialArrayInput = new TextBox();
            btnFibbonacciSequence = new Button();
            lblFactorialResult = new Label();
            lblSumResult = new Label();
            this.btnSum = new Button();
            sumArrayInput = new TextBox();
            lblFibbonacciResult = new Label();
            btnFibSequence = new Button();
            fibArrayInput = new TextBox();
            lblPowResult = new Label();
            btnPowerCalc = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblPowN = new TextBox();
            lblPowX = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // factorialArrayInput
            // 
            factorialArrayInput.Location = new Point(222, 110);
            factorialArrayInput.Name = "factorialArrayInput";
            factorialArrayInput.Size = new Size(409, 23);
            factorialArrayInput.TabIndex = 0;
            // 
            // btnFibbonacciSequence
            // 
            btnFibbonacciSequence.Location = new Point(97, 110);
            btnFibbonacciSequence.Name = "btnFibbonacciSequence";
            btnFibbonacciSequence.Size = new Size(119, 23);
            btnFibbonacciSequence.TabIndex = 1;
            btnFibbonacciSequence.Text = "Calculate Factorial";
            btnFibbonacciSequence.UseVisualStyleBackColor = true;
            btnFibbonacciSequence.Click += btnCalculateFactorial_Click;
            // 
            // lblFactorialResult
            // 
            lblFactorialResult.AutoSize = true;
            lblFactorialResult.Location = new Point(222, 136);
            lblFactorialResult.Name = "lblFactorialResult";
            lblFactorialResult.Size = new Size(138, 15);
            lblFactorialResult.TabIndex = 2;
            lblFactorialResult.Text = "Output will be seen here.";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(222, 180);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(138, 15);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Output will be seen here.";
            // 
            // btnSum
            // 
            this.btnSum.Location = new Point(97, 154);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new Size(119, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Calculate Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += this.btnCalculateSum_Click;
            // 
            // sumArrayInput
            // 
            sumArrayInput.Location = new Point(222, 154);
            sumArrayInput.Name = "sumArrayInput";
            sumArrayInput.Size = new Size(409, 23);
            sumArrayInput.TabIndex = 3;
            // 
            // lblFibbonacciResult
            // 
            lblFibbonacciResult.AutoSize = true;
            lblFibbonacciResult.Location = new Point(222, 224);
            lblFibbonacciResult.Name = "lblFibbonacciResult";
            lblFibbonacciResult.Size = new Size(138, 15);
            lblFibbonacciResult.TabIndex = 8;
            lblFibbonacciResult.Text = "Output will be seen here.";
            // 
            // btnFibSequence
            // 
            btnFibSequence.Location = new Point(97, 198);
            btnFibSequence.Name = "btnFibSequence";
            btnFibSequence.Size = new Size(119, 23);
            btnFibSequence.TabIndex = 7;
            btnFibSequence.Text = "Calculate Fib";
            btnFibSequence.UseVisualStyleBackColor = true;
            btnFibSequence.Click += btnFibbonacciSequence_Click;
            // 
            // fibArrayInput
            // 
            fibArrayInput.Location = new Point(222, 198);
            fibArrayInput.Name = "fibArrayInput";
            fibArrayInput.Size = new Size(409, 23);
            fibArrayInput.TabIndex = 6;
            // 
            // lblPowResult
            // 
            lblPowResult.AutoSize = true;
            lblPowResult.Location = new Point(222, 268);
            lblPowResult.Name = "lblPowResult";
            lblPowResult.Size = new Size(138, 15);
            lblPowResult.TabIndex = 11;
            lblPowResult.Text = "Output will be seen here.";
            // 
            // btnPowerCalc
            // 
            btnPowerCalc.Location = new Point(97, 242);
            btnPowerCalc.Name = "btnPowerCalc";
            btnPowerCalc.Size = new Size(119, 23);
            btnPowerCalc.TabIndex = 10;
            btnPowerCalc.Text = "Calculate Pow";
            btnPowerCalc.UseVisualStyleBackColor = true;
            btnPowerCalc.Click += btnPowerCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 245);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "N (base)";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblPowN
            // 
            lblPowN.Location = new Point(279, 242);
            lblPowN.Name = "lblPowN";
            lblPowN.Size = new Size(55, 23);
            lblPowN.TabIndex = 14;
            // 
            // lblPowX
            // 
            lblPowX.Location = new Point(410, 242);
            lblPowX.Name = "lblPowX";
            lblPowX.Size = new Size(55, 23);
            lblPowX.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 246);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 15;
            label2.Text = "X (power)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPowX);
            Controls.Add(label2);
            Controls.Add(lblPowN);
            Controls.Add(label1);
            Controls.Add(lblPowResult);
            Controls.Add(btnPowerCalc);
            Controls.Add(lblFibbonacciResult);
            Controls.Add(btnFibSequence);
            Controls.Add(fibArrayInput);
            Controls.Add(lblSumResult);
            Controls.Add(this.btnSum);
            Controls.Add(sumArrayInput);
            Controls.Add(lblFactorialResult);
            Controls.Add(btnFibbonacciSequence);
            Controls.Add(factorialArrayInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label lblFactorialResult;
        private TextBox txtArrayInput;
        private TextBox factorialArrayInput;
        private Button btnFibbonacciSequence;
        private Label lblSumResult;
        private Button btnSum;
        private Button button2;
        private TextBox lblPowX;
        private Label lblFibbonacciResult;
        private Button btnFibSequence;
        private TextBox fibArrayInput;
        private TextBox textBox3;
        private Label lblPowResult;
        private Button btnPowerCalc;
        private TextBox sumArrayInput;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private TextBox lblPowN;
    }
}
