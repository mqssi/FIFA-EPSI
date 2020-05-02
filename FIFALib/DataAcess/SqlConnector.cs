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
        private const string db = "FIFA";
        /// <summary>
        /// Sauvegarde un joueur dans la base de données
        /// </summary>
        /// <param name="model"> Les informations concernants un joueur</param>
        /// <returns>Le Pseudo, Nom, Prénom, Mail et l'Id du Joueur</returns>
        public Joueur CreerJoueur(Joueur model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {



                var j = new DynamicParameters();

                j.Add("@Pseudo_Joueur", model.Pseudo_Joueur);
                j.Add("@Nom_Joueur", model.Nom_Joueur);
                j.Add("@Prenom_Joueur", model.Prenom_Joueur);
                j.Add("@Mail_Joueur", model.Mail_Joueur);
                j.Add("Equipe_Joueur", model.Equipe_Joueur);
                j.Add("@ID_Joueur", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.Joueur_Insert", j, commandType: CommandType.StoredProcedure);

                model.Id = j.Get<int>("@ID_Joueur");

                return model;


            }




        }

        public List<Joueur> GetALLJoueur()
        {

            List<Joueur> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db))) 
            {
                output = connection.Query<Joueur>("dbo.Joueur_GetALL").ToList();

            }

            return output;

        }
    }
}
