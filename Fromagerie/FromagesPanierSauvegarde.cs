using System;
using System.Collections.Generic;
using System.Text;

namespace Fromagerie
{
    public class FromagesPanierSauvegarde
    {
        

        public int IdFromage { get; set; }
        public string nomDuFromage { get; set; }
        public decimal Poids { get; set; }      
        public int Quantite { get; set; }
        public decimal prix_kg { get; set; }

        public decimal PoidsTotal => Poids * Quantite;
        public decimal Total => prix_kg * Quantite;


        public static class SessionPanier
        {
            // Cette liste reste en mémoire tant que l'application est ouverte
            public static List<FromagesPanierSauvegarde> Articles { get; } = new List<FromagesPanierSauvegarde>();

            public static void AjouterOuAugmenter(FromagesPanierSauvegarde nouvelArticle)
            {
                var existant = Articles.FirstOrDefault(a => a.IdFromage == nouvelArticle.IdFromage);
                if (existant != null)
                {
                    existant.Quantite += nouvelArticle.Quantite;
                }
                else
                {
                    Articles.Add(nouvelArticle);
                }
            }
        }

    }
}
