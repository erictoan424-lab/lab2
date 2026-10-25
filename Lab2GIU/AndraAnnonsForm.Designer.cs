namespace Lab2GIU
{
    partial class AndraAnnonsForm
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
            this.btnSparaÄndringar = new System.Windows.Forms.Button();
            this.btnAvbryt = new System.Windows.Forms.Button();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSparaÄndringar
            // 
            this.btnSparaÄndringar.Location = new System.Drawing.Point(332, 98);
            this.btnSparaÄndringar.Name = "btnSparaÄndringar";
            this.btnSparaÄndringar.Size = new System.Drawing.Size(172, 60);
            this.btnSparaÄndringar.TabIndex = 0;
            this.btnSparaÄndringar.Text = "Spara ändringar";
            this.btnSparaÄndringar.UseVisualStyleBackColor = true;
            this.btnSparaÄndringar.Click += new System.EventHandler(this.btnSparaÄndringar_Click);
            // 
            // btnAvbryt
            // 
            this.btnAvbryt.Location = new System.Drawing.Point(332, 214);
            this.btnAvbryt.Name = "btnAvbryt";
            this.btnAvbryt.Size = new System.Drawing.Size(172, 60);
            this.btnAvbryt.TabIndex = 1;
            this.btnAvbryt.Text = "Avbryt";
            this.btnAvbryt.UseVisualStyleBackColor = true;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(141, 98);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(131, 20);
            this.txtTitel.TabIndex = 2;
            this.txtTitel.Text = "Ändra titel här";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(141, 168);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(131, 20);
            this.txtPris.TabIndex = 3;
            this.txtPris.Text = "Ändra pris här";
            // 
            // AndraAnnonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.btnAvbryt);
            this.Controls.Add(this.btnSparaÄndringar);
            this.Name = "AndraAnnonsForm";
            this.Text = "AndraAnnonsForm";
            this.Load += new System.EventHandler(this.AndraAnnonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSparaÄndringar;
        private System.Windows.Forms.Button btnAvbryt;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtPris;
    }
}