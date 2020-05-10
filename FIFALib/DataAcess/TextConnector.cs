using FIFALib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.DataAcess
{
    public class TextConnector : IDataConnection
    {
        public void CompleteComp(Competition comp)
        {
            throw new NotImplementedException();
        }

        public void CreerCompet(Competition comp)
        {
            throw new NotImplementedException();
        }

        public void CreerEquipe(Equipe model)
        {
            throw new NotImplementedException();
        }

        public void CreerJoueur(Joueur model)
        {
            model.Id = 1;

            
        }

        public List<Joueur> GetALLJoueur()
        {
            throw new NotImplementedException();
        }

        public List<Equipe> GetTeam_ALl()
        {
            throw new NotImplementedException();
        }

        public List<Equipe> GetTeam_ALL()
        {
            throw new NotImplementedException();
        }

        public List<Competition> Get_CompALL()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatch(Match model)
        {
            throw new NotImplementedException();
        }
    }
}
