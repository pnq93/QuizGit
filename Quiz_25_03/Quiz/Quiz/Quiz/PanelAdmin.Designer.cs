﻿namespace Quiz
{
    partial class PanelAdmin
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
            this.dodaj_pyt = new System.Windows.Forms.Button();
            this.usun_uzyt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj_pyt
            // 
            this.dodaj_pyt.Location = new System.Drawing.Point(40, 27);
            this.dodaj_pyt.Name = "dodaj_pyt";
            this.dodaj_pyt.Size = new System.Drawing.Size(75, 44);
            this.dodaj_pyt.TabIndex = 0;
            this.dodaj_pyt.Text = "Dodaj pytanie";
            this.dodaj_pyt.UseVisualStyleBackColor = true;
            this.dodaj_pyt.Click += new System.EventHandler(this.dodaj_pyt_Click);
            // 
            // usun_uzyt
            // 
            this.usun_uzyt.Location = new System.Drawing.Point(121, 27);
            this.usun_uzyt.Name = "usun_uzyt";
            this.usun_uzyt.Size = new System.Drawing.Size(75, 44);
            this.usun_uzyt.TabIndex = 1;
            this.usun_uzyt.Text = "Usuń użytkownika";
            this.usun_uzyt.UseVisualStyleBackColor = true;
            this.usun_uzyt.Click += new System.EventHandler(this.usun_uzyt_Click);
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 97);
            this.Controls.Add(this.usun_uzyt);
            this.Controls.Add(this.dodaj_pyt);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodaj_pyt;
        private System.Windows.Forms.Button usun_uzyt;
    }
}