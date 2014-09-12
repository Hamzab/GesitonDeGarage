namespace GUI
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.txt_typeV = new System.Windows.Forms.TextBox();
            this.group_voiture = new System.Windows.Forms.GroupBox();
            this.txt_coulour = new System.Windows.Forms.TextBox();
            this.lbl_colour = new System.Windows.Forms.Label();
            this.lbl_typeV = new System.Windows.Forms.Label();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.lbl_annee_voiture = new System.Windows.Forms.Label();
            this.lbl_marque = new System.Windows.Forms.Label();
            this.txt_annee_voiture = new System.Windows.Forms.TextBox();
            this.combo_categorie = new System.Windows.Forms.ComboBox();
            this.lbl_categorie = new System.Windows.Forms.Label();
            this.txt_immatriculation = new System.Windows.Forms.TextBox();
            this.lbl_imatriculation = new System.Windows.Forms.Label();
            this.txt_cylindre = new System.Windows.Forms.TextBox();
            this.lbl_cylindre = new System.Windows.Forms.Label();
            this.txt_vitesse = new System.Windows.Forms.TextBox();
            this.group_moto = new System.Windows.Forms.GroupBox();
            this.lbl_annee_moto = new System.Windows.Forms.Label();
            this.txt_annee_moto = new System.Windows.Forms.TextBox();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.group_voiture.SuspendLayout();
            this.group_moto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_typeV
            // 
            this.txt_typeV.Location = new System.Drawing.Point(116, 199);
            this.txt_typeV.Name = "txt_typeV";
            this.txt_typeV.Size = new System.Drawing.Size(121, 20);
            this.txt_typeV.TabIndex = 7;
            // 
            // group_voiture
            // 
            this.group_voiture.Controls.Add(this.txt_coulour);
            this.group_voiture.Controls.Add(this.lbl_colour);
            this.group_voiture.Controls.Add(this.txt_typeV);
            this.group_voiture.Controls.Add(this.lbl_typeV);
            this.group_voiture.Controls.Add(this.txt_marque);
            this.group_voiture.Controls.Add(this.lbl_annee_voiture);
            this.group_voiture.Controls.Add(this.lbl_marque);
            this.group_voiture.Controls.Add(this.txt_annee_voiture);
            this.group_voiture.Location = new System.Drawing.Point(372, 128);
            this.group_voiture.Name = "group_voiture";
            this.group_voiture.Size = new System.Drawing.Size(257, 269);
            this.group_voiture.TabIndex = 15;
            this.group_voiture.TabStop = false;
            this.group_voiture.Text = "Voiture";
            // 
            // txt_coulour
            // 
            this.txt_coulour.Location = new System.Drawing.Point(116, 131);
            this.txt_coulour.Name = "txt_coulour";
            this.txt_coulour.Size = new System.Drawing.Size(121, 20);
            this.txt_coulour.TabIndex = 9;
            // 
            // lbl_colour
            // 
            this.lbl_colour.AutoSize = true;
            this.lbl_colour.Location = new System.Drawing.Point(14, 131);
            this.lbl_colour.Name = "lbl_colour";
            this.lbl_colour.Size = new System.Drawing.Size(43, 13);
            this.lbl_colour.TabIndex = 8;
            this.lbl_colour.Text = "Coulour";
            // 
            // lbl_typeV
            // 
            this.lbl_typeV.AutoSize = true;
            this.lbl_typeV.Location = new System.Drawing.Point(14, 199);
            this.lbl_typeV.Name = "lbl_typeV";
            this.lbl_typeV.Size = new System.Drawing.Size(41, 13);
            this.lbl_typeV.TabIndex = 6;
            this.lbl_typeV.Text = "Type V";
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(116, 167);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(121, 20);
            this.txt_marque.TabIndex = 5;
            // 
            // lbl_annee_voiture
            // 
            this.lbl_annee_voiture.AutoSize = true;
            this.lbl_annee_voiture.Location = new System.Drawing.Point(14, 90);
            this.lbl_annee_voiture.Name = "lbl_annee_voiture";
            this.lbl_annee_voiture.Size = new System.Drawing.Size(38, 13);
            this.lbl_annee_voiture.TabIndex = 9;
            this.lbl_annee_voiture.Text = "Annee";
            // 
            // lbl_marque
            // 
            this.lbl_marque.AutoSize = true;
            this.lbl_marque.Location = new System.Drawing.Point(14, 167);
            this.lbl_marque.Name = "lbl_marque";
            this.lbl_marque.Size = new System.Drawing.Size(43, 13);
            this.lbl_marque.TabIndex = 4;
            this.lbl_marque.Text = "Marque";
            // 
            // txt_annee_voiture
            // 
            this.txt_annee_voiture.Location = new System.Drawing.Point(116, 90);
            this.txt_annee_voiture.Name = "txt_annee_voiture";
            this.txt_annee_voiture.Size = new System.Drawing.Size(118, 20);
            this.txt_annee_voiture.TabIndex = 10;
            // 
            // combo_categorie
            // 
            this.combo_categorie.FormattingEnabled = true;
            this.combo_categorie.Location = new System.Drawing.Point(284, 72);
            this.combo_categorie.Name = "combo_categorie";
            this.combo_categorie.Size = new System.Drawing.Size(121, 21);
            this.combo_categorie.TabIndex = 14;
            this.combo_categorie.SelectedIndexChanged += new System.EventHandler(this.combo_categorie_SelectedIndexChanged);
            // 
            // lbl_categorie
            // 
            this.lbl_categorie.AutoSize = true;
            this.lbl_categorie.Location = new System.Drawing.Point(201, 80);
            this.lbl_categorie.Name = "lbl_categorie";
            this.lbl_categorie.Size = new System.Drawing.Size(52, 13);
            this.lbl_categorie.TabIndex = 13;
            this.lbl_categorie.Text = "Categorie";
            // 
            // txt_immatriculation
            // 
            this.txt_immatriculation.Location = new System.Drawing.Point(284, 31);
            this.txt_immatriculation.Name = "txt_immatriculation";
            this.txt_immatriculation.Size = new System.Drawing.Size(121, 20);
            this.txt_immatriculation.TabIndex = 12;
            // 
            // lbl_imatriculation
            // 
            this.lbl_imatriculation.AutoSize = true;
            this.lbl_imatriculation.Location = new System.Drawing.Point(201, 31);
            this.lbl_imatriculation.Name = "lbl_imatriculation";
            this.lbl_imatriculation.Size = new System.Drawing.Size(77, 13);
            this.lbl_imatriculation.TabIndex = 11;
            this.lbl_imatriculation.Text = "Immatriculation";
            // 
            // txt_cylindre
            // 
            this.txt_cylindre.Location = new System.Drawing.Point(86, 126);
            this.txt_cylindre.Name = "txt_cylindre";
            this.txt_cylindre.Size = new System.Drawing.Size(121, 20);
            this.txt_cylindre.TabIndex = 7;
            // 
            // lbl_cylindre
            // 
            this.lbl_cylindre.AutoSize = true;
            this.lbl_cylindre.Location = new System.Drawing.Point(3, 126);
            this.lbl_cylindre.Name = "lbl_cylindre";
            this.lbl_cylindre.Size = new System.Drawing.Size(44, 13);
            this.lbl_cylindre.TabIndex = 6;
            this.lbl_cylindre.Text = "Cylindre";
            // 
            // txt_vitesse
            // 
            this.txt_vitesse.Location = new System.Drawing.Point(86, 165);
            this.txt_vitesse.Name = "txt_vitesse";
            this.txt_vitesse.Size = new System.Drawing.Size(121, 20);
            this.txt_vitesse.TabIndex = 5;
            // 
            // group_moto
            // 
            this.group_moto.Controls.Add(this.lbl_annee_moto);
            this.group_moto.Controls.Add(this.txt_annee_moto);
            this.group_moto.Controls.Add(this.txt_cylindre);
            this.group_moto.Controls.Add(this.lbl_cylindre);
            this.group_moto.Controls.Add(this.txt_vitesse);
            this.group_moto.Controls.Add(this.lbl_vitesse);
            this.group_moto.Location = new System.Drawing.Point(30, 128);
            this.group_moto.Name = "group_moto";
            this.group_moto.Size = new System.Drawing.Size(248, 269);
            this.group_moto.TabIndex = 16;
            this.group_moto.TabStop = false;
            this.group_moto.Text = "Moto";
            // 
            // lbl_annee_moto
            // 
            this.lbl_annee_moto.AutoSize = true;
            this.lbl_annee_moto.Location = new System.Drawing.Point(3, 90);
            this.lbl_annee_moto.Name = "lbl_annee_moto";
            this.lbl_annee_moto.Size = new System.Drawing.Size(38, 13);
            this.lbl_annee_moto.TabIndex = 17;
            this.lbl_annee_moto.Text = "Annee";
            // 
            // txt_annee_moto
            // 
            this.txt_annee_moto.Location = new System.Drawing.Point(86, 90);
            this.txt_annee_moto.Name = "txt_annee_moto";
            this.txt_annee_moto.Size = new System.Drawing.Size(118, 20);
            this.txt_annee_moto.TabIndex = 18;
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Location = new System.Drawing.Point(3, 168);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(41, 13);
            this.lbl_vitesse.TabIndex = 4;
            this.lbl_vitesse.Text = "Vitesse";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(203, 417);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.group_moto);
            this.Controls.Add(this.group_voiture);
            this.Controls.Add(this.combo_categorie);
            this.Controls.Add(this.lbl_categorie);
            this.Controls.Add(this.txt_immatriculation);
            this.Controls.Add(this.lbl_imatriculation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Update_Load);
            this.group_voiture.ResumeLayout(false);
            this.group_voiture.PerformLayout();
            this.group_moto.ResumeLayout(false);
            this.group_moto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_typeV;
        private System.Windows.Forms.GroupBox group_voiture;
        private System.Windows.Forms.TextBox txt_coulour;
        private System.Windows.Forms.Label lbl_colour;
        private System.Windows.Forms.Label lbl_typeV;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label lbl_annee_voiture;
        private System.Windows.Forms.Label lbl_marque;
        private System.Windows.Forms.TextBox txt_annee_voiture;
        private System.Windows.Forms.ComboBox combo_categorie;
        private System.Windows.Forms.Label lbl_categorie;
        private System.Windows.Forms.TextBox txt_immatriculation;
        private System.Windows.Forms.Label lbl_imatriculation;
        private System.Windows.Forms.TextBox txt_cylindre;
        private System.Windows.Forms.Label lbl_cylindre;
        private System.Windows.Forms.TextBox txt_vitesse;
        private System.Windows.Forms.GroupBox group_moto;
        private System.Windows.Forms.Label lbl_annee_moto;
        private System.Windows.Forms.TextBox txt_annee_moto;
        private System.Windows.Forms.Label lbl_vitesse;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button button1;
    }
}