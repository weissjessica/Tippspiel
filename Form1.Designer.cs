namespace Weiss_Jessica_Tippspiel
{
    partial class txtBox_Tipp1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTipp = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.txtBoxTipp1 = new System.Windows.Forms.TextBox();
            this.txtBoxTipp2 = new System.Windows.Forms.TextBox();
            this.txtBoxEinsatz = new System.Windows.Forms.TextBox();
            this.lblEinsatz = new System.Windows.Forms.Label();
            this.txtBoxErgebnis1 = new System.Windows.Forms.TextBox();
            this.txtBoxErgebnis2 = new System.Windows.Forms.TextBox();
            this.lblTippDoppelp = new System.Windows.Forms.Label();
            this.lblErgebnisDoppelp = new System.Windows.Forms.Label();
            this.btnGewinnertmitteln = new System.Windows.Forms.Button();
            this.lblIhrGewinn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeader.Location = new System.Drawing.Point(42, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(257, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tippen und Gewinnen!";
            // 
            // lblTipp
            // 
            this.lblTipp.AutoSize = true;
            this.lblTipp.Location = new System.Drawing.Point(42, 138);
            this.lblTipp.Name = "lblTipp";
            this.lblTipp.Size = new System.Drawing.Size(43, 20);
            this.lblTipp.TabIndex = 1;
            this.lblTipp.Text = "Tipp:";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(42, 196);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(76, 20);
            this.lblErgebnis.TabIndex = 2;
            this.lblErgebnis.Text = "Ergebnis:";
            // 
            // txtBoxTipp1
            // 
            this.txtBoxTipp1.Location = new System.Drawing.Point(145, 138);
            this.txtBoxTipp1.Name = "txtBoxTipp1";
            this.txtBoxTipp1.Size = new System.Drawing.Size(61, 26);
            this.txtBoxTipp1.TabIndex = 3;
            // 
            // txtBoxTipp2
            // 
            this.txtBoxTipp2.Location = new System.Drawing.Point(247, 138);
            this.txtBoxTipp2.Name = "txtBoxTipp2";
            this.txtBoxTipp2.Size = new System.Drawing.Size(61, 26);
            this.txtBoxTipp2.TabIndex = 4;
            // 
            // txtBoxEinsatz
            // 
            this.txtBoxEinsatz.Location = new System.Drawing.Point(145, 81);
            this.txtBoxEinsatz.Name = "txtBoxEinsatz";
            this.txtBoxEinsatz.Size = new System.Drawing.Size(163, 26);
            this.txtBoxEinsatz.TabIndex = 1;
            this.txtBoxEinsatz.TextChanged += new System.EventHandler(this.txtBoxEinsatz_TextChanged);
            // 
            // lblEinsatz
            // 
            this.lblEinsatz.AutoSize = true;
            this.lblEinsatz.Location = new System.Drawing.Point(46, 86);
            this.lblEinsatz.Name = "lblEinsatz";
            this.lblEinsatz.Size = new System.Drawing.Size(89, 20);
            this.lblEinsatz.TabIndex = 6;
            this.lblEinsatz.Text = "Ihr Einsatz:";
            // 
            // txtBoxErgebnis1
            // 
            this.txtBoxErgebnis1.Location = new System.Drawing.Point(145, 196);
            this.txtBoxErgebnis1.Name = "txtBoxErgebnis1";
            this.txtBoxErgebnis1.Size = new System.Drawing.Size(61, 26);
            this.txtBoxErgebnis1.TabIndex = 6;
            // 
            // txtBoxErgebnis2
            // 
            this.txtBoxErgebnis2.Location = new System.Drawing.Point(247, 195);
            this.txtBoxErgebnis2.Name = "txtBoxErgebnis2";
            this.txtBoxErgebnis2.Size = new System.Drawing.Size(61, 26);
            this.txtBoxErgebnis2.TabIndex = 8;
            // 
            // lblTippDoppelp
            // 
            this.lblTippDoppelp.AutoSize = true;
            this.lblTippDoppelp.Location = new System.Drawing.Point(228, 141);
            this.lblTippDoppelp.Name = "lblTippDoppelp";
            this.lblTippDoppelp.Size = new System.Drawing.Size(13, 20);
            this.lblTippDoppelp.TabIndex = 9;
            this.lblTippDoppelp.Text = ":";
            // 
            // lblErgebnisDoppelp
            // 
            this.lblErgebnisDoppelp.AutoSize = true;
            this.lblErgebnisDoppelp.Location = new System.Drawing.Point(228, 202);
            this.lblErgebnisDoppelp.Name = "lblErgebnisDoppelp";
            this.lblErgebnisDoppelp.Size = new System.Drawing.Size(13, 20);
            this.lblErgebnisDoppelp.TabIndex = 10;
            this.lblErgebnisDoppelp.Text = ":";
            // 
            // btnGewinnertmitteln
            // 
            this.btnGewinnertmitteln.Location = new System.Drawing.Point(145, 270);
            this.btnGewinnertmitteln.Name = "btnGewinnertmitteln";
            this.btnGewinnertmitteln.Size = new System.Drawing.Size(163, 35);
            this.btnGewinnertmitteln.TabIndex = 11;
            this.btnGewinnertmitteln.Text = "Gewinn ermitteln";
            this.btnGewinnertmitteln.UseVisualStyleBackColor = true;
            this.btnGewinnertmitteln.Click += new System.EventHandler(this.btnGewinnertmitteln_Click);
            // 
            // lblIhrGewinn
            // 
            this.lblIhrGewinn.AutoSize = true;
            this.lblIhrGewinn.Location = new System.Drawing.Point(145, 339);
            this.lblIhrGewinn.Name = "lblIhrGewinn";
            this.lblIhrGewinn.Size = new System.Drawing.Size(90, 20);
            this.lblIhrGewinn.TabIndex = 12;
            this.lblIhrGewinn.Text = "Ihr Gewinn:";
            // 
            // txtBox_Tipp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIhrGewinn);
            this.Controls.Add(this.btnGewinnertmitteln);
            this.Controls.Add(this.lblErgebnisDoppelp);
            this.Controls.Add(this.lblTippDoppelp);
            this.Controls.Add(this.txtBoxErgebnis2);
            this.Controls.Add(this.txtBoxErgebnis1);
            this.Controls.Add(this.lblEinsatz);
            this.Controls.Add(this.txtBoxEinsatz);
            this.Controls.Add(this.txtBoxTipp2);
            this.Controls.Add(this.txtBoxTipp1);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.lblTipp);
            this.Controls.Add(this.lblHeader);
            this.Name = "txtBox_Tipp1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTipp;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.TextBox txtBoxTipp1;
        private System.Windows.Forms.TextBox txtBoxTipp2;
        private System.Windows.Forms.TextBox txtBoxEinsatz;
        private System.Windows.Forms.Label lblEinsatz;
        private System.Windows.Forms.TextBox txtBoxErgebnis1;
        private System.Windows.Forms.TextBox txtBoxErgebnis2;
        private System.Windows.Forms.Label lblTippDoppelp;
        private System.Windows.Forms.Label lblErgebnisDoppelp;
        private System.Windows.Forms.Button btnGewinnertmitteln;
        private System.Windows.Forms.Label lblIhrGewinn;
    }
}

