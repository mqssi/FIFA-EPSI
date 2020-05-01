using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{
    /// <summary>
    /// Réprésente un match dans l'appli
    /// </summary>
    public class Match
    {
        /// <summary>
        /// Repérsente la date où le match a commencé
        /// </summary>
        public DateTime DateMatch { get { return DateTime.Now; } }

        /// <summary>
        /// Repérsente le résultat d'un match
        /// </summary>
        public string ResultMatch { get; set; }

        /// <summary>
        /// Repérsente le gagnant d'un match
        /// </summary>
        public Joueur WinnerMatch { get; set; }

        /// <summary>
        /// Repérsente le Round du Tournoi
        /// </summary>
        public int RoundMatch { get; set; }

        /// <summary>
        /// Repérsente le Score du 1er joueur
        /// </summary>
        public int ScoreJ1Match { get; set; }


        /// <summary>
        /// Repérsente le Score du 2ème joueur
        /// </summary>
        public int ScoreJ2Match { get; set; }

        /// <summary>
        /// Représente le nombre de buts du joueur
        /// </summary>

        public int NombreBut { get; set; }


    }
}
