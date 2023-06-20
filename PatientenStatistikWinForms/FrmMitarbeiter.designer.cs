
namespace PatientenStatistikWinForms
{
    partial class FrmMitarbeiter
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
            this.components = new System.ComponentModel.Container();
            this.grpMitarbeiter = new System.Windows.Forms.GroupBox();
            this.lbxArbeitszeiten = new System.Windows.Forms.ListBox();
            this.menContextArbeitszeiten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menNeuArbeitzeit = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeitenArbeitszeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschenArbeitszeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.nupPersonalNr = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.grpMitarbeiter.SuspendLayout();
            this.menContextArbeitszeiten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonalNr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNachname
            // 
            this.txtNachname.Size = new System.Drawing.Size(1690, 26);
            // 
            // grpMitarbeiter
            // 
            this.grpMitarbeiter.Controls.Add(this.lbxArbeitszeiten);
            this.grpMitarbeiter.Controls.Add(this.label7);
            this.grpMitarbeiter.Controls.Add(this.nupPersonalNr);
            this.grpMitarbeiter.Controls.Add(this.label6);
            this.grpMitarbeiter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMitarbeiter.Location = new System.Drawing.Point(0, 251);
            this.grpMitarbeiter.Name = "grpMitarbeiter";
            this.grpMitarbeiter.Size = new System.Drawing.Size(866, 346);
            this.grpMitarbeiter.TabIndex = 3;
            this.grpMitarbeiter.TabStop = false;
            this.grpMitarbeiter.Text = "Mitarbeiterdaten";
            // 
            // lbxArbeitszeiten
            // 
            this.lbxArbeitszeiten.ContextMenuStrip = this.menContextArbeitszeiten;
            this.lbxArbeitszeiten.DisplayMember = "DisplayMember";
            this.lbxArbeitszeiten.FormattingEnabled = true;
            this.lbxArbeitszeiten.ItemHeight = 20;
            this.lbxArbeitszeiten.Location = new System.Drawing.Point(420, 56);
            this.lbxArbeitszeiten.Name = "lbxArbeitszeiten";
            this.lbxArbeitszeiten.Size = new System.Drawing.Size(426, 284);
            this.lbxArbeitszeiten.TabIndex = 12;
            this.lbxArbeitszeiten.ValueMember = "ValueMember";
            // 
            // menContextArbeitszeiten
            // 
            this.menContextArbeitszeiten.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContextArbeitszeiten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNeuArbeitzeit,
            this.menBearbeitenArbeitszeiten,
            this.menLoeschenArbeitszeiten});
            this.menContextArbeitszeiten.Name = "menContext";
            this.menContextArbeitszeiten.Size = new System.Drawing.Size(353, 100);
            this.menContextArbeitszeiten.Opening += new System.ComponentModel.CancelEventHandler(this.menContextArbeitszeiten_Opening);
            // 
            // menNeuArbeitzeit
            // 
            this.menNeuArbeitzeit.Name = "menNeuArbeitzeit";
            this.menNeuArbeitzeit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menNeuArbeitzeit.Size = new System.Drawing.Size(352, 32);
            this.menNeuArbeitzeit.Text = "Neue Arbeitszeit erstellen";
            this.menNeuArbeitzeit.Click += new System.EventHandler(this.MenNeuArbeitszeiten_Click);
            // 
            // menBearbeitenArbeitszeiten
            // 
            this.menBearbeitenArbeitszeiten.Name = "menBearbeitenArbeitszeiten";
            this.menBearbeitenArbeitszeiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeitenArbeitszeiten.Size = new System.Drawing.Size(352, 32);
            this.menBearbeitenArbeitszeiten.Text = "bearbeiten";
            this.menBearbeitenArbeitszeiten.Click += new System.EventHandler(this.menBearbeitenArbeitszeiten_Click);
            // 
            // menLoeschenArbeitszeiten
            // 
            this.menLoeschenArbeitszeiten.Name = "menLoeschenArbeitszeiten";
            this.menLoeschenArbeitszeiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschenArbeitszeiten.Size = new System.Drawing.Size(352, 32);
            this.menLoeschenArbeitszeiten.Text = "löschen";
            this.menLoeschenArbeitszeiten.Click += new System.EventHandler(this.MenLoeschen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Arbeitszeiten";
            // 
            // nupPersonalNr
            // 
            this.nupPersonalNr.Location = new System.Drawing.Point(23, 56);
            this.nupPersonalNr.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nupPersonalNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPersonalNr.Name = "nupPersonalNr";
            this.nupPersonalNr.Size = new System.Drawing.Size(150, 26);
            this.nupPersonalNr.TabIndex = 10;
            this.nupPersonalNr.Tag = "*";
            this.nupPersonalNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupPersonalNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Eindeutige Personal-Nr. *";
            // 
            // FrmMitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 609);
            this.Controls.Add(this.grpMitarbeiter);
            this.MinimumSize = new System.Drawing.Size(888, 419);
            this.Name = "FrmMitarbeiter";
            this.Text = "FrmMitarbeiter";
            this.Controls.SetChildIndex(this.grpMitarbeiter, 0);
            this.grpMitarbeiter.ResumeLayout(false);
            this.grpMitarbeiter.PerformLayout();
            this.menContextArbeitszeiten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupPersonalNr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMitarbeiter;
        public System.Windows.Forms.NumericUpDown nupPersonalNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip menContextArbeitszeiten;
        private System.Windows.Forms.ToolStripMenuItem menNeuArbeitzeit;
        private System.Windows.Forms.ToolStripMenuItem menBearbeitenArbeitszeiten;
        private System.Windows.Forms.ToolStripMenuItem menLoeschenArbeitszeiten;
        public System.Windows.Forms.ListBox lbxArbeitszeiten;
    }
}