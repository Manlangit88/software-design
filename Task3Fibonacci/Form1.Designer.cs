namespace Task3Fibonacci
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
            txtFibonacciInput = new TextBox();
            button1 = new Button();
            lblFibonacciResult = new Label();
            txtBaseInput = new TextBox();
            txtExponentInput = new TextBox();
            button2 = new Button();
            lblPowerResult = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(372, 93);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(125, 27);
            txtFibonacciInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(232, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFibonacci_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(560, 100);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(50, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "label1";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(372, 251);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(125, 27);
            txtBaseInput.TabIndex = 3;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(372, 303);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(125, 27);
            txtExponentInput.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(232, 277);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculatePower_Click;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(560, 277);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(50, 20);
            lblPowerResult.TabIndex = 6;
            lblPowerResult.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 228);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 7;
            label1.Text = "Base :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 286);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 8;
            label2.Text = "Power :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPowerResult);
            Controls.Add(button2);
            Controls.Add(txtExponentInput);
            Controls.Add(txtBaseInput);
            Controls.Add(lblFibonacciResult);
            Controls.Add(button1);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private Button button1;
        private Label lblFibonacciResult;
        private TextBox txtBaseInput;
        private TextBox txtExponentInput;
        private Button button2;
        private Label lblPowerResult;
        private Label label1;
        private Label label2;
    }
}
