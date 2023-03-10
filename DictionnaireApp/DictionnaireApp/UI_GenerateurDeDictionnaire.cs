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
        const string _alphabetMin = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        const string _alphabetMaj = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        const string _chiffre = "0,1,2,3,4,5,6,7,8,9";
        const string _charSpecial1 = "#";
        const string _charSpecial2 = "$";
        const string _charSpecial3 = "%";
        const string _charSpecial4 = "?";
        const string _charSpecial5 = "&";
        const string _charSpecial6 = "*";
       public string[] tableau ={ _alphabetMin, _alphabetMaj, _chiffre, _charSpecial1, _charSpecial2, _charSpecial3 , _charSpecial4 , _charSpecial5, _charSpecial6};
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
            string caractereUtilise = "";
            for(int i=0; i< clb_choix_char.Items.Count;i++)
            {
                if (clb_choix_char.GetItemCheckState(i)==CheckState.Checked)
                {
                    caractereUtilise += tableau[i] + ",";
                }
            }
            //Enlever la dernière virgule pour pas avoir d'espaces vides
            caractereUtilise = caractereUtilise.Remove(caractereUtilise.Length-1);
            List<string> list = caractereUtilise.Split(',').ToList();
            int min = (int)numUD_min.Value;
            int max = (int)numUD_max.Value;

            createDictionary.MakeAList(list, min, max, fileManager, tb_path.Text);
            Validation.Text = "Le fichier a été créé!";
        }
    }
}
