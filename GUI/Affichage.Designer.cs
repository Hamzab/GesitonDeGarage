namespace GUI
{
    partial class Affichage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Affichage));
            this.choisir_categorie = new System.Windows.Forms.GroupBox();
            this.list_auto = new System.Windows.Forms.ListBox();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.combo_categorie = new System.Windows.Forms.ComboBox();
            this.afficher_details = new System.Windows.Forms.GroupBox();
            this.txt_vitesse = new System.Windows.Forms.TextBox();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.txt_typeV = new System.Windows.Forms.TextBox();
            this.lbl_typeV = new System.Windows.Forms.Label();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.lbl_marque = new System.Windows.Forms.Label();
            this.txt_cylindre = new System.Windows.Forms.TextBox();
            this.lbl_cylindre = new System.Windows.Forms.Label();
            this.txt_coulour = new System.Windows.Forms.TextBox();
            this.lbl_coulour = new System.Windows.Forms.Label();
            this.txt_immatriculation = new System.Windows.Forms.TextBox();
            this.lbl_imatriculation = new System.Windows.Forms.Label();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.lbl_annee = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.choisir_categorie.SuspendLayout();
            this.afficher_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // choisir_categorie
            // 
            this.choisir_categorie.Controls.Add(this.list_auto);
            this.choisir_categorie.Controls.Add(this.lbl_categorie);
            this.choisir_categorie.Controls.Add(this.combo_categorie);
            this.choisir_categorie.Location = new System.Drawing.Point(42, 55);
            this.choisir_categorie.Name = "choisir_categorie";
            this.choisir_categorie.Size = new System.Drawing.Size(266, 351);
            this.choisir_categorie.TabIndex = 0;
            this.choisir_categorie.TabStop = false;
            this.choisir_categorie.Text = "Choisir categorie";
            // 
            // list_auto
            // 
            this.list_auto.FormattingEnabled = true;
            this.list_auto.Location = new System.Drawing.Point(35, 127);
            this.list_auto.Name = "list_auto";
            this.list_auto.Size = new System.Drawing.Size(204, 173);
            this.list_auto.TabIndex = 2;
            this.list_auto.SelectedIndexChanged += new System.EventHandler(this.list_auto_SelectedIndexChanged);
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Location = new System.Drawing.Point(4, 52);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(52, 13);
            this.lbl_categorie.TabIndex = 1;
            this.lbl_categorie.Text = "Categorie";
            // 
            // combo_categorie
            // 
            this.combo_categorie.FormattingEnabled = true;
            this.combo_categorie.Location = new System.Drawing.Point(105, 49);
            this.combo_categorie.Name = "combo_categorie";
            this.combo_categorie.Size = new System.Drawing.Size(121, 21);
            this.combo_categorie.TabIndex = 0;
            this.combo_categorie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // afficher_details
            // 
            this.afficher_details.Controls.Add(this.txt_vitesse);
            this.afficher_details.Controls.Add(this.lbl_vitesse);
            this.afficher_details.Controls.Add(this.txt_typeV);
            this.afficher_details.Controls.Add(this.lbl_typeV);
            this.afficher_details.Controls.Add(this.txt_marque);
            this.afficher_details.Controls.Add(this.lbl_marque);
            this.afficher_details.Controls.Add(this.txt_cylindre);
            this.afficher_details.Controls.Add(this.lbl_cylindre);
            this.afficher_details.Controls.Add(this.txt_coulour);
            this.afficher_details.Controls.Add(this.lbl_coulour);
            this.afficher_details.Controls.Add(this.txt_immatriculation);
            this.afficher_details.Controls.Add(this.lbl_imatriculation);
            this.afficher_details.Controls.Add(this.txt_annee);
            this.afficher_details.Controls.Add(this.lbl_annee);
            this.afficher_details.Location = new System.Drawing.Point(339, 55);
            this.afficher_details.Name = "afficher_details";
            this.afficher_details.Size = new System.Drawing.Size(274, 351);
            this.afficher_details.TabIndex = 1;
            this.afficher_details.TabStop = false;
            this.afficher_details.Text = "Afficher les details";
            // 
            // txt_vitesse
            // 
            this.txt_vitesse.Enabled = false;
            this.txt_vitesse.Location = new System.Drawing.Point(121, 301);
            this.txt_vitesse.Name = "txt_vitesse";
            this.txt_vitesse.Size = new System.Drawing.Size(121, 20);
            this.txt_vitesse.TabIndex = 17;
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Location = new System.Drawing.Point(34, 304);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(41, 13);
            this.lbl_vitesse.TabIndex = 16;
            this.lbl_vitesse.Text = "Vitesse";
            // 
            // txt_typeV
            // 
            this.txt_typeV.Enabled = false;
            this.txt_typeV.Location = new System.Drawing.Point(121, 260);
            this.txt_typeV.Name = "txt_typeV";
            this.txt_typeV.Size = new System.Drawing.Size(121, 20);
            this.txt_typeV.TabIndex = 15;
            // 
            // lbl_typeV
            // 
            this.lbl_typeV.AutoSize = true;
            this.lbl_typeV.Location = new System.Drawing.Point(35, 263);
            this.lbl_typeV.Name = "lbl_typeV";
            this.lbl_typeV.Size = new System.Drawing.Size(41, 13);
            this.lbl_typeV.TabIndex = 14;
            this.lbl_typeV.Text = "Type V";
            // 
            // txt_marque
            // 
            this.txt_marque.Enabled = false;
            this.txt_marque.Location = new System.Drawing.Point(121, 228);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(121, 20);
            this.txt_marque.TabIndex = 13;
            // 
            // lbl_marque
            // 
            this.lbl_marque.AutoSize = true;
            this.lbl_marque.Location = new System.Drawing.Point(31, 228);
            this.lbl_marque.Name = "lbl_marque";
            this.lbl_marque.Size = new System.Drawing.Size(43, 13);
            this.lbl_marque.TabIndex = 12;
            this.lbl_marque.Text = "Marque";
            // 
            // txt_cylindre
            // 
            this.txt_cylindre.Enabled = false;
            this.txt_cylindre.Location = new System.Drawing.Point(121, 187);
            this.txt_cylindre.Name = "txt_cylindre";
            this.txt_cylindre.Size = new System.Drawing.Size(118, 20);
            this.txt_cylindre.TabIndex = 11;
            // 
            // lbl_cylindre
            // 
            this.lbl_cylindre.AutoSize = true;
            this.lbl_cylindre.Location = new System.Drawing.Point(35, 187);
            this.lbl_cylindre.Name = "lbl_cylindre";
            this.lbl_cylindre.Size = new System.Drawing.Size(44, 13);
            this.lbl_cylindre.TabIndex = 10;
            this.lbl_cylindre.Text = "Cylindre";
            // 
            // txt_coulour
            // 
            this.txt_coulour.Enabled = false;
            this.txt_coulour.Location = new System.Drawing.Point(121, 143);
            this.txt_coulour.Name = "txt_coulour";
            this.txt_coulour.Size = new System.Drawing.Size(118, 20);
            this.txt_coulour.TabIndex = 9;
            // 
            // lbl_coulour
            // 
            this.lbl_coulour.AutoSize = true;
            this.lbl_coulour.Location = new System.Drawing.Point(35, 143);
            this.lbl_coulour.Name = "lbl_coulour";
            this.lbl_coulour.Size = new System.Drawing.Size(43, 13);
            this.lbl_coulour.TabIndex = 8;
            this.lbl_coulour.Text = "Coulour";
            // 
            // txt_immatriculation
            // 
            this.txt_immatriculation.Enabled = false;
            this.txt_immatriculation.Location = new System.Drawing.Point(121, 93);
            this.txt_immatriculation.Name = "txt_immatriculation";
            this.txt_immatriculation.Size = new System.Drawing.Size(114, 20);
            this.txt_immatriculation.TabIndex = 7;
            // 
            // lbl_imatriculation
            // 
            this.lbl_imatriculation.AutoSize = true;
            this.lbl_imatriculation.Location = new System.Drawing.Point(31, 93);
            this.lbl_imatriculation.Name = "lbl_imatriculation";
            this.lbl_imatriculation.Size = new System.Drawing.Size(77, 13);
            this.lbl_imatriculation.TabIndex = 6;
            this.lbl_imatriculation.Text = "Immatriculation";
            // 
            // txt_annee
            // 
            this.txt_annee.Enabled = false;
            this.txt_annee.Location = new System.Drawing.Point(121, 49);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(114, 20);
            this.txt_annee.TabIndex = 5;
            // 
            // lbl_annee
            // 
            this.lbl_annee.AutoSize = true;
            this.lbl_annee.Location = new System.Drawing.Point(31, 49);
            this.lbl_annee.Name = "lbl_annee";
            this.lbl_annee.Size = new System.Drawing.Size(38, 13);
            this.lbl_annee.TabIndex = 4;
            this.lbl_annee.Text = "Annee";
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(409, 412);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 2;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 466);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.afficher_details);
            this.Controls.Add(this.choisir_categorie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Affichage";
            this.Text = "Affichage";
            this.Load += new System.EventHandler(this.Affichage_Load);
            this.choisir_categorie.ResumeLayout(false);
            this.choisir_categorie.PerformLayout();
            this.afficher_details.ResumeLayout(false);
            this.afficher_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox choisir_categorie;
        private System.Windows.Forms.GroupBox afficher_details;
        private System.Windows.Forms.ListBox list_auto;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.ComboBox combo_categorie;
        private System.Windows.Forms.TextBox txt_immatriculation;
        private System.Windows.Forms.Label lbl_imatriculation;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.Label lbl_annee;
        private System.Windows.Forms.TextBox txt_cylindre;
        private System.Windows.Forms.Label lbl_cylindre;
        private System.Windows.Forms.TextBox txt_coulour;
        private System.Windows.Forms.Label lbl_coulour;
        private System.Windows.Forms.TextBox txt_typeV;
        private System.Windows.Forms.Label lbl_typeV;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label lbl_marque;
        private System.Windows.Forms.TextBox txt_vitesse;
        private System.Windows.Forms.Label lbl_vitesse;
        private System.Windows.Forms.Button btn_fermer;
    }
}