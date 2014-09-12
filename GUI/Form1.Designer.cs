namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_annee = new System.Windows.Forms.Label();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.txt_immatriculation = new System.Windows.Forms.TextBox();
            this.lbl_imatriculation = new System.Windows.Forms.Label();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.combo_categorie = new System.Windows.Forms.ComboBox();
            this.group_moto = new System.Windows.Forms.GroupBox();
            this.txt_cylindre = new System.Windows.Forms.TextBox();
            this.lbl_cylindre = new System.Windows.Forms.Label();
            this.txt_vitesse = new System.Windows.Forms.TextBox();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.group_voiture = new System.Windows.Forms.GroupBox();
            this.txt_coulour = new System.Windows.Forms.TextBox();
            this.lbl_colour = new System.Windows.Forms.Label();
            this.txt_typeV = new System.Windows.Forms.TextBox();
            this.lbl_typeV = new System.Windows.Forms.Label();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.lbl_marque = new System.Windows.Forms.Label();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_sup = new System.Windows.Forms.Button();
            this.group_moto.SuspendLayout();
            this.group_voiture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_annee
            // 
            this.lbl_annee.AutoSize = true;
            this.lbl_annee.Location = new System.Drawing.Point(184, 25);
            this.lbl_annee.Name = "lbl_annee";
            this.lbl_annee.Size = new System.Drawing.Size(38, 13);
            this.lbl_annee.TabIndex = 0;
            this.lbl_annee.Text = "Annee";
            // 
            // txt_annee
            // 
            this.txt_annee.Location = new System.Drawing.Point(267, 25);
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.Size = new System.Drawing.Size(121, 20);
            this.txt_annee.TabIndex = 1;
            // 
            // txt_immatriculation
            // 
            this.txt_immatriculation.Location = new System.Drawing.Point(267, 69);
            this.txt_immatriculation.Name = "txt_immatriculation";
            this.txt_immatriculation.Size = new System.Drawing.Size(121, 20);
            this.txt_immatriculation.TabIndex = 3;
            // 
            // lbl_imatriculation
            // 
            this.lbl_imatriculation.AutoSize = true;
            this.lbl_imatriculation.Location = new System.Drawing.Point(184, 69);
            this.lbl_imatriculation.Name = "lbl_imatriculation";
            this.lbl_imatriculation.Size = new System.Drawing.Size(77, 13);
            this.lbl_imatriculation.TabIndex = 2;
            this.lbl_imatriculation.Text = "Immatriculation";
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Location = new System.Drawing.Point(184, 118);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(52, 13);
            this.lbl_categorie.TabIndex = 4;
            this.lbl_categorie.Text = "Categorie";
            // 
            // combo_categorie
            // 
            this.combo_categorie.FormattingEnabled = true;
            this.combo_categorie.Location = new System.Drawing.Point(267, 110);
            this.combo_categorie.Name = "combo_categorie";
            this.combo_categorie.Size = new System.Drawing.Size(121, 21);
            this.combo_categorie.TabIndex = 6;
            this.combo_categorie.SelectedIndexChanged += new System.EventHandler(this.combo_categorie_SelectedIndexChanged);
            // 
            // group_moto
            // 
            this.group_moto.Controls.Add(this.txt_cylindre);
            this.group_moto.Controls.Add(this.lbl_cylindre);
            this.group_moto.Controls.Add(this.txt_vitesse);
            this.group_moto.Controls.Add(this.lbl_vitesse);
            this.group_moto.Location = new System.Drawing.Point(31, 164);
            this.group_moto.Name = "group_moto";
            this.group_moto.Size = new System.Drawing.Size(248, 185);
            this.group_moto.TabIndex = 7;
            this.group_moto.TabStop = false;
            this.group_moto.Text = "Moto";
            this.group_moto.Enter += new System.EventHandler(this.group_moto_Enter);
            // 
            // txt_cylindre
            // 
            this.txt_cylindre.Location = new System.Drawing.Point(90, 41);
            this.txt_cylindre.Name = "txt_cylindre";
            this.txt_cylindre.Size = new System.Drawing.Size(121, 20);
            this.txt_cylindre.TabIndex = 7;
            // 
            // lbl_cylindre
            // 
            this.lbl_cylindre.AutoSize = true;
            this.lbl_cylindre.Location = new System.Drawing.Point(7, 41);
            this.lbl_cylindre.Name = "lbl_cylindre";
            this.lbl_cylindre.Size = new System.Drawing.Size(44, 13);
            this.lbl_cylindre.TabIndex = 6;
            this.lbl_cylindre.Text = "Cylindre";
            // 
            // txt_vitesse
            // 
            this.txt_vitesse.Location = new System.Drawing.Point(90, 80);
            this.txt_vitesse.Name = "txt_vitesse";
            this.txt_vitesse.Size = new System.Drawing.Size(121, 20);
            this.txt_vitesse.TabIndex = 5;
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Location = new System.Drawing.Point(10, 83);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(41, 13);
            this.lbl_vitesse.TabIndex = 4;
            this.lbl_vitesse.Text = "Vitesse";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(31, 373);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(130, 23);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter Automobile";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // group_voiture
            // 
            this.group_voiture.Controls.Add(this.txt_coulour);
            this.group_voiture.Controls.Add(this.lbl_colour);
            this.group_voiture.Controls.Add(this.txt_typeV);
            this.group_voiture.Controls.Add(this.lbl_typeV);
            this.group_voiture.Controls.Add(this.txt_marque);
            this.group_voiture.Controls.Add(this.lbl_marque);
            this.group_voiture.Location = new System.Drawing.Point(339, 164);
            this.group_voiture.Name = "group_voiture";
            this.group_voiture.Size = new System.Drawing.Size(255, 185);
            this.group_voiture.TabIndex = 8;
            this.group_voiture.TabStop = false;
            this.group_voiture.Text = "Voiture";
            // 
            // txt_coulour
            // 
            this.txt_coulour.Location = new System.Drawing.Point(108, 41);
            this.txt_coulour.Name = "txt_coulour";
            this.txt_coulour.Size = new System.Drawing.Size(121, 20);
            this.txt_coulour.TabIndex = 9;
            // 
            // lbl_colour
            // 
            this.lbl_colour.AutoSize = true;
            this.lbl_colour.Location = new System.Drawing.Point(6, 41);
            this.lbl_colour.Name = "lbl_colour";
            this.lbl_colour.Size = new System.Drawing.Size(43, 13);
            this.lbl_colour.TabIndex = 8;
            this.lbl_colour.Text = "Coulour";
            // 
            // txt_typeV
            // 
            this.txt_typeV.Location = new System.Drawing.Point(108, 109);
            this.txt_typeV.Name = "txt_typeV";
            this.txt_typeV.Size = new System.Drawing.Size(121, 20);
            this.txt_typeV.TabIndex = 7;
            // 
            // lbl_typeV
            // 
            this.lbl_typeV.AutoSize = true;
            this.lbl_typeV.Location = new System.Drawing.Point(6, 109);
            this.lbl_typeV.Name = "lbl_typeV";
            this.lbl_typeV.Size = new System.Drawing.Size(41, 13);
            this.lbl_typeV.TabIndex = 6;
            this.lbl_typeV.Text = "Type V";
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(108, 77);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(121, 20);
            this.txt_marque.TabIndex = 5;
            // 
            // lbl_marque
            // 
            this.lbl_marque.AutoSize = true;
            this.lbl_marque.Location = new System.Drawing.Point(6, 77);
            this.lbl_marque.Name = "lbl_marque";
            this.lbl_marque.Size = new System.Drawing.Size(43, 13);
            this.lbl_marque.TabIndex = 4;
            this.lbl_marque.Text = "Marque";
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(189, 373);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(125, 23);
            this.btn_afficher.TabIndex = 1;
            this.btn_afficher.Text = "Afficher Automobiles";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(339, 373);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update Automobile";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(480, 373);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(131, 23);
            this.btn_sup.TabIndex = 10;
            this.btn_sup.Text = "Supprimer Automobile";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(635, 414);
            this.Controls.Add(this.btn_sup);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.group_voiture);
            this.Controls.Add(this.group_moto);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.combo_categorie);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.lbl_categorie);
            this.Controls.Add(this.txt_immatriculation);
            this.Controls.Add(this.lbl_imatriculation);
            this.Controls.Add(this.txt_annee);
            this.Controls.Add(this.lbl_annee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion de garage ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_moto.ResumeLayout(false);
            this.group_moto.PerformLayout();
            this.group_voiture.ResumeLayout(false);
            this.group_voiture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_annee;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.TextBox txt_immatriculation;
        private System.Windows.Forms.Label lbl_imatriculation;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.ComboBox combo_categorie;
        private System.Windows.Forms.GroupBox group_moto;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.GroupBox group_voiture;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.TextBox txt_cylindre;
        private System.Windows.Forms.Label lbl_cylindre;
        private System.Windows.Forms.TextBox txt_vitesse;
        private System.Windows.Forms.Label lbl_vitesse;
        private System.Windows.Forms.TextBox txt_coulour;
        private System.Windows.Forms.Label lbl_colour;
        private System.Windows.Forms.TextBox txt_typeV;
        private System.Windows.Forms.Label lbl_typeV;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label lbl_marque;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_sup;
    }
}

