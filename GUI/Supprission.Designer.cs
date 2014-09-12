namespace GUI
{
    partial class Supprission
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
            this.btn_sup = new System.Windows.Forms.Button();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.lbl_supp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(198, 315);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(75, 23);
            this.btn_sup.TabIndex = 0;
            this.btn_sup.Text = "Supprimer";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(198, 157);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(140, 20);
            this.txt_matricule.TabIndex = 1;
            this.txt_matricule.TextChanged += new System.EventHandler(this.txt_matricule_TextChanged);
            // 
            // lbl_supp
            // 
            this.lbl_supp.AutoSize = true;
            this.lbl_supp.Location = new System.Drawing.Point(95, 160);
            this.lbl_supp.Name = "lbl_supp";
            this.lbl_supp.Size = new System.Drawing.Size(80, 13);
            this.lbl_supp.TabIndex = 2;
            this.lbl_supp.Text = "Entrer matricule";
            this.lbl_supp.Click += new System.EventHandler(this.lbl_supp_Click);
            // 
            // Supprission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 385);
            this.Controls.Add(this.lbl_supp);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.btn_sup);
            this.Name = "Supprission";
            this.Text = "Supprission";
            this.Load += new System.EventHandler(this.Supprission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label lbl_supp;
    }
}