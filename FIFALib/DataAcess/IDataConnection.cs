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

        List<Joueur> GetALLJoueur();

    }
}
