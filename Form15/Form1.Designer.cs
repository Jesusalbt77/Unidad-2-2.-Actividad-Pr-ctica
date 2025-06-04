namespace Form15
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
            btbAbrir = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnGuardar = new Button();
            saveFileDialog1 = new SaveFileDialog();
            lblGuardar = new Label();
            lblAbrir = new Label();
            SuspendLayout();
            // 
            // btbAbrir
            // 
            btbAbrir.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbAbrir.Location = new Point(12, 34);
            btbAbrir.Name = "btbAbrir";
            btbAbrir.Size = new Size(94, 29);
            btbAbrir.TabIndex = 0;
            btbAbrir.Text = "Abrir";
            btbAbrir.UseVisualStyleBackColor = true;
            btbAbrir.Click += btbAbrir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(444, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar ";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblGuardar
            // 
            lblGuardar.AutoSize = true;
            lblGuardar.Location = new Point(444, 76);
            lblGuardar.Name = "lblGuardar";
            lblGuardar.Size = new Size(111, 20);
            lblGuardar.TabIndex = 3;
            lblGuardar.Text = "Guarda Archivo";
            lblGuardar.Click += lblGuardar_Click;
            // 
            // lblAbrir
            // 
            lblAbrir.AutoSize = true;
            lblAbrir.Location = new Point(12, 76);
            lblAbrir.Name = "lblAbrir";
            lblAbrir.Size = new Size(96, 20);
            lblAbrir.TabIndex = 1;
            lblAbrir.Text = "Abrir Archivo";
            lblAbrir.Click += lblAbrir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGuardar);
            Controls.Add(btnGuardar);
            Controls.Add(lblAbrir);
            Controls.Add(btbAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbAbrir;
        private OpenFileDialog openFileDialog1;
        private Button btnGuardar;
        private SaveFileDialog saveFileDialog1;
        private Label lblGuardar;
        private Label lblAbrir;
    }
}
