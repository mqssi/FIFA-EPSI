﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{

    /// <summary>
    /// Représente une compétition dans l'appli
    /// </summary>
     public class Competition
    {
        /// <summary>
        /// Représente le nom d'une compétition
        /// </summary>
        public string NomCompetition { get; set; }


        /// <summary>
        /// Représente le gagnant d'une compétition
        /// </summary>
        public Joueur GagnantCompetition { get; set; }

        /// <summary>
        /// Représente le Nombre de joueur dans la compétition
        /// </summary>
        public int NbjoueurCompetition { get; set; }

        /// <summary>
        /// Représente la date de début de la compétition
        /// </summary>
        public DateTime DateCompetition { get { return DateTime.Now; } }

        /// <summary>
        /// Représente les matchs de la compétition
        /// </summary>
        public List<Match> MatchsCompetition { get; set; } = new List<Match>();
        /// <summary>
        /// Représente les joueurs dans une compétition
        /// </summary>
        public List<Joueur> JoeursCompetition { get; set; } = new List<Joueur>();

    }
}
