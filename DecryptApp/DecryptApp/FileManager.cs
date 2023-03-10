using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecryptApp
{
    internal class FileManager
    {
        public string SelectionnerFichier()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        public string CompterNbMotsFichier(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            int compteur = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                compteur++;
            }
            return " " + compteur.ToString();
        }
    }
}
