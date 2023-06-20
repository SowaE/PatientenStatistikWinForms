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
            this.grpPatientendaten = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupPatientenNr = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxAnwesenheitstage = new System.Windows.Forms.ListBox();
            this.grpPatientendaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientenNr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNachname
            // 
            this.txtNachname.Size = new System.Drawing.Size(298, 20);
            // 
            // cbxAnschrift
            // 
            this.cbxAnschrift.Size = new System.Drawing.Size(298, 21);
            // 
            // grpPatientendaten
            // 
            this.grpPatientendaten.Controls.Add(this.lbxAnwesenheitstage);
            this.grpPatientendaten.Controls.Add(this.label7);
            this.grpPatientendaten.Controls.Add(this.nupPatientenNr);
            this.grpPatientendaten.Controls.Add(this.label5);
            this.grpPatientendaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPatientendaten.Location = new System.Drawing.Point(0, 163);
            this.grpPatientendaten.Name = "grpPatientendaten";
            this.grpPatientendaten.Size = new System.Drawing.Size(601, 289);
            this.grpPatientendaten.TabIndex = 2;
            this.grpPatientendaten.TabStop = false;
            this.grpPatientendaten.Text = "Patientendaten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Eiundeutige Patienten-Nr * ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Straße *";
            // 
            // nupPatientenNr
            // 
            this.nupPatientenNr.Location = new System.Drawing.Point(6, 32);
            this.nupPatientenNr.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nupPatientenNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPatientenNr.Name = "nupPatientenNr";
            this.nupPatientenNr.Size = new System.Drawing.Size(133, 20);
            this.nupPatientenNr.TabIndex = 3;
            this.nupPatientenNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Anwesenheitstage";
            // 
            // lbxAnwesenheitstage
            // 
            this.lbxAnwesenheitstage.DisplayMember = "DisplayMember";
            this.lbxAnwesenheitstage.FormattingEnabled = true;
            this.lbxAnwesenheitstage.Location = new System.Drawing.Point(200, 32);
            this.lbxAnwesenheitstage.Name = "lbxAnwesenheitstage";
            this.lbxAnwesenheitstage.Size = new System.Drawing.Size(389, 251);
            this.lbxAnwesenheitstage.TabIndex = 5;
            this.lbxAnwesenheitstage.ValueMember = "ValueMember";
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 455);
            this.Controls.Add(this.grpPatientendaten);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.Controls.SetChildIndex(this.grpPatientendaten, 0);
            this.grpPatientendaten.ResumeLayout(false);
            this.grpPatientendaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPatientenNr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatientendaten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown nupPatientenNr;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox lbxAnwesenheitstage;
    }
}