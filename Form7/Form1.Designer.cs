namespace Form7
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
            btnguardar = new Button();
            textBox1 = new TextBox();
            ListBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(43, 45);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(94, 29);
            btnguardar.TabIndex = 0;
            btnguardar.Text = "guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 27);
            textBox1.TabIndex = 1;
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.Location = new Point(183, 115);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(213, 164);
            ListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ListBox1);
            Controls.Add(textBox1);
            Controls.Add(btnguardar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnguardar;
        private TextBox textBox1;
        private ListBox ListBox1;
    }
}
