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
            this.cmbKurser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Location = new System.Drawing.Point(65, 54);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(33, 16);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Titel";
            this.labelTitel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPris
            // 
            this.labelPris.AutoSize = true;
            this.labelPris.Location = new System.Drawing.Point(69, 102);
            this.labelPris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPris.Name = "labelPris";
            this.labelPris.Size = new System.Drawing.Size(30, 16);
            this.labelPris.TabIndex = 1;
            this.labelPris.Text = "Pris";
            this.labelPris.Click += new System.EventHandler(this.labelPris_Click);
            // 
            // labelSkick
            // 
            this.labelSkick.AutoSize = true;
            this.labelSkick.Location = new System.Drawing.Point(254, 102);
            this.labelSkick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSkick.Name = "labelSkick";
            this.labelSkick.Size = new System.Drawing.Size(40, 16);
            this.labelSkick.TabIndex = 2;
            this.labelSkick.Text = "Skick";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(69, 74);
            this.txtTitel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(132, 22);
            this.txtTitel.TabIndex = 3;
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(69, 122);
            this.txtPris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(132, 22);
            this.txtPris.TabIndex = 4;
            this.txtPris.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbSkick
            // 
            this.cmbSkick.FormattingEnabled = true;
            this.cmbSkick.Location = new System.Drawing.Point(248, 120);
            this.cmbSkick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSkick.Name = "cmbSkick";
            this.cmbSkick.Size = new System.Drawing.Size(132, 24);
            this.cmbSkick.TabIndex = 5;
            // 
            // btnSkapaAnnons
            // 
            this.btnSkapaAnnons.Location = new System.Drawing.Point(68, 359);
            this.btnSkapaAnnons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSkapaAnnons.Name = "btnSkapaAnnons";
            this.btnSkapaAnnons.Size = new System.Drawing.Size(272, 98);
            this.btnSkapaAnnons.TabIndex = 6;
            this.btnSkapaAnnons.Text = "Skapa Annons";
            this.btnSkapaAnnons.UseVisualStyleBackColor = true;
            this.btnSkapaAnnons.Click += new System.EventHandler(this.btnSkapaAnnons_Click);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(249, 226);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(38, 16);
            this.labelISBN.TabIndex = 7;
            this.labelISBN.Text = "ISBN";
            // 
            // labelFörfattare
            // 
            this.labelFörfattare.AutoSize = true;
            this.labelFörfattare.Location = new System.Drawing.Point(245, 54);
            this.labelFörfattare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFörfattare.Name = "labelFörfattare";
            this.labelFörfattare.Size = new System.Drawing.Size(64, 16);
            this.labelFörfattare.TabIndex = 8;
            this.labelFörfattare.Text = "Författare";
            // 
            // labelUpplaga
            // 
            this.labelUpplaga.AutoSize = true;
            this.labelUpplaga.Location = new System.Drawing.Point(249, 164);
            this.labelUpplaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpplaga.Name = "labelUpplaga";
            this.labelUpplaga.Size = new System.Drawing.Size(60, 16);
            this.labelUpplaga.TabIndex = 9;
            this.labelUpplaga.Text = "Upplaga";
            // 
            // labelKurskod
            // 
            this.labelKurskod.AutoSize = true;
            this.labelKurskod.Location = new System.Drawing.Point(69, 226);
            this.labelKurskod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKurskod.Name = "labelKurskod";
            this.labelKurskod.Size = new System.Drawing.Size(56, 16);
            this.labelKurskod.TabIndex = 10;
            this.labelKurskod.Text = "Kurskod";
            // 
            // labelKursnamn
            // 
            this.labelKursnamn.AutoSize = true;
            this.labelKursnamn.Location = new System.Drawing.Point(65, 164);
            this.labelKursnamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKursnamn.Name = "labelKursnamn";
            this.labelKursnamn.Size = new System.Drawing.Size(66, 16);
            this.labelKursnamn.TabIndex = 11;
            this.labelKursnamn.Text = "Kursnamn";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(248, 246);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(132, 22);
            this.txtISBN.TabIndex = 12;
            this.txtISBN.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFörfattare
            // 
            this.txtFörfattare.Location = new System.Drawing.Point(248, 74);
            this.txtFörfattare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFörfattare.Name = "txtFörfattare";
            this.txtFörfattare.Size = new System.Drawing.Size(132, 22);
            this.txtFörfattare.TabIndex = 13;
            // 
            // txtUpplaga
            // 
            this.txtUpplaga.Location = new System.Drawing.Point(248, 183);
            this.txtUpplaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpplaga.Name = "txtUpplaga";
            this.txtUpplaga.Size = new System.Drawing.Size(132, 22);
            this.txtUpplaga.TabIndex = 14;
            this.txtUpplaga.TextChanged += new System.EventHandler(this.txtUpplaga_TextChanged);
            // 
            // txtKurskod
            // 
            this.txtKurskod.Location = new System.Drawing.Point(69, 246);
            this.txtKurskod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKurskod.Name = "txtKurskod";
            this.txtKurskod.Size = new System.Drawing.Size(132, 22);
            this.txtKurskod.TabIndex = 15;
            // 
            // txtKursnamn
            // 
            this.txtKursnamn.Location = new System.Drawing.Point(69, 183);
            this.txtKursnamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKursnamn.Name = "txtKursnamn";
            this.txtKursnamn.Size = new System.Drawing.Size(132, 22);
            this.txtKursnamn.TabIndex = 16;
            // 
            // cmbKurser
            // 
            this.cmbKurser.FormattingEnabled = true;
            this.cmbKurser.Location = new System.Drawing.Point(68, 301);
            this.cmbKurser.Name = "cmbKurser";
            this.cmbKurser.Size = new System.Drawing.Size(183, 24);
            this.cmbKurser.TabIndex = 17;
            // 
            // SkapaAnnonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbKurser);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cmbKurser;
    }
}