
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
            this.menContextArbeitszeiten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menNeuAnwesenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeitenAnwesenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschenAnwesenheit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientNr)).BeginInit();
            this.menContextArbeitszeiten.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNachname
            // 
            this.txtNachname.Size = new System.Drawing.Size(394, 26);
            // 
            // cbxAnschrift
            // 
            this.cbxAnschrift.Size = new System.Drawing.Size(394, 28);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxAnwesenheiten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nupPatientNr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patientendaten";
            // 
            // lbxAnwesenheiten
            // 
            this.lbxAnwesenheiten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAnwesenheiten.ContextMenuStrip = this.menContextArbeitszeiten;
            this.lbxAnwesenheiten.DisplayMember = "DisplayMember";
            this.lbxAnwesenheiten.FormattingEnabled = true;
            this.lbxAnwesenheiten.ItemHeight = 20;
            this.lbxAnwesenheiten.Location = new System.Drawing.Point(269, 69);
            this.lbxAnwesenheiten.Name = "lbxAnwesenheiten";
            this.lbxAnwesenheiten.Size = new System.Drawing.Size(570, 364);
            this.lbxAnwesenheiten.TabIndex = 4;
            this.lbxAnwesenheiten.ValueMember = "ValueMember";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Anwesenheitstaage";
            // 
            // nupPatientNr
            // 
            this.nupPatientNr.Location = new System.Drawing.Point(23, 69);
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
            this.nupPatientNr.Size = new System.Drawing.Size(91, 26);
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
            this.label5.Location = new System.Drawing.Point(20, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Eindeutige Patienten-Nr. *";
            // 
            // menContextArbeitszeiten
            // 
            this.menContextArbeitszeiten.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContextArbeitszeiten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNeuAnwesenheit,
            this.menBearbeitenAnwesenheit,
            this.menLoeschenAnwesenheit});
            this.menContextArbeitszeiten.Name = "menContext";
            this.menContextArbeitszeiten.Size = new System.Drawing.Size(370, 100);
            this.menContextArbeitszeiten.Opening += new System.ComponentModel.CancelEventHandler(this.menContextAnwesenheiten_Opening);
            // 
            // menNeuAnwesenheit
            // 
            this.menNeuAnwesenheit.Name = "menNeuAnwesenheit";
            this.menNeuAnwesenheit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menNeuAnwesenheit.Size = new System.Drawing.Size(369, 32);
            this.menNeuAnwesenheit.Text = "Neue Anwesenheit erstellen";
            this.menNeuAnwesenheit.Click += new System.EventHandler(this.MenNeuAnwesenheit_Click);
            // 
            // menBearbeitenAnwesenheit
            // 
            this.menBearbeitenAnwesenheit.Name = "menBearbeitenAnwesenheit";
            this.menBearbeitenAnwesenheit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeitenAnwesenheit.Size = new System.Drawing.Size(369, 32);
            this.menBearbeitenAnwesenheit.Text = "bearbeiten";
            this.menBearbeitenAnwesenheit.Click += new System.EventHandler(this.menBearbeitenAnwesenheit_Click);
            // 
            // menLoeschenAnwesenheit
            // 
            this.menLoeschenAnwesenheit.Name = "menLoeschenAnwesenheit";
            this.menLoeschenAnwesenheit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschenAnwesenheit.Size = new System.Drawing.Size(369, 32);
            this.menLoeschenAnwesenheit.Text = "löschen";
            this.menLoeschenAnwesenheit.Click += new System.EventHandler(this.MenLoeschen_Click);
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 696);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientNr)).EndInit();
            this.menContextArbeitszeiten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lbxAnwesenheiten;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown nupPatientNr;
        private System.Windows.Forms.ContextMenuStrip menContextArbeitszeiten;
        private System.Windows.Forms.ToolStripMenuItem menNeuAnwesenheit;
        private System.Windows.Forms.ToolStripMenuItem menBearbeitenAnwesenheit;
        private System.Windows.Forms.ToolStripMenuItem menLoeschenAnwesenheit;
    }
}