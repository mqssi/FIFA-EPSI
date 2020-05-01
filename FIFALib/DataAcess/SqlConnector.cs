using FIFALib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;




namespace FIFALib.DataAcess
{
    public class SqlConnector : IDataConnection
    {

        /// <summary>
        /// Sauvegarde un joueur dans la base de données
        /// </summary>
        /// <param name="model"> Les informations concernants un joueur</param>
        /// <returns>Le Pseudo, Nom, Prénom, Mail et l'Id du Joueur</returns>
        public Joueur CreerJoueur(Joueur model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("FIFA")))
            {



                var j = new DynamicParameters();

                j.Add("@Pseudo_Joueur", model.PseudoJoueur);
                j.Add("@Nom_Joueur", model.NomJoueur);
                j.Add("@Prenom_Joueur", model.PrenomJoueur);
                j.Add("@Mail_Joueur", model.MailJoueur);
                j.Add("Equipe_Joueur", model.EquipeJoueur);
                j.Add("@ID_Joueur", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.Joueur_Insert", j, commandType: CommandType.StoredProcedure);

                model.Id = j.Get<int>("@ID_Joueur");

                return model;


            }




        }


    }
}
