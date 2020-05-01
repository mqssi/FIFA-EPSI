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
        public string PseudoJoueur { get; set; }

        public string NomJoueur { get; set; }

        public string PrenomJoueur { get; set; }

        public string MailJoueur { get; set; }



        public string EquipeJoueur { get; set; }





        public Joueur()
        {

        }

        public Joueur(string pseudoJoueur, string nomJoueur, string prenomJoueur, string mailJoueur, string equipeJoueur)
        {

            PseudoJoueur = pseudoJoueur;
            NomJoueur = nomJoueur;
            PrenomJoueur = prenomJoueur;
            MailJoueur = mailJoueur;
            EquipeJoueur = equipeJoueur;



        }



    }
}
