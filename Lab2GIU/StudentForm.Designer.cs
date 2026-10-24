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
            this.FirstAnnonser.Location = new System.Drawing.Point(144, 248);
            this.FirstAnnonser.Name = "FirstAnnonser";
            this.FirstAnnonser.Size = new System.Drawing.Size(365, 148);
            this.FirstAnnonser.TabIndex = 1;
            this.FirstAnnonser.SelectedIndexChanged += new System.EventHandler(this.FirstAnnonser_SelectedIndexChanged);
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(363, 118);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(130, 29);
            this.txtSok.TabIndex = 2;
            // 
            // btnSok
            // 
            this.btnSok.Location = new System.Drawing.Point(363, 187);
            this.btnSok.Name = "btnSok";
            this.btnSok.Size = new System.Drawing.Size(130, 29);
            this.btnSok.TabIndex = 3;
            this.btnSok.Text = "Sökning";
            this.btnSok.UseVisualStyleBackColor = true;
            // 
            // btnSkapaAnnons
            // 
            this.btnSkapaAnnons.Location = new System.Drawing.Point(144, 118);
            this.btnSkapaAnnons.Name = "btnSkapaAnnons";
            this.btnSkapaAnnons.Size = new System.Drawing.Size(140, 107);
            this.btnSkapaAnnons.TabIndex = 4;
            this.btnSkapaAnnons.Text = "Skapa annons";
            this.btnSkapaAnnons.UseVisualStyleBackColor = true;
            this.btnSkapaAnnons.Click += new System.EventHandler(this.btnSkapaAnnons_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 495);
            this.Controls.Add(this.btnSkapaAnnons);
            this.Controls.Add(this.btnSok);
            this.Controls.Add(this.txtSok);
            this.Controls.Add(this.FirstAnnonser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
    }
}