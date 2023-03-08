using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionnaireApp
{
    public partial class UI_GenerateurDeDictionnaire : Form
    {
        private FileManager fileManager;
        public UI_GenerateurDeDictionnaire()
        {
            InitializeComponent();
            fileManager = new FileManager();
        }

        private void btn_choisir_file_Click(object sender, EventArgs e)
        {
            tb_path.Text = fileManager.SelectionnerFichier();
        }
    }
}
