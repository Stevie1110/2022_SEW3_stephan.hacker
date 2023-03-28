namespace hue03
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
            this.dateien_tb = new System.Windows.Forms.TextBox();
            this.analyse_btn = new System.Windows.Forms.Button();
            this.speicherort_btn = new System.Windows.Forms.Button();
            this.Datei_wählen_btn = new System.Windows.Forms.Button();
            this.Ordner_wählen = new System.Windows.Forms.FolderBrowserDialog();
            this.Speicherort = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateien_tb
            // 
            this.dateien_tb.Location = new System.Drawing.Point(193, 119);
            this.dateien_tb.Multiline = true;
            this.dateien_tb.Name = "dateien_tb";
            this.dateien_tb.Size = new System.Drawing.Size(397, 267);
            this.dateien_tb.TabIndex = 0;
            this.dateien_tb.TextChanged += new System.EventHandler(this.dateien_tb_TextChanged);
            // 
            // analyse_btn
            // 
            this.analyse_btn.Location = new System.Drawing.Point(47, 281);
            this.analyse_btn.Name = "analyse_btn";
            this.analyse_btn.Size = new System.Drawing.Size(97, 32);
            this.analyse_btn.TabIndex = 1;
            this.analyse_btn.Text = "Analyse";
            this.analyse_btn.UseVisualStyleBackColor = true;
            this.analyse_btn.Click += new System.EventHandler(this.analyse_btn_Click);
            // 
            // speicherort_btn
            // 
            this.speicherort_btn.Location = new System.Drawing.Point(45, 224);
            this.speicherort_btn.Name = "speicherort_btn";
            this.speicherort_btn.Size = new System.Drawing.Size(99, 35);
            this.speicherort_btn.TabIndex = 2;
            this.speicherort_btn.Text = "Speicherort";
            this.speicherort_btn.UseVisualStyleBackColor = true;
            this.speicherort_btn.Click += new System.EventHandler(this.speicherort_btn_Click);
            // 
            // Datei_wählen_btn
            // 
            this.Datei_wählen_btn.Location = new System.Drawing.Point(45, 168);
            this.Datei_wählen_btn.Name = "Datei_wählen_btn";
            this.Datei_wählen_btn.Size = new System.Drawing.Size(99, 33);
            this.Datei_wählen_btn.TabIndex = 3;
            this.Datei_wählen_btn.Text = "Datei wählen";
            this.Datei_wählen_btn.UseVisualStyleBackColor = true;
            this.Datei_wählen_btn.Click += new System.EventHandler(this.Datei_wählen_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(193, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ladevorgang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Datei_wählen_btn);
            this.Controls.Add(this.speicherort_btn);
            this.Controls.Add(this.analyse_btn);
            this.Controls.Add(this.dateien_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox dateien_tb;
        private Button analyse_btn;
        private Button speicherort_btn;
        private Button Datei_wählen_btn;
        private FolderBrowserDialog Ordner_wählen;
        private FolderBrowserDialog Speicherort;
        private ProgressBar progressBar1;
        private Label label1;
    }
}