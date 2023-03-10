namespace DictionnaireApp
{
    partial class UI_GenerateurDeDictionnaire
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
            this.btn_creer_dict = new System.Windows.Forms.Button();
            this.btn_choisir_file = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clb_choix_char = new System.Windows.Forms.CheckedListBox();
            this.numUD_max = new System.Windows.Forms.NumericUpDown();
            this.numUD_min = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Validation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_min)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_creer_dict
            // 
            this.btn_creer_dict.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer_dict.Location = new System.Drawing.Point(21, 500);
            this.btn_creer_dict.Margin = new System.Windows.Forms.Padding(4);
            this.btn_creer_dict.Name = "btn_creer_dict";
            this.btn_creer_dict.Size = new System.Drawing.Size(493, 28);
            this.btn_creer_dict.TabIndex = 19;
            this.btn_creer_dict.Text = "Creer le dictionnaire";
            this.btn_creer_dict.UseVisualStyleBackColor = true;
            this.btn_creer_dict.Click += new System.EventHandler(this.btn_creer_dict_Click);
            // 
            // btn_choisir_file
            // 
            this.btn_choisir_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choisir_file.Location = new System.Drawing.Point(443, 443);
            this.btn_choisir_file.Margin = new System.Windows.Forms.Padding(4);
            this.btn_choisir_file.Name = "btn_choisir_file";
            this.btn_choisir_file.Size = new System.Drawing.Size(72, 28);
            this.btn_choisir_file.TabIndex = 18;
            this.btn_choisir_file.Text = "Fichier";
            this.btn_choisir_file.UseVisualStyleBackColor = true;
            this.btn_choisir_file.Click += new System.EventHandler(this.btn_choisir_file_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choix du fichier de destination";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(21, 446);
            this.tb_path.Margin = new System.Windows.Forms.Padding(4);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(412, 22);
            this.tb_path.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choix des caractères permis";
            // 
            // clb_choix_char
            // 
            this.clb_choix_char.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_choix_char.FormattingEnabled = true;
            this.clb_choix_char.Items.AddRange(new object[] {
            "Alphabet minuscule",
            "Alphabet majuscule",
            "Chiffres",
            "#",
            "$",
            "%",
            "?",
            "&",
            "*"});
            this.clb_choix_char.Location = new System.Drawing.Point(21, 151);
            this.clb_choix_char.Margin = new System.Windows.Forms.Padding(4);
            this.clb_choix_char.Name = "clb_choix_char";
            this.clb_choix_char.Size = new System.Drawing.Size(492, 229);
            this.clb_choix_char.TabIndex = 14;
            // 
            // numUD_max
            // 
            this.numUD_max.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_max.Location = new System.Drawing.Point(456, 65);
            this.numUD_max.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_max.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUD_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_max.Name = "numUD_max";
            this.numUD_max.Size = new System.Drawing.Size(59, 35);
            this.numUD_max.TabIndex = 13;
            this.numUD_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUD_min
            // 
            this.numUD_min.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_min.Location = new System.Drawing.Point(456, 10);
            this.numUD_min.Margin = new System.Windows.Forms.Padding(4);
            this.numUD_min.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUD_min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_min.Name = "numUD_min";
            this.numUD_min.Size = new System.Drawing.Size(59, 35);
            this.numUD_min.TabIndex = 12;
            this.numUD_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUD_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Longueur maximum des mots de passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Longueur minimum des mots de passe:";
            // 
            // Validation
            // 
            this.Validation.AutoSize = true;
            this.Validation.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Validation.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Validation.Location = new System.Drawing.Point(236, 532);
            this.Validation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(34, 19);
            this.Validation.TabIndex = 20;
            this.Validation.Text = "test";
            // 
            // UI_GenerateurDeDictionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 554);
            this.Controls.Add(this.Validation);
            this.Controls.Add(this.btn_creer_dict);
            this.Controls.Add(this.btn_choisir_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clb_choix_char);
            this.Controls.Add(this.numUD_max);
            this.Controls.Add(this.numUD_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UI_GenerateurDeDictionnaire";
            this.Text = "UI_GenerateurDeDictionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_creer_dict;
        private System.Windows.Forms.Button btn_choisir_file;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clb_choix_char;
        private System.Windows.Forms.NumericUpDown numUD_max;
        private System.Windows.Forms.NumericUpDown numUD_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Validation;
    }
}