
namespace PatientenStatistikWinForms
{
    partial class FrmPerson
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
            this.grpPerson = new System.Windows.Forms.GroupBox();
            this.dtpGeburtsdatum = new UIComponent.NullableDateTimePicker();
            this.menContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menAnschriftNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menLoeschen = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxAnschrift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPerson.SuspendLayout();
            this.menContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerson
            // 
            this.grpPerson.Controls.Add(this.dtpGeburtsdatum);
            this.grpPerson.Controls.Add(this.cbxAnschrift);
            this.grpPerson.Controls.Add(this.label4);
            this.grpPerson.Controls.Add(this.label3);
            this.grpPerson.Controls.Add(this.txtNachname);
            this.grpPerson.Controls.Add(this.label2);
            this.grpPerson.Controls.Add(this.txtVorname);
            this.grpPerson.Controls.Add(this.label1);
            this.grpPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPerson.Location = new System.Drawing.Point(0, 0);
            this.grpPerson.Name = "grpPerson";
            this.grpPerson.Size = new System.Drawing.Size(866, 251);
            this.grpPerson.TabIndex = 1;
            this.grpPerson.TabStop = false;
            this.grpPerson.Text = "Personendaten";
            // 
            // dtpGeburtsdatum
            // 
            this.dtpGeburtsdatum.Location = new System.Drawing.Point(23, 201);
            this.dtpGeburtsdatum.Name = "dtpGeburtsdatum";
            this.dtpGeburtsdatum.Size = new System.Drawing.Size(375, 26);
            this.dtpGeburtsdatum.TabIndex = 5;
            this.dtpGeburtsdatum.Tag = "*";
            this.dtpGeburtsdatum.Value = new System.DateTime(2023, 5, 4, 10, 28, 21, 570);
            this.dtpGeburtsdatum.ValueChanged += new System.EventHandler(this.DataHasBeenChanged);
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
            this.menContext.Opening += new System.ComponentModel.CancelEventHandler(this.menContext_Opening);
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
            // cbxAnschrift
            // 
            this.cbxAnschrift.AllowDrop = true;
            this.cbxAnschrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAnschrift.ContextMenuStrip = this.menContext;
            this.cbxAnschrift.DisplayMember = "DisplayMember";
            this.cbxAnschrift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnschrift.FormattingEnabled = true;
            this.cbxAnschrift.Location = new System.Drawing.Point(420, 199);
            this.cbxAnschrift.Name = "cbxAnschrift";
            this.cbxAnschrift.Size = new System.Drawing.Size(410, 28);
            this.cbxAnschrift.TabIndex = 7;
            this.cbxAnschrift.ValueMember = "ValueMember";
            this.cbxAnschrift.SelectedIndexChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anschrift ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geburtsdatum *";
            // 
            // txtNachname
            // 
            this.txtNachname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNachname.Location = new System.Drawing.Point(420, 129);
            this.txtNachname.MaxLength = 40;
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(410, 26);
            this.txtNachname.TabIndex = 3;
            this.txtNachname.Tag = "*";
            this.txtNachname.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nachname *";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(23, 129);
            this.txtVorname.MaxLength = 40;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(375, 26);
            this.txtVorname.TabIndex = 1;
            this.txtVorname.Tag = "*";
            this.txtVorname.TextChanged += new System.EventHandler(this.DataHasBeenChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname *";
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 251);
            this.Controls.Add(this.grpPerson);
            this.MinimumSize = new System.Drawing.Size(888, 307);
            this.Name = "FrmPerson";
            this.Text = "Person bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPerson_FormClosing);
            this.grpPerson.ResumeLayout(false);
            this.grpPerson.PerformLayout();
            this.menContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip menContext;
        private System.Windows.Forms.ToolStripMenuItem menAnschriftNeu;
        private System.Windows.Forms.ToolStripMenuItem menBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem menLoeschen;
        public System.Windows.Forms.ComboBox cbxAnschrift;
        public UIComponent.NullableDateTimePicker dtpGeburtsdatum;
    }
}