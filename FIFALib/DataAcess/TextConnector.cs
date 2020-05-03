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
        public void CreerCompet(Competition comp)
        {
            throw new NotImplementedException();
        }

        public Equipe CreerEquipe(Equipe model)
        {
            throw new NotImplementedException();
        }

        public Joueur CreerJoueur(Joueur model)
        {
            model.Id = 1;

            return model;
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
    }
}
