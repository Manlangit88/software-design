namespace Task3Week2
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
            lblPowerResult = new Label();
            button2 = new Button();
            txtExponentInput = new TextBox();
            txtBaseInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(337, 92);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(125, 27);
            txtFibonacciInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(199, 92);
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
            lblFibonacciResult.Location = new Point(516, 99);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(50, 20);
            lblFibonacciResult.TabIndex = 2;
            lblFibonacciResult.Text = "label1";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(516, 265);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(50, 20);
            lblPowerResult.TabIndex = 5;
            lblPowerResult.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(199, 261);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculatePower_Click;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(338, 294);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(125, 27);
            txtExponentInput.TabIndex = 3;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(338, 227);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(125, 27);
            txtBaseInput.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 204);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 7;
            label3.Text = "Base :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 271);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Exponent :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBaseInput);
            Controls.Add(lblPowerResult);
            Controls.Add(button2);
            Controls.Add(txtExponentInput);
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
        private Label lblPowerResult;
        private Button button2;
        private TextBox txtExponentInput;
        private TextBox txtBaseInput;
        private Label label3;
        private Label label4;
    }
}
