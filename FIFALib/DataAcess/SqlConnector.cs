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

        public void CreerCompet(Competition comp)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveComp(connection, comp);
                SaveCompEquipes(connection, comp);
                SaveCompRounds(connection, comp);

                CompLogic.UpdateCompResults(comp);
            }



        }





        private void SaveComp(IDbConnection connection, Competition comp)
        {

            var c = new DynamicParameters();

                c.Add("@Comp_Nom", comp.Comp_Nom);
                c.Add("@ID_Competition", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spComp_Insert", c, commandType: CommandType.StoredProcedure);

                comp.ID_Competition = c.Get<int>("@ID_Competition");



        }


        private void SaveCompEquipes(IDbConnection connection, Competition comp)
        {
            foreach (Equipe tm in comp.EquipeInscrites)
            {
               var c = new DynamicParameters();
                c.Add("@ID_Competition", comp.ID_Competition);
                c.Add("@ID_Equipe", tm.ID_Equipe);
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
                    c.Add("@ID_Competition", comp.ID_Competition);
                    c.Add("@Match_Round", match.Match_Round);
                    c.Add("@ID_Match", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                    connection.Execute("dbo.Match_Insert", c, commandType: CommandType.StoredProcedure);

                    match.ID_Match = c.Get<int>("@ID_Match");


                    foreach (MatchEntry entry in match.Entries)
                    {

                         c = new DynamicParameters();

                        c.Add("@ID_Match", match.ID_Match);
                        


                        if (entry.MatchParent == null)
                        {

                            c.Add("@ID_MatchParent", null);

                        }
                        else
                        {
                            c.Add("@ID_MatchParent", entry.MatchParent.ID_Match);

                        }


                        if (entry.EquipeJouant == null)
                        {

                            c.Add("@ID_EquipeJouant", null);

                        }
                        else
                        {
                            c.Add("@ID_EquipeJouant", entry.EquipeJouant.ID_Equipe);

                        }
                        c.Add("@ID_MatchEntry", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                        connection.Execute("dbo.MatchEntry_Insert", c, commandType: CommandType.StoredProcedure);

                        entry.ID_MatchEntry = c.Get<int>("@ID_MatchEntry");



                    }
                }


            }


        }

        public void CreerEquipe(Equipe model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {



                var j = new DynamicParameters();

                j.Add("@Nom_Equipe", model.Nom_Equipe);
                j.Add("@ID_Equipe", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spEquipes_Insert", j, commandType: CommandType.StoredProcedure);

                model.ID_Equipe = j.Get<int>("@ID_Equipe");


                foreach(Joueur je in model.MembreEquipe )
                {
                    j =  new DynamicParameters();
                    j.Add("@ID_Equipe", model.ID_Equipe);
                    j.Add("@ID_Joueur", je.Id);


                    connection.Execute("dbo.spMembreEquipe_Insert", j, commandType: CommandType.StoredProcedure);

                }

                


            }










        }

        /// <summary>
        /// Sauvegarde un joueur dans la base de données
        /// </summary>
        /// <param name="model"> Les informations concernants un joueur</param>
        /// <returns>Le Pseudo, Nom, Prénom, Mail et l'Id du Joueur</returns>
        public void CreerJoueur(Joueur model)
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

                    j.Add("@ID_Equipe", equipe.ID_Equipe);

                    equipe.MembreEquipe = connection.Query<Joueur>("dbo.spME_GetParEquipe", j, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;


            
        }

        public List<Competition> Get_CompALL()
        {

            List<Competition> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<Competition>("dbo.Comp_GetALL").ToList();
                var j = new DynamicParameters();
                foreach (Competition c in output)
                {

                    j = new DynamicParameters();

                    j.Add("@ID_Competition", c.ID_Competition);


                    c.EquipeInscrites = connection.Query<Equipe>("dbo.spEquipe_GetByComp",j, commandType: CommandType.StoredProcedure).ToList();


                    foreach (Equipe equipe in c.EquipeInscrites)
                    {
                         j = new DynamicParameters();

                        j.Add("@ID_Equipe", equipe.ID_Equipe);

                        equipe.MembreEquipe = connection.Query<Joueur>("dbo.spME_GetParEquipe", j, commandType: CommandType.StoredProcedure).ToList();
                    }

                     j = new DynamicParameters();

                    j.Add("@ID_Competition", c.ID_Competition);

                    List<Match> matches = connection.Query<Match>("dbo.spMatch_GetByComp", j, commandType: CommandType.StoredProcedure).ToList();

                    foreach(Match m in matches)
                    {

                        j = new DynamicParameters();

                        j.Add("@ID_Match", m.ID_Match);

                        m.Entries = connection.Query<MatchEntry>("dbo.MatchEntry_GetByMatch", j, commandType: CommandType.StoredProcedure).ToList();


                        List<Equipe> allTeams = GetTeam_ALL();

                        if(m.ID_Gagnant > 0)
                        {

                            m.Winner = allTeams.Where(x => x.ID_Equipe == m.ID_Gagnant).First();
                        }

                        foreach (var me in m.Entries)
                        {
                            if (me.ID_EquipeJouant > 0)
                            {

                                me.EquipeJouant = allTeams.Where(x => x.ID_Equipe == me.ID_EquipeJouant).First();

                            }
                            if (me.ID_MatchParent > 0)
                            {
                                me.MatchParent = matches.Where(x => x.ID_Match == me.ID_MatchParent).First();


                            }
                        }

                    }

                    List<Match> currRow = new List<Match>();
                    int currentRound = 1;
                    foreach (Match m in matches)
                    {

                        if(m.Match_Round > currentRound)
                        {
                            c.Rounds.Add(currRow);
                            currRow = new List<Match>();
                            currentRound += 1;

                        }
                        currRow.Add(m);
                    }

                    c.Rounds.Add(currRow);

                }

            }

            return output;


        }

        public void UpdateMatch(Match model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                // spMatch_Update @ID_Match, @ID_Gagnant

                var c = new DynamicParameters();
                if(model.Winner != null) { 

                c.Add("@ID_Match", model.ID_Match);
                c.Add("@ID_Gagnant", model.ID_Gagnant);

                connection.Execute("dbo.spMatch_Update", c, commandType: CommandType.StoredProcedure);
                }

                // spMatchEntry_Update @ID_MatchEntry @ID_EquipeJouant @Score

                foreach (MatchEntry me in model.Entries)
                {


                    c = new DynamicParameters();
                    if(me.EquipeJouant!= null) { 
                    c.Add("@ID_MatchEntry", me.ID_MatchEntry);
                    c.Add("@ID_EquipeJouant", me.EquipeJouant.ID_Equipe);
                    c.Add("@Score", me.Score);

                    connection.Execute("dbo.spMatchEntry_Update", c, commandType: CommandType.StoredProcedure);
                    }

                }


            }
        }
    }
}
