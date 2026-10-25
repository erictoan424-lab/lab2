namespace Lab2GIU
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstAnnonser = new System.Windows.Forms.ListBox();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.btnSok = new System.Windows.Forms.Button();
            this.btnSkapaAnnons = new System.Windows.Forms.Button();
            this.btnReservera = new System.Windows.Forms.Button();
            this.btnBekräftaKöp = new System.Windows.Forms.Button();
            this.btnMinaAnnonser = new System.Windows.Forms.Button();
            this.btnAndraAnnons = new System.Windows.Forms.Button();
            this.btnTaBortAnnons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstAnnonser
            // 
            this.FirstAnnonser.FormattingEnabled = true;
            this.FirstAnnonser.ItemHeight = 24;
            this.FirstAnnonser.Location = new System.Drawing.Point(99, 248);
            this.FirstAnnonser.Name = "FirstAnnonser";
            this.FirstAnnonser.Size = new System.Drawing.Size(410, 148);
            this.FirstAnnonser.TabIndex = 1;
            this.FirstAnnonser.SelectedIndexChanged += new System.EventHandler(this.FirstAnnonser_SelectedIndexChanged);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(254, 80);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(130, 29);
            this.txtSok.TabIndex = 2;
            this.txtSok.TextChanged += new System.EventHandler(this.txtSok_TextChanged);
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(254, 127);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(130, 42);
            this.btnSok.TabIndex = 3;
            this.btnSok.Text = "Sökning";
            this.btnSok.UseVisualStyleBackColor = true;
            this.btnSok.Click += new System.EventHandler(this.btnSok_Click_1);
            // 
            // btnSkapaAnnons
            // 
            this.btnSkapaAnnons.Location = new System.Drawing.Point(99, 80);
            this.btnSkapaAnnons.Name = "btnSkapaAnnons";
            this.btnSkapaAnnons.Size = new System.Drawing.Size(140, 89);
            this.btnSkapaAnnons.TabIndex = 4;
            this.btnSkapaAnnons.Text = "Skapa annons";
            this.btnSkapaAnnons.UseVisualStyleBackColor = true;
            this.btnSkapaAnnons.Click += new System.EventHandler(this.btnSkapaAnnons_Click);
            // 
            // btnReservera
            // 
            this.btnReservera.Location = new System.Drawing.Point(99, 402);
            this.btnReservera.Name = "btnReservera";
            this.btnReservera.Size = new System.Drawing.Size(185, 58);
            this.btnReservera.TabIndex = 5;
            this.btnReservera.Text = "Reservera annons";
            this.btnReservera.UseVisualStyleBackColor = true;
            this.btnReservera.Click += new System.EventHandler(this.btnReservera_Click);
            // 
            // btnBekräftaKöp
            // 
            this.btnBekräftaKöp.Location = new System.Drawing.Point(310, 402);
            this.btnBekräftaKöp.Name = "btnBekräftaKöp";
            this.btnBekräftaKöp.Size = new System.Drawing.Size(199, 58);
            this.btnBekräftaKöp.TabIndex = 6;
            this.btnBekräftaKöp.Text = "Bekräfta köp";
            this.btnBekräftaKöp.UseVisualStyleBackColor = true;
            this.btnBekräftaKöp.Click += new System.EventHandler(this.btnBekräftaKöp_Click);
            // 
            // btnMinaAnnonser
            // 
            this.btnMinaAnnonser.Location = new System.Drawing.Point(99, 184);
            this.btnMinaAnnonser.Name = "btnMinaAnnonser";
            this.btnMinaAnnonser.Size = new System.Drawing.Size(199, 58);
            this.btnMinaAnnonser.TabIndex = 7;
            this.btnMinaAnnonser.Text = "Mina annonser";
            this.btnMinaAnnonser.UseVisualStyleBackColor = true;
            this.btnMinaAnnonser.Click += new System.EventHandler(this.btnMinaAnnonser_Click);
            // 
            // btnAndraAnnons
            // 
            this.btnAndraAnnons.Location = new System.Drawing.Point(310, 184);
            this.btnAndraAnnons.Name = "btnAndraAnnons";
            this.btnAndraAnnons.Size = new System.Drawing.Size(199, 58);
            this.btnAndraAnnons.TabIndex = 8;
            this.btnAndraAnnons.Text = "Ändra annons";
            this.btnAndraAnnons.UseVisualStyleBackColor = true;
            this.btnAndraAnnons.Click += new System.EventHandler(this.btnAndraAnnons_Click);
            // 
            // btnTaBortAnnons
            // 
            this.btnTaBortAnnons.Location = new System.Drawing.Point(390, 80);
            this.btnTaBortAnnons.Name = "btnTaBortAnnons";
            this.btnTaBortAnnons.Size = new System.Drawing.Size(119, 89);
            this.btnTaBortAnnons.TabIndex = 9;
            this.btnTaBortAnnons.Text = "Ta bort annons";
            this.btnTaBortAnnons.UseVisualStyleBackColor = true;
            this.btnTaBortAnnons.Click += new System.EventHandler(this.btnTaBortAnnons_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 495);
            this.Controls.Add(this.btnTaBortAnnons);
            this.Controls.Add(this.btnAndraAnnons);
            this.Controls.Add(this.btnMinaAnnonser);
            this.Controls.Add(this.btnBekräftaKöp);
            this.Controls.Add(this.btnReservera);
            this.Controls.Add(this.btnSkapaAnnons);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.FirstAnnonser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FirstAnnonser;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Button btnSok;
        private System.Windows.Forms.Button btnSkapaAnnons;
        private System.Windows.Forms.Button btnReservera;
        private System.Windows.Forms.Button btnBekräftaKöp;
        private System.Windows.Forms.Button btnMinaAnnonser;
        private System.Windows.Forms.Button btnAndraAnnons;
        private System.Windows.Forms.Button btnTaBortAnnons;
    }
}