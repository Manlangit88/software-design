namespace Task2Week2
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
            txtInput = new TextBox();
            button1 = new Button();
            lblResult = new Label();
            lblSumResult = new Label();
            button2 = new Button();
            txtArrayInput = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(367, 96);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(160, 96);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 1;
            button1.Text = "Calculate Factorial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(529, 105);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(529, 213);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(50, 20);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(160, 204);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 4;
            button2.Text = "Calculate Sum";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(367, 204);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(125, 27);
            txtArrayInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(button2);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button button1;
        private Label lblResult;
        private Label lblSumResult;
        private Button button2;
        private TextBox txtArrayInput;
    }
}
