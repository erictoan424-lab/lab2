namespace Lab2GIU
{
    partial class HanteraKurserForm
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
            this.btnLäggTillKurs = new System.Windows.Forms.Button();
            this.btnStäng = new System.Windows.Forms.Button();
            this.lstKurser = new System.Windows.Forms.ListBox();
            this.txtKursnamn = new System.Windows.Forms.TextBox();
            this.lblHanteraKurser = new System.Windows.Forms.Label();
            this.lblKurskod = new System.Windows.Forms.Label();
            this.lblKursnamn = new System.Windows.Forms.Label();
            this.txtKurskod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLäggTillKurs
            // 
            this.btnLäggTillKurs.Location = new System.Drawing.Point(408, 138);
            this.btnLäggTillKurs.Name = "btnLäggTillKurs";
            this.btnLäggTillKurs.Size = new System.Drawing.Size(131, 70);
            this.btnLäggTillKurs.TabIndex = 0;
            this.btnLäggTillKurs.Text = "Lägg till kurs";
            this.btnLäggTillKurs.UseVisualStyleBackColor = true;
            this.btnLäggTillKurs.Click += new System.EventHandler(this.btnLäggTillKurs_Click);
            // 
            // btnStäng
            // 
            this.btnStäng.Location = new System.Drawing.Point(408, 359);
            this.btnStäng.Name = "btnStäng";
            this.btnStäng.Size = new System.Drawing.Size(131, 44);
            this.btnStäng.TabIndex = 1;
            this.btnStäng.Text = "Stäng";
            this.btnStäng.UseVisualStyleBackColor = true;
            this.btnStäng.Click += new System.EventHandler(this.btnStäng_Click);
            // 
            // lstKurser
            // 
            this.lstKurser.FormattingEnabled = true;
            this.lstKurser.Location = new System.Drawing.Point(82, 214);
            this.lstKurser.Name = "lstKurser";
            this.lstKurser.Size = new System.Drawing.Size(457, 121);
            this.lstKurser.TabIndex = 2;
            // 
            // txtKursnamn
            // 
            this.txtKursnamn.Location = new System.Drawing.Point(82, 172);
            this.txtKursnamn.Multiline = true;
            this.txtKursnamn.Name = "txtKursnamn";
            this.txtKursnamn.Size = new System.Drawing.Size(320, 36);
            this.txtKursnamn.TabIndex = 3;
            // 
            // lblHanteraKurser
            // 
            this.lblHanteraKurser.AutoSize = true;
            this.lblHanteraKurser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHanteraKurser.Location = new System.Drawing.Point(116, 9);
            this.lblHanteraKurser.Name = "lblHanteraKurser";
            this.lblHanteraKurser.Size = new System.Drawing.Size(198, 31);
            this.lblHanteraKurser.TabIndex = 4;
            this.lblHanteraKurser.Text = "Hantera Kurser";
            // 
            // lblKurskod
            // 
            this.lblKurskod.AutoSize = true;
            this.lblKurskod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKurskod.Location = new System.Drawing.Point(85, 81);
            this.lblKurskod.Name = "lblKurskod";
            this.lblKurskod.Size = new System.Drawing.Size(97, 25);
            this.lblKurskod.TabIndex = 5;
            this.lblKurskod.Text = "Kurskod:";
            // 
            // lblKursnamn
            // 
            this.lblKursnamn.AutoSize = true;
            this.lblKursnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKursnamn.Location = new System.Drawing.Point(85, 144);
            this.lblKursnamn.Name = "lblKursnamn";
            this.lblKursnamn.Size = new System.Drawing.Size(115, 25);
            this.lblKursnamn.TabIndex = 6;
            this.lblKursnamn.Text = "Kursnamn:";
            // 
            // txtKurskod
            // 
            this.txtKurskod.Location = new System.Drawing.Point(82, 109);
            this.txtKurskod.Multiline = true;
            this.txtKurskod.Name = "txtKurskod";
            this.txtKurskod.Size = new System.Drawing.Size(182, 31);
            this.txtKurskod.TabIndex = 7;
            this.txtKurskod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HanteraKurserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKurskod);
            this.Controls.Add(this.lblKursnamn);
            this.Controls.Add(this.lblKurskod);
            this.Controls.Add(this.lblHanteraKurser);
            this.Controls.Add(this.txtKursnamn);
            this.Controls.Add(this.lstKurser);
            this.Controls.Add(this.btnStäng);
            this.Controls.Add(this.btnLäggTillKurs);
            this.Name = "HanteraKurserForm";
            this.Text = "HanteraKurserForm";
            this.Load += new System.EventHandler(this.HanteraKurserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLäggTillKurs;
        private System.Windows.Forms.Button btnStäng;
        private System.Windows.Forms.ListBox lstKurser;
        private System.Windows.Forms.TextBox txtKursnamn;
        private System.Windows.Forms.Label lblHanteraKurser;
        private System.Windows.Forms.Label lblKurskod;
        private System.Windows.Forms.Label lblKursnamn;
        private System.Windows.Forms.TextBox txtKurskod;
    }
}