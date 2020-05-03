﻿using FIFALib.Models;
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

        public void CreerCompet(Competition comp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveComp(connection, comp);
                SaveCompEquipes(connection, comp);

                SaveCompRounds(connection, comp);


            }



        }





        private void SaveComp(IDbConnection connection, Competition comp)
        {

            var c = new DynamicParameters();

            c.Add("@Comp_Nom", comp.NomCompetition);
            c.Add("@ID_Comp", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


            connection.Execute("dbo.spComp_Insert", c, commandType: CommandType.StoredProcedure);

            comp.Id = c.Get<int>("@ID_Comp");


        }


        private void SaveCompEquipes(IDbConnection connection, Competition comp)
        {
            foreach (Equipe ei in comp.EquipeInscrites)
            {
               var c = new DynamicParameters();
                c.Add("@ID_Competition", comp.Id);
                c.Add("@ID_Equipe", ei.Id);
                c.Add("@ID_CompetitionEnt", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spCompEntry_Insert", c, commandType: CommandType.StoredProcedure);

            }



        }


        private void SaveCompRounds(IDbConnection connection, Competition comp)
        {
            foreach (List<Match> round in comp.Rounds)
            {

                foreach (Match match in round)
                {
                    var c = new DynamicParameters();
                    c.Add("@ID_Comp", comp.Id);
                    c.Add("@Match_Round", match.RoundMatch);
                    c.Add("@ID_Match", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                    connection.Execute("dbo.Match_Insert", c, commandType: CommandType.StoredProcedure);

                    match.Id = c.Get<int>("@ID_Match");


                    foreach (MatchEntry entry in match.Entries)
                    {

                         c = new DynamicParameters();

                        c.Add("@ID_Match", match.Id);
                        c.Add("@ID_MatchParent", entry.MatchParent);
                        c.Add("@ID_EquipeJouant", entry.EquipeJouant.Id);
                        c.Add("@ID_MatchEntry", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                        connection.Execute("dbo.MatchEntry_Insert", c, commandType: CommandType.StoredProcedure);

                        entry.Id = c.Get<int>("@ID_MatchEntry");



                    }
                }


            }


        }

        public Equipe CreerEquipe(Equipe model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {



                var j = new DynamicParameters();

                j.Add("@Nom_Equipe", model.Nom_Equipe);
                j.Add("@ID_Equipe", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spEquipes_Insert", j, commandType: CommandType.StoredProcedure);

                model.Id = j.Get<int>("@ID_Equipe");


                foreach(Joueur je in model.MembreEquipe )
                {
                    j =  new DynamicParameters();
                    j.Add("@ID_Equipe", model.Id);
                    j.Add("@ID_Joueur", je.Id);


                    connection.Execute("dbo.spMembreEquipe_Insert", j, commandType: CommandType.StoredProcedure);

                }

                return model;


            }










        }

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

        public List<Equipe> GetTeam_ALL()
        {


            List<Equipe> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<Equipe>("dbo.spEquipe_GetALL").ToList();


                foreach( Equipe equipe in output)
                {
                    var j = new DynamicParameters();

                    j.Add("@ID_Equipe", equipe.Id);

                    equipe.MembreEquipe = connection.Query<Joueur>("dbo.spME_GetParEquipe", j, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;


            
        }
    }
}
