namespace Hue01
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
            this.btn_Daten = new System.Windows.Forms.Button();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_tempm = new System.Windows.Forms.Label();
            this.txt_akt_Temp = new System.Windows.Forms.TextBox();
            this.txt_mitt_Temp = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Daten
            // 
            this.btn_Daten.Location = new System.Drawing.Point(511, 63);
            this.btn_Daten.Name = "btn_Daten";
            this.btn_Daten.Size = new System.Drawing.Size(165, 44);
            this.btn_Daten.TabIndex = 0;
            this.btn_Daten.Text = "Daten auslesen";
            this.btn_Daten.UseVisualStyleBackColor = true;
            this.btn_Daten.Click += new System.EventHandler(this.btn_Daten_Click);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_port.Location = new System.Drawing.Point(146, 78);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(50, 25);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "Port:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp.Location = new System.Drawing.Point(105, 210);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(185, 25);
            this.lbl_temp.TabIndex = 2;
            this.lbl_temp.Text = "Aktuelle Temperatur:";
            // 
            // lbl_tempm
            // 
            this.lbl_tempm.AutoSize = true;
            this.lbl_tempm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tempm.Location = new System.Drawing.Point(105, 292);
            this.lbl_tempm.Name = "lbl_tempm";
            this.lbl_tempm.Size = new System.Drawing.Size(257, 25);
            this.lbl_tempm.TabIndex = 3;
            this.lbl_tempm.Text = "Mittelwert Temperatur(5min):";
            // 
            // txt_akt_Temp
            // 
            this.txt_akt_Temp.Location = new System.Drawing.Point(394, 210);
            this.txt_akt_Temp.Name = "txt_akt_Temp";
            this.txt_akt_Temp.ReadOnly = true;
            this.txt_akt_Temp.Size = new System.Drawing.Size(125, 23);
            this.txt_akt_Temp.TabIndex = 4;
            // 
            // txt_mitt_Temp
            // 
            this.txt_mitt_Temp.Location = new System.Drawing.Point(394, 292);
            this.txt_mitt_Temp.Name = "txt_mitt_Temp";
            this.txt_mitt_Temp.ReadOnly = true;
            this.txt_mitt_Temp.Size = new System.Drawing.Size(125, 23);
            this.txt_mitt_Temp.TabIndex = 5;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(257, 77);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(208, 23);
            this.txt_port.TabIndex = 6;
            this.txt_port.TextChanged += new System.EventHandler(this.txt_port_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_mitt_Temp);
            this.Controls.Add(this.txt_akt_Temp);
            this.Controls.Add(this.lbl_tempm);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.btn_Daten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Daten;
        private Label lbl_port;
        private Label lbl_temp;
        private Label lbl_tempm;
        private TextBox txt_akt_Temp;
        private TextBox txt_mitt_Temp;
        private TextBox txt_port;
    }
}