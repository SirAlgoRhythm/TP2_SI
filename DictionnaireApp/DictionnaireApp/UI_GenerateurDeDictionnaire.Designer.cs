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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numUD_min = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_min)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_creer_dict
            // 
            this.btn_creer_dict.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creer_dict.Location = new System.Drawing.Point(16, 406);
            this.btn_creer_dict.Name = "btn_creer_dict";
            this.btn_creer_dict.Size = new System.Drawing.Size(370, 23);
            this.btn_creer_dict.TabIndex = 19;
            this.btn_creer_dict.Text = "Creer le dictionnaire";
            this.btn_creer_dict.UseVisualStyleBackColor = true;
            // 
            // btn_choisir_file
            // 
            this.btn_choisir_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choisir_file.Location = new System.Drawing.Point(332, 360);
            this.btn_choisir_file.Name = "btn_choisir_file";
            this.btn_choisir_file.Size = new System.Drawing.Size(54, 23);
            this.btn_choisir_file.TabIndex = 18;
            this.btn_choisir_file.Text = "Fichier";
            this.btn_choisir_file.UseVisualStyleBackColor = true;
            this.btn_choisir_file.Click += new System.EventHandler(this.btn_choisir_file_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choix du fichier de destination";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(16, 362);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(310, 20);
            this.tb_path.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 22);
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
            this.clb_choix_char.Location = new System.Drawing.Point(16, 123);
            this.clb_choix_char.Name = "clb_choix_char";
            this.clb_choix_char.Size = new System.Drawing.Size(370, 193);
            this.clb_choix_char.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(342, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 29);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUD_min
            // 
            this.numUD_min.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_min.Location = new System.Drawing.Point(342, 8);
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
            this.numUD_min.Size = new System.Drawing.Size(44, 29);
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
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Longueur maximum des mots de passe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Longueur minimum des mots de passe:";
            // 
            // UI_GenerateurDeDictionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.btn_creer_dict);
            this.Controls.Add(this.btn_choisir_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clb_choix_char);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numUD_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UI_GenerateurDeDictionnaire";
            this.Text = "UI_GenerateurDeDictionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numUD_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}