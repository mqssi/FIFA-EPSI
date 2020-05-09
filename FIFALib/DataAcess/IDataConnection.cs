using FIFALib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.DataAcess
{
   public interface IDataConnection
    {

        void CreerJoueur(Joueur model);

        void CreerEquipe(Equipe model);
        void UpdateMatch(Match model);
        void CreerCompet(Competition comp);

        List<Joueur> GetALLJoueur();

        List<Equipe> GetTeam_ALL();

        

        List<Competition> Get_CompALL();

        
    }
}
