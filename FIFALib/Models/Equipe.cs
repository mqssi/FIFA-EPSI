using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{
     public class Equipe
    {



        public int Id { get; set; }
        public List<Joueur> MembreEquipe { get; set; } = new List<Joueur>();
        public string Nom_Equipe { get; set; }



    }
}
