using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptApp
{
    public partial class UI_DecryptApp : Form
    {
        private FileManager fileManager;
        private string nbMotsDictionnaireStr;
        private int nbMotsDictionnaire = 0;
        private int nbTentative = 0;
        private long tempsEcoule = 0;
        
        public UI_DecryptApp()
        {
            InitializeComponent();
            fileManager = new FileManager();
        }

        private void btn_choisir_fichier_Click(object sender, EventArgs e)
        {
            tb_fichier.Text = fileManager.SelectionnerFichier();
            if (tb_fichier.Text != null)
            {
                nbMotsDictionnaireStr = lbl_nb_mots_dict.Text;
                nbMotsDictionnaire = fileManager.CompterNbMotsFichier(tb_fichier.Text);
                nbMotsDictionnaireStr += nbMotsDictionnaire.ToString();
                lbl_nb_mots_dict.Text = nbMotsDictionnaireStr;
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de la sélection du fichier. Assurez-vous de sélectionner un fichier valide.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_valider_hash_Click(object sender, EventArgs e)
        {
            if (tb_hash.Text != null && tb_fichier.Text != null)
            {
                Decrypteur decrypteur = new Decrypteur(tb_hash.Text);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                
                StreamReader sr = new StreamReader(tb_fichier.Text);
                string resultat = String.Empty;
                bool _resultat;

                do
                {
                    resultat = sr.ReadLine();
                    _resultat = decrypteur.Decripter(resultat);
                    if (_resultat)
                        break;
                    nbTentative++;
                    lbl_nb_tentative.Text = $"{nbTentative}/{nbMotsDictionnaire}";
                    lbl_nb_tentative.Refresh();
                    tempsEcoule = stopwatch.ElapsedMilliseconds;
                    lbl_temps_ecoule.Text = $"{(tempsEcoule / 1000) / 60}m{(tempsEcoule / 1000) % 60}";
                    lbl_temps_ecoule.Refresh();
                } while (!_resultat || nbTentative != nbMotsDictionnaire);

                string message = $"Votre hachage: \n {tb_hash.Text} \n \n Correspond au mot suivant: \n {resultat}";
                string caption = "Trouvé!";
                if (!decrypteur.estDecrypter)
                {
                    message = "Le hachage n'a pas été trouvé avec le dictionnaire fournit.";
                    caption = "Pas Trouvé...";
                }
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                stopwatch.Reset();
                
            }
            else
            {
                MessageBox.Show("Il manque des informations pour effectuer la decryption. Assurez-vous d'avoir sélectionné un fichier et d'avoir entré un hachage", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
