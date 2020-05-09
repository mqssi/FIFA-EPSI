using FIFALib.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib
{
     public class CompLogic
    {



        public static void CreerRounds(Competition comp)
        {

            List<Equipe> randomizedTeams = Randomizer(comp.EquipeInscrites);
            int rounds = GetNombreRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);
            
            comp.Rounds.Add(CreerPremierRound(byes, randomizedTeams));
            CreerAutresRounds(comp, rounds);
           

        }

        private static void CreerAutresRounds(Competition comp , int rounds)
        {
            int round = 2;

            List<Match> roundPrecedent = comp.Rounds[0];
            List<Match> roundActuel = new List<Match>();
            Match matchActuel = new Match();

            while(round <= rounds)
            {
                foreach(Match match in roundPrecedent)
                {
                    matchActuel.Entries.Add(new MatchEntry { MatchParent = match });
                    if(matchActuel.Entries.Count > 1)
                    {
                        matchActuel.Match_Round = round;
                        roundActuel.Add(matchActuel);
                        matchActuel = new Match();

                    }

                }


                comp.Rounds.Add(roundActuel);
                roundPrecedent = roundActuel;

                roundActuel = new List<Match>();
                round += 1;

            }


        }

        private static List<Match> CreerPremierRound(int byes, List<Equipe> equipes)
        {


            List<Match> output = new List<Match>();
            Match curr = new Match();
            foreach( Equipe  equipe in equipes )
            {
                curr.Entries.Add(new MatchEntry { EquipeJouant = equipe });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.Match_Round = 1;
                    output.Add(curr);
                    curr = new Match();
                    if (byes > 0)
                    {

                        byes -= 1;
                    }
                }



            }

            return output;

        }

        private static int NumberOfByes(int rounds, int nombreEquipe)
        {

            int output = 0;
            int totalEquipe = 1;

            for (int i = 1; i<= rounds; i++)
            {

                totalEquipe *= 2;

            }

            output = totalEquipe - nombreEquipe;
            return output;
        }

        private static int GetNombreRounds(int equipeCount)
        {

            int output = 1;
            int val = 2;

            while (val < equipeCount)
            {
                output += 1;
                val *= 2;



            }
            return output;
        }

        private static List<Equipe> Randomizer(List<Equipe> equipes)
        {
            // cards.OrderBy(a => Guid.NewGuid()).ToList();
            return equipes.OrderBy(a => Guid.NewGuid()).ToList();
        }


        public static void UpdateCompResults(Competition model)
        {
            List<Match> toScore = new List<Match>();
            foreach (List<Match> round in model.Rounds)
            {
                foreach (Match rm in round)
                {
                    if ( rm.Winner == null &&  (rm.Entries.Any(x=> x.Score != 0) || rm.Entries.Count ==1))
                    {

                        toScore.Add(rm);

                    }


                }


            }


            MarkWinnerInMatchs(toScore);


            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatch(x));
            //if (equipe1Score > equipe2Score)
            //{

            //    m.Winner = m.Entries[0].EquipeJouant;

            //}
            //else if (equipe2Score > equipe1Score)
            //{

            //    m.Winner = m.Entries[1].EquipeJouant;
            //}
            //else
            //{

            //    MessageBox.Show("Il faut un gagnant, pas de match nul possible");
            //}



            

           // GlobalConfig.Connection.UpdateMatch(m);


        }

        private static void AdvanceWinners(List<Match> models, Competition competition)
        {
            foreach (Match m in models)
            {


                foreach (List<Match> round in competition.Rounds)
                {

                    foreach (Match rm in round)
                    {
                        foreach (MatchEntry me in rm.Entries)
                        {

                            if (me.MatchParent != null)
                            {

                                if (me.MatchParent.ID_Match == m.ID_Match)
                                {

                                    me.EquipeJouant = m.Winner;
                                    GlobalConfig.Connection.UpdateMatch(rm);
                                }

                            }
                        }

                    }

                }

            }
        }

        private static void MarkWinnerInMatchs(List<Match> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (Match m in models)
            {

                if(m.Entries.Count == 1)
                {

                    m.Winner = m.Entries[0].EquipeJouant;
                    continue;
                }

                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {

                        m.Winner = m.Entries[0].EquipeJouant;
                    }
                    else if(m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].EquipeJouant;

                    }
                    else
                    {

                        throw new Exception("Pas de matchs nuls. ");
                    }
                }
                else
                {



                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {

                        m.Winner = m.Entries[0].EquipeJouant;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].EquipeJouant;

                    }
                    else
                    {

                        throw new Exception("Pas de matchs nuls. ");
                    }







                }
            }
            //if (equipe1Score > equipe2Score)
            //{

            //    m.Winner = m.Entries[0].EquipeJouant;

            //}
            //else if (equipe2Score > equipe1Score)
            //{

            //    m.Winner = m.Entries[1].EquipeJouant;
            //}
            //else
            //{

            //    MessageBox.Show("Il faut un gagnant, pas de match nul possible");
            //}

        }


    }
}
