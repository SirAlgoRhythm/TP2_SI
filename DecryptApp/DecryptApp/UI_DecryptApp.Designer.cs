namespace DecryptApp
{
    partial class UI_DecryptApp
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
            this.lbl_tentative_title = new System.Windows.Forms.Label();
            this.lbl_nb_tentative = new System.Windows.Forms.Label();
            this.lbl_tmp_title = new System.Windows.Forms.Label();
            this.lbl_temps_ecoule = new System.Windows.Forms.Label();
            this.lbl_hash_title = new System.Windows.Forms.Label();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.btn_valider_hash = new System.Windows.Forms.Button();
            this.lbl_dict_title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_choisir_fichier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tentative_title
            // 
            this.lbl_tentative_title.AutoSize = true;
            this.lbl_tentative_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentative_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_tentative_title.Name = "lbl_tentative_title";
            this.lbl_tentative_title.Size = new System.Drawing.Size(66, 19);
            this.lbl_tentative_title.TabIndex = 0;
            this.lbl_tentative_title.Text = "Tentative:";
            // 
            // lbl_nb_tentative
            // 
            this.lbl_nb_tentative.AutoSize = true;
            this.lbl_nb_tentative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb_tentative.Location = new System.Drawing.Point(84, 9);
            this.lbl_nb_tentative.Name = "lbl_nb_tentative";
            this.lbl_nb_tentative.Size = new System.Drawing.Size(0, 19);
            this.lbl_nb_tentative.TabIndex = 1;
            // 
            // lbl_tmp_title
            // 
            this.lbl_tmp_title.AutoSize = true;
            this.lbl_tmp_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tmp_title.Location = new System.Drawing.Point(12, 37);
            this.lbl_tmp_title.Name = "lbl_tmp_title";
            this.lbl_tmp_title.Size = new System.Drawing.Size(95, 19);
            this.lbl_tmp_title.TabIndex = 2;
            this.lbl_tmp_title.Text = "Temps écoulé:";
            // 
            // lbl_temps_ecoule
            // 
            this.lbl_temps_ecoule.AutoSize = true;
            this.lbl_temps_ecoule.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temps_ecoule.Location = new System.Drawing.Point(113, 37);
            this.lbl_temps_ecoule.Name = "lbl_temps_ecoule";
            this.lbl_temps_ecoule.Size = new System.Drawing.Size(0, 19);
            this.lbl_temps_ecoule.TabIndex = 3;
            // 
            // lbl_hash_title
            // 
            this.lbl_hash_title.AutoSize = true;
            this.lbl_hash_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hash_title.Location = new System.Drawing.Point(12, 154);
            this.lbl_hash_title.Name = "lbl_hash_title";
            this.lbl_hash_title.Size = new System.Drawing.Size(150, 19);
            this.lbl_hash_title.TabIndex = 4;
            this.lbl_hash_title.Text = "Saisir votre hachage ici:";
            // 
            // tb_hash
            // 
            this.tb_hash.Location = new System.Drawing.Point(13, 177);
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.Size = new System.Drawing.Size(316, 20);
            this.tb_hash.TabIndex = 5;
            // 
            // btn_valider_hash
            // 
            this.btn_valider_hash.BackColor = System.Drawing.SystemColors.Control;
            this.btn_valider_hash.Location = new System.Drawing.Point(335, 175);
            this.btn_valider_hash.Name = "btn_valider_hash";
            this.btn_valider_hash.Size = new System.Drawing.Size(75, 23);
            this.btn_valider_hash.TabIndex = 6;
            this.btn_valider_hash.Text = "Valider";
            this.btn_valider_hash.UseVisualStyleBackColor = false;
            this.btn_valider_hash.Click += new System.EventHandler(this.btn_valider_hash_Click);
            // 
            // lbl_dict_title
            // 
            this.lbl_dict_title.AutoSize = true;
            this.lbl_dict_title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dict_title.Location = new System.Drawing.Point(12, 85);
            this.lbl_dict_title.Name = "lbl_dict_title";
            this.lbl_dict_title.Size = new System.Drawing.Size(276, 19);
            this.lbl_dict_title.TabIndex = 7;
            this.lbl_dict_title.Text = "Saisir le fichier qui contient le dictionnaire ici:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btn_choisir_fichier
            // 
            this.btn_choisir_fichier.BackColor = System.Drawing.SystemColors.Control;
            this.btn_choisir_fichier.Location = new System.Drawing.Point(335, 103);
            this.btn_choisir_fichier.Name = "btn_choisir_fichier";
            this.btn_choisir_fichier.Size = new System.Drawing.Size(75, 23);
            this.btn_choisir_fichier.TabIndex = 9;
            this.btn_choisir_fichier.Text = "Choisir";
            this.btn_choisir_fichier.UseVisualStyleBackColor = false;
            this.btn_choisir_fichier.Click += new System.EventHandler(this.btn_choisir_fichier_Click);
            // 
            // UI_DecryptApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 212);
            this.Controls.Add(this.btn_choisir_fichier);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_dict_title);
            this.Controls.Add(this.btn_valider_hash);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.lbl_hash_title);
            this.Controls.Add(this.lbl_temps_ecoule);
            this.Controls.Add(this.lbl_tmp_title);
            this.Controls.Add(this.lbl_nb_tentative);
            this.Controls.Add(this.lbl_tentative_title);
            this.Name = "UI_DecryptApp";
            this.Text = "Decripter un mdp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tentative_title;
        private System.Windows.Forms.Label lbl_nb_tentative;
        private System.Windows.Forms.Label lbl_tmp_title;
        private System.Windows.Forms.Label lbl_temps_ecoule;
        private System.Windows.Forms.Label lbl_hash_title;
        private System.Windows.Forms.TextBox tb_hash;
        private System.Windows.Forms.Button btn_valider_hash;
        private System.Windows.Forms.Label lbl_dict_title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_choisir_fichier;
    }
}

