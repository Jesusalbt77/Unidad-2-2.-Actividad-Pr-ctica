namespace Form14
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            comboBox2 = new ComboBox();
            label1 = new Label();
            tabPage1 = new TabPage();
            comboBox3 = new ComboBox();
            label2 = new Label();
            tabPage4 = new TabPage();
            comboBox1 = new ComboBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(115, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 245);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(464, 212);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos del usuario";
            tabPage2.Click += tabPage2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jesús Alberto Lebron", "Josue Lebron", "Yessica Leberon", "Yasiel Lebron ", "Yenniffer Lebron" });
            comboBox2.Location = new Point(194, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(215, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(182, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la persona";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.RosyBrown;
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(464, 212);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dirección";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Calle mutualista#16", "Calle Simón Bolivar#7", "Callejon Ortiz#10", "Calle la Victoria #44", "Calle Maicol de la Gaviota# 30" });
            comboBox3.Location = new Point(95, 20);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(198, 25);
            comboBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 2;
            label2.Text = "Dirección";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.PeachPuff;
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(464, 212);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pais";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mexíco", "Perú", "Francia", "España", "EE.UU", "Guatemala", "Rep. Dom" });
            comboBox1.Location = new Point(65, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 37);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 0;
            label3.Text = "Pais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}
