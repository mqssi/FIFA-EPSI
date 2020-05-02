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
        public Joueur CreerJoueur(Joueur model)
        {
            model.Id = 1;

            return model;
        }

        public List<Joueur> GetALLJoueur()
        {
            throw new NotImplementedException();
        }
    }
}
