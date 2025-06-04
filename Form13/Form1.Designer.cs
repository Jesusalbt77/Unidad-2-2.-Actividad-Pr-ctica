namespace Form13
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
            progressBar1 = new ProgressBar();
            btniniciar = new Button();
            btndetener = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(160, 61);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(298, 47);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // btniniciar
            // 
            btniniciar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btniniciar.ForeColor = SystemColors.ActiveCaptionText;
            btniniciar.Location = new Point(160, 243);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(104, 55);
            btniniciar.TabIndex = 1;
            btniniciar.Text = "Iniciar";
            btniniciar.UseVisualStyleBackColor = true;
            btniniciar.Click += btniniciar_Click;
            // 
            // btndetener
            // 
            btndetener.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndetener.Location = new Point(354, 243);
            btndetener.Name = "btndetener";
            btndetener.Size = new Size(104, 55);
            btndetener.TabIndex = 2;
            btndetener.Text = "Detener";
            btndetener.UseVisualStyleBackColor = true;
            btndetener.Click += btndetener_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btndetener);
            Controls.Add(btniniciar);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btniniciar;
        private Button btndetener;
        private System.Windows.Forms.Timer timer1;
    }
}
