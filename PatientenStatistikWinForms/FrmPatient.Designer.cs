
namespace PatientenStatistikWinForms
{
    partial class FrmPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxAnwesenheiten = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nupPatientNr = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.menContextAnwesenheiten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenNeuAnwesenheiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeitenAnwesenheiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschenArbeitszeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientNr)).BeginInit();
            this.menContextAnwesenheiten.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNachname
            // 
            this.txtNachname.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNachname.Size = new System.Drawing.Size(341, 20);
            // 
            // txtVorname
            // 
            this.txtVorname.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            // 
            // cbxAnschrift
            // 
            this.cbxAnschrift.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbxAnschrift.Size = new System.Drawing.Size(341, 21);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxAnwesenheiten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nupPatientNr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(655, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patientendaten";
            // 
            // lbxAnwesenheiten
            // 
            this.lbxAnwesenheiten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAnwesenheiten.ContextMenuStrip = this.menContextAnwesenheiten;
            this.lbxAnwesenheiten.DisplayMember = "DisplayMember";
            this.lbxAnwesenheiten.FormattingEnabled = true;
            this.lbxAnwesenheiten.Location = new System.Drawing.Point(179, 45);
            this.lbxAnwesenheiten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxAnwesenheiten.Name = "lbxAnwesenheiten";
            this.lbxAnwesenheiten.Size = new System.Drawing.Size(459, 238);
            this.lbxAnwesenheiten.TabIndex = 4;
            this.lbxAnwesenheiten.ValueMember = "ValueMember";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Anwesenheitstaage";
            // 
            // nupPatientNr
            // 
            this.nupPatientNr.Location = new System.Drawing.Point(15, 45);
            this.nupPatientNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupPatientNr.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupPatientNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPatientNr.Name = "nupPatientNr";
            this.nupPatientNr.Size = new System.Drawing.Size(61, 20);
            this.nupPatientNr.TabIndex = 2;
            this.nupPatientNr.UseWaitCursor = true;
            this.nupPatientNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Eindeutige Patienten-Nr. *";
            // 
            // menContextAnwesenheiten
            // 
            this.menContextAnwesenheiten.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContextAnwesenheiten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenNeuAnwesenheiten,
            this.menBearbeitenAnwesenheiten,
            this.menLoeschenArbeitszeiten});
            this.menContextAnwesenheiten.Name = "menContext";
            this.menContextAnwesenheiten.Size = new System.Drawing.Size(266, 70);
            this.menContextAnwesenheiten.Opening += new System.ComponentModel.CancelEventHandler(this.menContextAnwesenheiten_Opening);
            // 
            // MenNeuAnwesenheiten
            // 
            this.MenNeuAnwesenheiten.Name = "MenNeuAnwesenheiten";
            this.MenNeuAnwesenheiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenNeuAnwesenheiten.Size = new System.Drawing.Size(265, 22);
            this.MenNeuAnwesenheiten.Text = "Neue Anwesenheit erstellen";
            this.MenNeuAnwesenheiten.Click += new System.EventHandler(this.MenNeuAnwesenheiten_Click);
            // 
            // menBearbeitenAnwesenheiten
            // 
            this.menBearbeitenAnwesenheiten.Name = "menBearbeitenAnwesenheiten";
            this.menBearbeitenAnwesenheiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeitenAnwesenheiten.Size = new System.Drawing.Size(265, 22);
            this.menBearbeitenAnwesenheiten.Text = "bearbeiten";
            this.menBearbeitenAnwesenheiten.Click += new System.EventHandler(this.menBearbeitenAnwesenheiten_Click);
            // 
            // menLoeschenArbeitszeiten
            // 
            this.menLoeschenArbeitszeiten.Name = "menLoeschenArbeitszeiten";
            this.menLoeschenArbeitszeiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschenArbeitszeiten.Size = new System.Drawing.Size(265, 22);
            this.menLoeschenArbeitszeiten.Text = "löschen";
            this.menLoeschenArbeitszeiten.Click += new System.EventHandler(this.MenLoeschen_Click);
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 464);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinimumSize = new System.Drawing.Size(403, 153);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientNr)).EndInit();
            this.menContextAnwesenheiten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lbxAnwesenheiten;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown nupPatientNr;
        private System.Windows.Forms.ContextMenuStrip menContextAnwesenheiten;
        private System.Windows.Forms.ToolStripMenuItem MenNeuAnwesenheiten;
        private System.Windows.Forms.ToolStripMenuItem menBearbeitenAnwesenheiten;
        private System.Windows.Forms.ToolStripMenuItem menLoeschenArbeitszeiten;
    }
}