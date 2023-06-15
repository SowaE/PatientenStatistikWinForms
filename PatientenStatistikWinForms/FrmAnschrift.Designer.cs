
namespace PatientenStatistikWinForms
{
    partial class FrmAnschrift
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
            this.grpAnschrift = new System.Windows.Forms.GroupBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHausNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStrasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnschrift.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnschrift
            // 
            this.grpAnschrift.Controls.Add(this.txtOrt);
            this.grpAnschrift.Controls.Add(this.label5);
            this.grpAnschrift.Controls.Add(this.txtPLZ);
            this.grpAnschrift.Controls.Add(this.label4);
            this.grpAnschrift.Controls.Add(this.txtLand);
            this.grpAnschrift.Controls.Add(this.label3);
            this.grpAnschrift.Controls.Add(this.txtHausNr);
            this.grpAnschrift.Controls.Add(this.label2);
            this.grpAnschrift.Controls.Add(this.txtStrasse);
            this.grpAnschrift.Controls.Add(this.label1);
            this.grpAnschrift.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAnschrift.Location = new System.Drawing.Point(0, 0);
            this.grpAnschrift.Name = "grpAnschrift";
            this.grpAnschrift.Size = new System.Drawing.Size(570, 171);
            this.grpAnschrift.TabIndex = 0;
            this.grpAnschrift.TabStop = false;
            this.grpAnschrift.Text = "Anschrift";
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(180, 121);
            this.txtOrt.MaxLength = 40;
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(359, 26);
            this.txtOrt.TabIndex = 9;
            this.txtOrt.Tag = "*";
            this.txtOrt.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ort *";
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(77, 121);
            this.txtPLZ.MaxLength = 20;
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(91, 26);
            this.txtPLZ.TabIndex = 7;
            this.txtPLZ.Tag = "*";
            this.txtPLZ.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLZ *";
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(28, 121);
            this.txtLand.MaxLength = 3;
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(37, 26);
            this.txtLand.TabIndex = 5;
            this.txtLand.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Land";
            // 
            // txtHausNr
            // 
            this.txtHausNr.Location = new System.Drawing.Point(468, 58);
            this.txtHausNr.MaxLength = 10;
            this.txtHausNr.Name = "txtHausNr";
            this.txtHausNr.Size = new System.Drawing.Size(71, 26);
            this.txtHausNr.TabIndex = 3;
            this.txtHausNr.Tag = "*";
            this.txtHausNr.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haus-Nr. *";
            // 
            // txtStrasse
            // 
            this.txtStrasse.Location = new System.Drawing.Point(28, 58);
            this.txtStrasse.MaxLength = 40;
            this.txtStrasse.Name = "txtStrasse";
            this.txtStrasse.Size = new System.Drawing.Size(429, 26);
            this.txtStrasse.TabIndex = 1;
            this.txtStrasse.Tag = "*";
            this.txtStrasse.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Straße *";
            // 
            // FrmAnschrift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 184);
            this.Controls.Add(this.grpAnschrift);
            this.MinimumSize = new System.Drawing.Size(592, 240);
            this.Name = "FrmAnschrift";
            this.Tag = "*";
            this.Text = "Anschrift bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnschrift_FormClosing);
            this.grpAnschrift.ResumeLayout(false);
            this.grpAnschrift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAnschrift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtHausNr;
        public System.Windows.Forms.TextBox txtStrasse;
        public System.Windows.Forms.TextBox txtLand;
        public System.Windows.Forms.TextBox txtOrt;
        public System.Windows.Forms.TextBox txtPLZ;
    }
}

