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
      


        public int ID_Match { get; set; }
        /// <summary>
        /// Repérsente la date où le match a commencé
        /// </summary>
        public DateTime DateMatch { get { return DateTime.Now; } }

        /// <summary>
        /// Repérsente le résultat d'un match
        /// </summary>
        public string ResultMatch { get; set; }




        public int ID_Gagnant { get; set; }
        /// <summary>
        /// Repérsente le gagnant d'un match
        /// </summary>
        public Equipe Winner{ get; set; }

       

        /// <summary>
        /// Repérsente le Round du Tournoi
        /// </summary>
        public int Match_Round { get; set; }



        public List<MatchEntry> Entries { get; set; } = new List<MatchEntry>();

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

      
        public string DisplayName
        {


            get
            {
                string output = "";

                foreach(MatchEntry m in Entries)
                {

                    if (m.EquipeJouant != null)
                    {
                        if (output.Length == 0)
                        {

                            output = m.EquipeJouant.Nom_Equipe;
                        } else
                        {
                            output += $" vs. {m.EquipeJouant.Nom_Equipe}";

                        }
                    }
                    else
                    {

                        output = "Le match n'est pas encore déterminé";
                        break;

                    }

                }
                return output;
            }
        }

    }
}
