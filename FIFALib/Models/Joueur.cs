using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{
    /// <summary>
    /// Représente un joueur dans l'application
    /// </summary>
    public class Joueur
    {


        /// <summary>
        /// l'identifiant unique d'un joueur
        /// </summary>
        public int Id { get; set; }




        /// <summary>
        /// Représente le pseudo d'un joueur
        /// </summary>
        public string Pseudo_Joueur { get; set; }

        public string Nom_Joueur { get; set; }

        public string Prenom_Joueur { get; set; }

        public string Mail_Joueur { get; set; }



        public string Equipe_Joueur { get; set; }





        public Joueur()
        {

        }

        public Joueur(string pseudoJoueur, string nomJoueur, string prenomJoueur, string mailJoueur, string equipeJoueur)
        {

            Pseudo_Joueur = pseudoJoueur;
            Nom_Joueur = nomJoueur;
            Prenom_Joueur = prenomJoueur;
            Mail_Joueur = mailJoueur;
            Equipe_Joueur = equipeJoueur;



        }



    }
}
