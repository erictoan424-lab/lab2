namespace Lab2GIU
{
    partial class SkapaAnnonsForm
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
            this.labelTitel = new System.Windows.Forms.Label();
            this.labelPris = new System.Windows.Forms.Label();
            this.labelSkick = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.cmbSkick = new System.Windows.Forms.ComboBox();
            this.btnSkapaAnnons = new System.Windows.Forms.Button();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelFörfattare = new System.Windows.Forms.Label();
            this.labelUpplaga = new System.Windows.Forms.Label();
            this.labelKurskod = new System.Windows.Forms.Label();
            this.labelKursnamn = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtFörfattare = new System.Windows.Forms.TextBox();
            this.txtUpplaga = new System.Windows.Forms.TextBox();
            this.txtKurskod = new System.Windows.Forms.TextBox();
            this.txtKursnamn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(49, 44);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(27, 13);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Titel";
            this.labelTitel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Location = new System.Drawing.Point(52, 83);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(24, 13);
            this.labelPris.TabIndex = 1;
            this.labelPris.Text = "Pris";
            this.labelPris.Click += new System.EventHandler(this.labelPris_Click);
            // 
            // labelSkick
            // 
            this.labelSkick.AutoSize = true;
            this.labelSkick.Location = new System.Drawing.Point(278, 83);
            this.labelSkick.Name = "labelSkick";
            this.labelSkick.Size = new System.Drawing.Size(34, 13);
            this.labelSkick.TabIndex = 2;
            this.labelSkick.Text = "Skick";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(52, 60);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(100, 20);
            this.txtTitel.TabIndex = 3;
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(52, 99);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(100, 20);
            this.txtPris.TabIndex = 4;
            this.txtPris.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbSkick
            // 
            this.cmbSkick.FormattingEnabled = true;
            this.cmbSkick.Location = new System.Drawing.Point(281, 99);
            this.cmbSkick.Name = "cmbSkick";
            this.cmbSkick.Size = new System.Drawing.Size(100, 21);
            this.cmbSkick.TabIndex = 5;
            // 
            // btnSkapaAnnons
            // 
            this.btnSkapaAnnons.Location = new System.Drawing.Point(108, 281);
            this.btnSkapaAnnons.Name = "btnSkapaAnnons";
            this.btnSkapaAnnons.Size = new System.Drawing.Size(204, 80);
            this.btnSkapaAnnons.TabIndex = 6;
            this.btnSkapaAnnons.Text = "Skapa Annons";
            this.btnSkapaAnnons.UseVisualStyleBackColor = true;
            this.btnSkapaAnnons.Click += new System.EventHandler(this.btnSkapaAnnons_Click);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(280, 184);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 13);
            this.labelISBN.TabIndex = 7;
            this.labelISBN.Text = "ISBN";
            // 
            // labelFörfattare
            // 
            this.labelFörfattare.AutoSize = true;
            this.labelFörfattare.Location = new System.Drawing.Point(292, 44);
            this.labelFörfattare.Name = "labelFörfattare";
            this.labelFörfattare.Size = new System.Drawing.Size(52, 13);
            this.labelFörfattare.TabIndex = 8;
            this.labelFörfattare.Text = "Författare";
            // 
            // labelUpplaga
            // 
            this.labelUpplaga.AutoSize = true;
            this.labelUpplaga.Location = new System.Drawing.Point(278, 133);
            this.labelUpplaga.Name = "labelUpplaga";
            this.labelUpplaga.Size = new System.Drawing.Size(47, 13);
            this.labelUpplaga.TabIndex = 9;
            this.labelUpplaga.Text = "Upplaga";
            // 
            // labelKurskod
            // 
            this.labelKurskod.AutoSize = true;
            this.labelKurskod.Location = new System.Drawing.Point(52, 184);
            this.labelKurskod.Name = "labelKurskod";
            this.labelKurskod.Size = new System.Drawing.Size(46, 13);
            this.labelKurskod.TabIndex = 10;
            this.labelKurskod.Text = "Kurskod";
            // 
            // labelKursnamn
            // 
            this.labelKursnamn.AutoSize = true;
            this.labelKursnamn.Location = new System.Drawing.Point(49, 133);
            this.labelKursnamn.Name = "labelKursnamn";
            this.labelKursnamn.Size = new System.Drawing.Size(54, 13);
            this.labelKursnamn.TabIndex = 11;
            this.labelKursnamn.Text = "Kursnamn";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(281, 200);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 12;
            this.txtISBN.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFörfattare
            // 
            this.txtFörfattare.Location = new System.Drawing.Point(281, 60);
            this.txtFörfattare.Name = "txtFörfattare";
            this.txtFörfattare.Size = new System.Drawing.Size(100, 20);
            this.txtFörfattare.TabIndex = 13;
            // 
            // txtUpplaga
            // 
            this.txtUpplaga.Location = new System.Drawing.Point(281, 149);
            this.txtUpplaga.Name = "txtUpplaga";
            this.txtUpplaga.Size = new System.Drawing.Size(100, 20);
            this.txtUpplaga.TabIndex = 14;
            this.txtUpplaga.TextChanged += new System.EventHandler(this.txtUpplaga_TextChanged);
            // 
            // txtKurskod
            // 
            this.txtKurskod.Location = new System.Drawing.Point(52, 200);
            this.txtKurskod.Name = "txtKurskod";
            this.txtKurskod.Size = new System.Drawing.Size(100, 20);
            this.txtKurskod.TabIndex = 15;
            // 
            // txtKursnamn
            // 
            this.txtKursnamn.Location = new System.Drawing.Point(52, 149);
            this.txtKursnamn.Name = "txtKursnamn";
            this.txtKursnamn.Size = new System.Drawing.Size(100, 20);
            this.txtKursnamn.TabIndex = 16;
            // 
            // SkapaAnnonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKursnamn);
            this.Controls.Add(this.txtKurskod);
            this.Controls.Add(this.txtUpplaga);
            this.Controls.Add(this.txtFörfattare);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.labelKursnamn);
            this.Controls.Add(this.labelKurskod);
            this.Controls.Add(this.labelUpplaga);
            this.Controls.Add(this.labelFörfattare);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.btnSkapaAnnons);
            this.Controls.Add(this.cmbSkick);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.labelSkick);
            this.Controls.Add(this.labelPris);
            this.Controls.Add(this.labelTitel);
            this.Name = "SkapaAnnonsForm";
            this.Load += new System.EventHandler(this.SkapaAnnonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Label labelPris;
        private System.Windows.Forms.Label labelSkick;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.ComboBox cmbSkick;
        private System.Windows.Forms.Button btnSkapaAnnons;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelFörfattare;
        private System.Windows.Forms.Label labelUpplaga;
        private System.Windows.Forms.Label labelKurskod;
        private System.Windows.Forms.Label labelKursnamn;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtFörfattare;
        private System.Windows.Forms.TextBox txtUpplaga;
        private System.Windows.Forms.TextBox txtKurskod;
        private System.Windows.Forms.TextBox txtKursnamn;
    }
}