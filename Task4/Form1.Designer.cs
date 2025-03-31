namespace Task4
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
            listBoxView = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBoxView
            // 
            listBoxView.FormattingEnabled = true;
            listBoxView.Location = new Point(429, 132);
            listBoxView.Name = "listBoxView";
            listBoxView.Size = new Size(264, 224);
            listBoxView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(273, 132);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBoxView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxView;
        private Button button1;
    }
}
