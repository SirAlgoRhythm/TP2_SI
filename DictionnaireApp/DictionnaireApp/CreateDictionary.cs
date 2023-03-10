using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireApp
{
    internal class CreateDictionary
    {
        public void MakeAList(List<string> ListEntree, int min, int max, FileManager fileManager, string fileName)
        {
            max = max - 1;
            List<string> listTemp = new List<string>();
            listTemp.AddRange(ListEntree);

            List<string> listInitial = new List<string>();
            listInitial.AddRange(ListEntree);
            int counter = 0;
            int skipToIndex = 0;

            // pour avoir des éléments de longeur max
            for (int i = 0; i < max; i++)
            {
                //pour traverser la liste d'entrée
                // on saute les éléments qu'on a déjà fait avec skipToIndex
                for (int j = 0 + skipToIndex; j < listTemp.Count; j++)
                {
                    //créer un nouvel élément qui contient l'élément de la liste actuelle + l'élément x de la liste initiale
                    // faire un nouvel élément pour chaque élément de la liste initiale
                    foreach (var value in listInitial)
                    {
                        string nouveau = listTemp[j] + value;
                        ListEntree.Add(nouveau);
                    }
                    counter++;

                    // print pour voir l'évolution de la liste lors de tests
                    //foreach (var value in ListEntree)
                    //    Console.Write(value + ", ");
                    //Console.WriteLine();
                }
                skipToIndex = counter;
                counter = 0;

                //ajouter les nouveaux éléments créés
                // utiliser Clear() pour pas se répéter
                listTemp.Clear();
                listTemp.AddRange(ListEntree);
            }
            // traverser la liste qu'on a obtenu
            // si la longueur de la chaine est plus petite que le minimum, on l'enlève
            foreach (var result in listTemp)
            {
                if (result.Length < min)
                {
                    ListEntree.Remove(result);
                }
            }

            //écrire dans le fichier sélectionné
            using (StreamWriter streamWriter = fileManager.OuvrirFichier(fileName))
            {
                foreach (var element in ListEntree)
                {
                    streamWriter.WriteLine(element.ToString());
                }
                streamWriter.Close();
            }


        }
    }
}
