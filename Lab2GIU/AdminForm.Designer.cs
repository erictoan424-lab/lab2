namespace Lab2GIU
{
    partial class AdminForm
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
            this.lblVälkommen = new System.Windows.Forms.Label();
            this.btnHanteraAnnonser = new System.Windows.Forms.Button();
            this.btnHanteraKurser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVälkommen
            // 
            this.lblVälkommen.AutoSize = true;
            this.lblVälkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVälkommen.Location = new System.Drawing.Point(186, 70);
            this.lblVälkommen.Name = "lblVälkommen";
            this.lblVälkommen.Size = new System.Drawing.Size(274, 39);
            this.lblVälkommen.TabIndex = 0;
            this.lblVälkommen.Text = "Välkommen Eric!";
            this.lblVälkommen.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnHanteraAnnonser
            // 
            this.btnHanteraAnnonser.Location = new System.Drawing.Point(173, 158);
            this.btnHanteraAnnonser.Name = "btnHanteraAnnonser";
            this.btnHanteraAnnonser.Size = new System.Drawing.Size(287, 66);
            this.btnHanteraAnnonser.TabIndex = 1;
            this.btnHanteraAnnonser.Text = "Hantera annonser";
            this.btnHanteraAnnonser.UseVisualStyleBackColor = true;
            this.btnHanteraAnnonser.Click += new System.EventHandler(this.btnHanteraAnnonser_Click);
            // 
            // btnHanteraKurser
            // 
            this.btnHanteraKurser.Location = new System.Drawing.Point(173, 261);
            this.btnHanteraKurser.Name = "btnHanteraKurser";
            this.btnHanteraKurser.Size = new System.Drawing.Size(287, 66);
            this.btnHanteraKurser.TabIndex = 2;
            this.btnHanteraKurser.Text = "Hantera kurser";
            this.btnHanteraKurser.UseVisualStyleBackColor = true;
            this.btnHanteraKurser.Click += new System.EventHandler(this.btnHanteraKurser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHanteraKurser);
            this.Controls.Add(this.btnHanteraAnnonser);
            this.Controls.Add(this.lblVälkommen);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVälkommen;
        private System.Windows.Forms.Button btnHanteraAnnonser;
        private System.Windows.Forms.Button btnHanteraKurser;
    }
}