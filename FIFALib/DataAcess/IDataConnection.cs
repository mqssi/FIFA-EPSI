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

        Joueur CreerJoueur(Joueur model);

        Equipe CreerEquipe(Equipe model);


        List<Joueur> GetALLJoueur();

        List<Equipe> GetTeam_ALL();

        void CreerCompet(Competition comp);

        List<Competition> Get_CompALL();
    }
}
