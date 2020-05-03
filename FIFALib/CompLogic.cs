using FIFALib.Models;
using System;
using System.Collections.Generic;
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
                        matchActuel.RoundMatch = round;
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
                    curr.RoundMatch = 1;
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

            int output = -1;
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
    }
}
