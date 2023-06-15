namespace PatientenStatistikWinForms
{
    partial class FrmAnweseneheit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGrund = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAnwesenheitstag = new UIComponent.NullableDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpAnwesenheitstag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGrund);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anwesenheitdaten";
            // 
            // txtGrund
            // 
            this.txtGrund.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrund.Location = new System.Drawing.Point(6, 84);
            this.txtGrund.MaxLength = 50;
            this.txtGrund.Name = "txtGrund";
            this.txtGrund.Size = new System.Drawing.Size(514, 20);
            this.txtGrund.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anwesnheitstag:";
            // 
            // dtpAnwesenheitstag
            // 
            this.dtpAnwesenheitstag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAnwesenheitstag.Location = new System.Drawing.Point(9, 36);
            this.dtpAnwesenheitstag.Name = "dtpAnwesenheitstag";
            this.dtpAnwesenheitstag.Size = new System.Drawing.Size(200, 20);
            this.dtpAnwesenheitstag.TabIndex = 3;
            this.dtpAnwesenheitstag.Value = new System.DateTime(2023, 6, 15, 15, 20, 30, 180);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grund:";
            // 
            // FrmAnweseneheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 115);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnweseneheit";
            this.Text = "FrmAnweseneheit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private UIComponent.NullableDateTimePicker dtpAnwesenheitstag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrund;
        private System.Windows.Forms.Label label2;
    }
}