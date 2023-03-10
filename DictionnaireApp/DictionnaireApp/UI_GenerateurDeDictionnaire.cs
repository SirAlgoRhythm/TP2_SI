using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionnaireApp
{
    public partial class UI_GenerateurDeDictionnaire : Form
    {
        private FileManager fileManager;
        private CreateDictionary createDictionary;
       
        public UI_GenerateurDeDictionnaire()
        {
            InitializeComponent();
            fileManager = new FileManager();
            createDictionary = new CreateDictionary();

        }

        private void btn_choisir_file_Click(object sender, EventArgs e)
        {
            tb_path.Text = fileManager.SelectionnerFichier();
        }

        private void btn_creer_dict_Click(object sender, EventArgs e)
        {
            string caractereUtilise = tb_chars_permis.Text;
            List<string> list = caractereUtilise.Split(',').ToList();
            int min = (int)numUD_min.Value;
            int max = (int)numUD_max.Value;

            createDictionary.MakeAList(list, min, max, fileManager, tb_path.Text);
            MessageBox.Show("Le dictionnaire a été créé!");
        }
    }
}
