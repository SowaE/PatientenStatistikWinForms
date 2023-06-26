namespace PatientenStatistikWinForms
{
    partial class FrmPraxis
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
            this.grpFirma = new System.Windows.Forms.GroupBox();
            this.lbxPatienten = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAnschrift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPraxisname = new System.Windows.Forms.TextBox();
            this.menContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menAnschriftNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschen = new System.Windows.Forms.ToolStripMenuItem();
            this.menContextPatient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menNeuenPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeitenMitarbeiter = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschenMitarbeiter = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFirma.SuspendLayout();
            this.menContext.SuspendLayout();
            this.menContextPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFirma
            // 
            this.grpFirma.Controls.Add(this.lbxPatienten);
            this.grpFirma.Controls.Add(this.label7);
            this.grpFirma.Controls.Add(this.label5);
            this.grpFirma.Controls.Add(this.cbxAnschrift);
            this.grpFirma.Controls.Add(this.label4);
            this.grpFirma.Controls.Add(this.txtPraxisname);
            this.grpFirma.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFirma.Location = new System.Drawing.Point(0, 0);
            this.grpFirma.Margin = new System.Windows.Forms.Padding(2);
            this.grpFirma.Name = "grpFirma";
            this.grpFirma.Padding = new System.Windows.Forms.Padding(2);
            this.grpFirma.Size = new System.Drawing.Size(800, 190);
            this.grpFirma.TabIndex = 3;
            this.grpFirma.TabStop = false;
            this.grpFirma.Text = "Firmendaten";
            // 
            // lbxPatienten
            // 
            this.lbxPatienten.DisplayMember = "DisplayMember";
            this.lbxPatienten.FormattingEnabled = true;
            this.lbxPatienten.Location = new System.Drawing.Point(504, 39);
            this.lbxPatienten.Margin = new System.Windows.Forms.Padding(2);
            this.lbxPatienten.Name = "lbxPatienten";
            this.lbxPatienten.Size = new System.Drawing.Size(285, 147);
            this.lbxPatienten.TabIndex = 14;
            this.lbxPatienten.ValueMember = "ValueMember";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(501, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Patienten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Praxisname *";
            // 
            // cbxAnschrift
            // 
            this.cbxAnschrift.AllowDrop = true;
            this.cbxAnschrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAnschrift.DisplayMember = "DisplayMember";
            this.cbxAnschrift.DropDownHeight = 100;
            this.cbxAnschrift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnschrift.FormattingEnabled = true;
            this.cbxAnschrift.IntegralHeight = false;
            this.cbxAnschrift.Location = new System.Drawing.Point(15, 83);
            this.cbxAnschrift.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAnschrift.Name = "cbxAnschrift";
            this.cbxAnschrift.Size = new System.Drawing.Size(462, 21);
            this.cbxAnschrift.TabIndex = 7;
            this.cbxAnschrift.ValueMember = "ValueMember";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anschrift ...";
            // 
            // txtPraxisname
            // 
            this.txtPraxisname.Location = new System.Drawing.Point(15, 38);
            this.txtPraxisname.Margin = new System.Windows.Forms.Padding(2);
            this.txtPraxisname.MaxLength = 40;
            this.txtPraxisname.Name = "txtPraxisname";
            this.txtPraxisname.Size = new System.Drawing.Size(251, 20);
            this.txtPraxisname.TabIndex = 1;
            this.txtPraxisname.Tag = "*";
            // 
            // menContext
            // 
            this.menContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAnschriftNeu,
            this.menBearbeiten,
            this.menLoeschen});
            this.menContext.Name = "menContext";
            this.menContext.Size = new System.Drawing.Size(246, 70);
            // 
            // menAnschriftNeu
            // 
            this.menAnschriftNeu.Name = "menAnschriftNeu";
            this.menAnschriftNeu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menAnschriftNeu.Size = new System.Drawing.Size(245, 22);
            this.menAnschriftNeu.Text = "Neue Anschrift erstellen";
            // 
            // menBearbeiten
            // 
            this.menBearbeiten.Name = "menBearbeiten";
            this.menBearbeiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeiten.Size = new System.Drawing.Size(245, 22);
            this.menBearbeiten.Text = "bearbeiten";
            // 
            // menLoeschen
            // 
            this.menLoeschen.Name = "menLoeschen";
            this.menLoeschen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschen.Size = new System.Drawing.Size(245, 22);
            this.menLoeschen.Text = "löschen";
            // 
            // menContextPatient
            // 
            this.menContextPatient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContextPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNeuenPatient,
            this.menBearbeitenMitarbeiter,
            this.menLoeschenMitarbeiter});
            this.menContextPatient.Name = "menContext";
            this.menContextPatient.Size = new System.Drawing.Size(242, 70);
            // 
            // menNeuenPatient
            // 
            this.menNeuenPatient.Name = "menNeuenPatient";
            this.menNeuenPatient.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menNeuenPatient.Size = new System.Drawing.Size(241, 22);
            this.menNeuenPatient.Text = "Neuen Patient erstellen";
            // 
            // menBearbeitenMitarbeiter
            // 
            this.menBearbeitenMitarbeiter.Name = "menBearbeitenMitarbeiter";
            this.menBearbeitenMitarbeiter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeitenMitarbeiter.Size = new System.Drawing.Size(262, 22);
            this.menBearbeitenMitarbeiter.Text = "bearbeiten";
            // 
            // menLoeschenMitarbeiter
            // 
            this.menLoeschenMitarbeiter.Name = "menLoeschenMitarbeiter";
            this.menLoeschenMitarbeiter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschenMitarbeiter.Size = new System.Drawing.Size(262, 22);
            this.menLoeschenMitarbeiter.Text = "löschen";
            // 
            // FrmPraxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 263);
            this.Controls.Add(this.grpFirma);
            this.Name = "FrmPraxis";
            this.Text = "Praxis";
            this.grpFirma.ResumeLayout(false);
            this.grpFirma.PerformLayout();
            this.menContext.ResumeLayout(false);
            this.menContextPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFirma;
        public System.Windows.Forms.ListBox lbxPatienten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxAnschrift;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPraxisname;
        private System.Windows.Forms.ContextMenuStrip menContext;
        private System.Windows.Forms.ToolStripMenuItem menAnschriftNeu;
        private System.Windows.Forms.ToolStripMenuItem menBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem menLoeschen;
        private System.Windows.Forms.ContextMenuStrip menContextPatient;
        private System.Windows.Forms.ToolStripMenuItem menNeuenPatient;
        private System.Windows.Forms.ToolStripMenuItem menBearbeitenMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem menLoeschenMitarbeiter;
    }
}