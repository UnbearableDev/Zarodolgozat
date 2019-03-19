namespace Asztali_alkalmazás_Záródolgozat.Nézet
{
    partial class Bejelentkezés
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBejelentkezes = new System.Windows.Forms.Button();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJelszo = new System.Windows.Forms.TextBox();
            this.textBoxFelhasznalonev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBejelentkezes
            // 
            this.buttonBejelentkezes.Location = new System.Drawing.Point(87, 288);
            this.buttonBejelentkezes.Name = "buttonBejelentkezes";
            this.buttonBejelentkezes.Size = new System.Drawing.Size(85, 23);
            this.buttonBejelentkezes.TabIndex = 0;
            this.buttonBejelentkezes.Text = "Bejelentkezés";
            this.buttonBejelentkezes.UseVisualStyleBackColor = true;
            this.buttonBejelentkezes.Click += new System.EventHandler(this.buttonBejelentkezes_Click);
            // 
            // buttonMegse
            // 
            this.buttonMegse.Location = new System.Drawing.Point(87, 317);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(85, 23);
            this.buttonMegse.TabIndex = 1;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = true;
            this.buttonMegse.Click += new System.EventHandler(this.buttonMegse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // textBoxJelszo
            // 
            this.textBoxJelszo.Location = new System.Drawing.Point(82, 177);
            this.textBoxJelszo.Name = "textBoxJelszo";
            this.textBoxJelszo.Size = new System.Drawing.Size(100, 20);
            this.textBoxJelszo.TabIndex = 4;
            // 
            // textBoxFelhasznalonev
            // 
            this.textBoxFelhasznalonev.Location = new System.Drawing.Point(82, 93);
            this.textBoxFelhasznalonev.Name = "textBoxFelhasznalonev";
            this.textBoxFelhasznalonev.Size = new System.Drawing.Size(100, 20);
            this.textBoxFelhasznalonev.TabIndex = 5;
            // 
            // Bejelentkezés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 361);
            this.Controls.Add(this.textBoxFelhasznalonev);
            this.Controls.Add(this.textBoxJelszo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMegse);
            this.Controls.Add(this.buttonBejelentkezes);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Bejelentkezés";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Bejelentkezés_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBejelentkezes;
        private System.Windows.Forms.Button buttonMegse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJelszo;
        private System.Windows.Forms.TextBox textBoxFelhasznalonev;
    }
}

