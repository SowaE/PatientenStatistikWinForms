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
            this.grpPraxis = new System.Windows.Forms.GroupBox();
            this.lbxPatient = new System.Windows.Forms.ListBox();
            this.menContextPraxis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menNeuePraxis = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeitenPraxis = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschenPraxis = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxAnschrift = new System.Windows.Forms.ComboBox();
            this.menContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menAnschriftNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschen = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPraxisname = new System.Windows.Forms.TextBox();
            this.grpPraxis.SuspendLayout();
            this.menContextPraxis.SuspendLayout();
            this.menContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPraxis
            // 
            this.grpPraxis.Controls.Add(this.lbxPatient);
            this.grpPraxis.Controls.Add(this.label7);
            this.grpPraxis.Controls.Add(this.label5);
            this.grpPraxis.Controls.Add(this.cbxAnschrift);
            this.grpPraxis.Controls.Add(this.label4);
            this.grpPraxis.Controls.Add(this.txtPraxisname);
            this.grpPraxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPraxis.Location = new System.Drawing.Point(0, 0);
            this.grpPraxis.Name = "grpPraxis";
            this.grpPraxis.Size = new System.Drawing.Size(1028, 292);
            this.grpPraxis.TabIndex = 3;
            this.grpPraxis.TabStop = false;
            this.grpPraxis.Text = "Firmendaten";
            // 
            // lbxPatient
            // 
            this.lbxPatient.ContextMenuStrip = this.menContextPraxis;
            this.lbxPatient.DisplayMember = "DisplayMember";
            this.lbxPatient.FormattingEnabled = true;
            this.lbxPatient.ItemHeight = 20;
            this.lbxPatient.Location = new System.Drawing.Point(562, 46);
            this.lbxPatient.Name = "lbxPatient";
            this.lbxPatient.Size = new System.Drawing.Size(426, 224);
            this.lbxPatient.TabIndex = 14;
            this.lbxPatient.ValueMember = "ValueMember";
            // 
            // menContextPraxis
            // 
            this.menContextPraxis.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContextPraxis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNeuePraxis,
            this.menBearbeitenPraxis,
            this.menLoeschenPraxis});
            this.menContextPraxis.Name = "menContext";
            this.menContextPraxis.Size = new System.Drawing.Size(315, 100);
            // 
            // menNeuePraxis
            // 
            this.menNeuePraxis.Name = "menNeuePraxis";
            this.menNeuePraxis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menNeuePraxis.Size = new System.Drawing.Size(314, 32);
            this.menNeuePraxis.Text = "Neue Praxis erstellen";
            this.menNeuePraxis.Click += new System.EventHandler(this.MenPraxisNeu_Click);
            // 
            // menBearbeitenPraxis
            // 
            this.menBearbeitenPraxis.Name = "menBearbeitenPraxis";
            this.menBearbeitenPraxis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeitenPraxis.Size = new System.Drawing.Size(314, 32);
            this.menBearbeitenPraxis.Text = "bearbeiten";
            this.menBearbeitenPraxis.Click += new System.EventHandler(this.MenBearbeitenPraxis_Click);
            // 
            // menLoeschenPraxis
            // 
            this.menLoeschenPraxis.Name = "menLoeschenPraxis";
            this.menLoeschenPraxis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschenPraxis.Size = new System.Drawing.Size(314, 32);
            this.menLoeschenPraxis.Text = "löschen";
            this.menLoeschenPraxis.Click += new System.EventHandler(this.MenLoeschenPraxis_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(558, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Patient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Praxisname *";
            // 
            // cbxAnschrift
            // 
            this.cbxAnschrift.AllowDrop = true;
            this.cbxAnschrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAnschrift.ContextMenuStrip = this.menContext;
            this.cbxAnschrift.DisplayMember = "DisplayMember";
            this.cbxAnschrift.DropDownHeight = 100;
            this.cbxAnschrift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnschrift.FormattingEnabled = true;
            this.cbxAnschrift.IntegralHeight = false;
            this.cbxAnschrift.Location = new System.Drawing.Point(22, 128);
            this.cbxAnschrift.Name = "cbxAnschrift";
            this.cbxAnschrift.Size = new System.Drawing.Size(202, 28);
            this.cbxAnschrift.TabIndex = 7;
            this.cbxAnschrift.ValueMember = "ValueMember";
            // 
            // menContext
            // 
            this.menContext.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAnschriftNeu,
            this.menBearbeiten,
            this.menLoeschen});
            this.menContext.Name = "menContext";
            this.menContext.Size = new System.Drawing.Size(340, 100);
            // 
            // menAnschriftNeu
            // 
            this.menAnschriftNeu.Name = "menAnschriftNeu";
            this.menAnschriftNeu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menAnschriftNeu.Size = new System.Drawing.Size(339, 32);
            this.menAnschriftNeu.Text = "Neue Anschrift erstellen";
            this.menAnschriftNeu.Click += new System.EventHandler(this.MenAnschriftNeu_Click);
            // 
            // menBearbeiten
            // 
            this.menBearbeiten.Name = "menBearbeiten";
            this.menBearbeiten.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menBearbeiten.Size = new System.Drawing.Size(339, 32);
            this.menBearbeiten.Text = "bearbeiten";
            this.menBearbeiten.Click += new System.EventHandler(this.menBearbeiten_Click);
            // 
            // menLoeschen
            // 
            this.menLoeschen.Name = "menLoeschen";
            this.menLoeschen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menLoeschen.Size = new System.Drawing.Size(339, 32);
            this.menLoeschen.Text = "löschen";
            this.menLoeschen.Click += new System.EventHandler(this.MenLoeschen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anschrift ...";
            // 
            // txtPraxisname
            // 
            this.txtPraxisname.Location = new System.Drawing.Point(22, 58);
            this.txtPraxisname.MaxLength = 40;
            this.txtPraxisname.Multiline = true;
            this.txtPraxisname.Name = "txtPraxisname";
            this.txtPraxisname.Size = new System.Drawing.Size(374, 20);
            this.txtPraxisname.TabIndex = 1;
            this.txtPraxisname.Tag = "*";
            // 
            // FrmPraxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 306);
            this.Controls.Add(this.grpPraxis);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPraxis";
            this.Text = "FrmPraxis";
            this.grpPraxis.ResumeLayout(false);
            this.grpPraxis.PerformLayout();
            this.menContextPraxis.ResumeLayout(false);
            this.menContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPraxis;
        public System.Windows.Forms.ListBox lbxPatient;
        private System.Windows.Forms.ContextMenuStrip menContextPraxis;
        private System.Windows.Forms.ToolStripMenuItem menNeuePraxis;
        private System.Windows.Forms.ToolStripMenuItem menBearbeitenPraxis;
        private System.Windows.Forms.ToolStripMenuItem menLoeschenPraxis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxAnschrift;
        private System.Windows.Forms.ContextMenuStrip menContext;
        private System.Windows.Forms.ToolStripMenuItem menAnschriftNeu;
        private System.Windows.Forms.ToolStripMenuItem menBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem menLoeschen;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPraxisname;
    }
}