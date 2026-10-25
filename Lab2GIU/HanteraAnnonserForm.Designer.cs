namespace Lab2GIU
{
    partial class HanteraAnnonserForm
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
            this.dgvAnnonser = new System.Windows.Forms.DataGridView();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnStäng = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnonser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnnonser
            // 
            this.dgvAnnonser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnnonser.Location = new System.Drawing.Point(142, 66);
            this.dgvAnnonser.Name = "dgvAnnonser";
            this.dgvAnnonser.Size = new System.Drawing.Size(364, 220);
            this.dgvAnnonser.TabIndex = 0;
            this.dgvAnnonser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAnnonser_CellContentClick);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(142, 311);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(146, 72);
            this.btnTaBort.TabIndex = 1;
            this.btnTaBort.Text = "Ta bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnStäng
            // 
            this.btnStäng.Location = new System.Drawing.Point(360, 311);
            this.btnStäng.Name = "btnStäng";
            this.btnStäng.Size = new System.Drawing.Size(146, 72);
            this.btnStäng.TabIndex = 2;
            this.btnStäng.Text = "Stäng";
            this.btnStäng.UseVisualStyleBackColor = true;
            this.btnStäng.Click += new System.EventHandler(this.button2_Click);
            // 
            // HanteraAnnonserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStäng);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.dgvAnnonser);
            this.Name = "HanteraAnnonserForm";
            this.Text = "HanteraAnnonserForm";
            this.Load += new System.EventHandler(this.HanteraAnnonserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnnonser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnnonser;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnStäng;
    }
}