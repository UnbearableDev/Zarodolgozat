namespace Asztali_alkalmazás_Záródolgozat.Nézet
{
    partial class Szerkesztés
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonMégse = new System.Windows.Forms.Button();
            this.textBoxSzerkVaros = new System.Windows.Forms.TextBox();
            this.textBoxSzerkNev = new System.Windows.Forms.TextBox();
            this.textBoxSzerkEmail = new System.Windows.Forms.TextBox();
            this.textBoxSzerkMegrendeles = new System.Windows.Forms.TextBox();
            this.textBoxSzerkMegrendelestipusa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefonszám = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(91, 330);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Elfogadás";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonMégse
            // 
            this.buttonMégse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonMégse.Location = new System.Drawing.Point(91, 359);
            this.buttonMégse.Name = "buttonMégse";
            this.buttonMégse.Size = new System.Drawing.Size(75, 23);
            this.buttonMégse.TabIndex = 1;
            this.buttonMégse.Text = "Mégse";
            this.buttonMégse.UseVisualStyleBackColor = true;
            // 
            // textBoxSzerkVaros
            // 
            this.textBoxSzerkVaros.Location = new System.Drawing.Point(85, 144);
            this.textBoxSzerkVaros.Name = "textBoxSzerkVaros";
            this.textBoxSzerkVaros.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkVaros.TabIndex = 3;
            // 
            // textBoxSzerkNev
            // 
            this.textBoxSzerkNev.Location = new System.Drawing.Point(83, 105);
            this.textBoxSzerkNev.Name = "textBoxSzerkNev";
            this.textBoxSzerkNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkNev.TabIndex = 4;
            this.textBoxSzerkNev.TextChanged += new System.EventHandler(this.textBoxSzerkNev_TextChanged);
            // 
            // textBoxSzerkEmail
            // 
            this.textBoxSzerkEmail.Location = new System.Drawing.Point(85, 187);
            this.textBoxSzerkEmail.Name = "textBoxSzerkEmail";
            this.textBoxSzerkEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkEmail.TabIndex = 5;
            // 
            // textBoxSzerkMegrendeles
            // 
            this.textBoxSzerkMegrendeles.Location = new System.Drawing.Point(85, 225);
            this.textBoxSzerkMegrendeles.Name = "textBoxSzerkMegrendeles";
            this.textBoxSzerkMegrendeles.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkMegrendeles.TabIndex = 6;
            // 
            // textBoxSzerkMegrendelestipusa
            // 
            this.textBoxSzerkMegrendelestipusa.Location = new System.Drawing.Point(85, 263);
            this.textBoxSzerkMegrendelestipusa.Name = "textBoxSzerkMegrendelestipusa";
            this.textBoxSzerkMegrendelestipusa.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkMegrendelestipusa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Város";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Munka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Munkatípus";
            // 
            // textBoxTelefonszám
            // 
            this.textBoxTelefonszám.Location = new System.Drawing.Point(83, 304);
            this.textBoxTelefonszám.Name = "textBoxTelefonszám";
            this.textBoxTelefonszám.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefonszám.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefonszám";
            // 
            // Szerkesztés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTelefonszám);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSzerkMegrendelestipusa);
            this.Controls.Add(this.textBoxSzerkMegrendeles);
            this.Controls.Add(this.textBoxSzerkEmail);
            this.Controls.Add(this.textBoxSzerkNev);
            this.Controls.Add(this.textBoxSzerkVaros);
            this.Controls.Add(this.buttonMégse);
            this.Controls.Add(this.buttonOK);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Szerkesztés";
            this.Text = "Szerkesztés";
            this.Load += new System.EventHandler(this.Szerkesztés_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonMégse;
        private System.Windows.Forms.TextBox textBoxSzerkVaros;
        private System.Windows.Forms.TextBox textBoxSzerkNev;
        private System.Windows.Forms.TextBox textBoxSzerkEmail;
        private System.Windows.Forms.TextBox textBoxSzerkMegrendeles;
        private System.Windows.Forms.TextBox textBoxSzerkMegrendelestipusa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefonszám;
        private System.Windows.Forms.Label label7;
    }
}