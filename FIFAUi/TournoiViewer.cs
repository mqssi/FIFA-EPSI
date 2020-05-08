using FIFALib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAUi
{
    public partial class TournoiViewer : Form
    {

        private Competition competition;

        BindingList<Match> Selectedmatch = new BindingList<Match>();
        BindingList<int> rounds = new BindingList<int>();

   
        public TournoiViewer(Competition competitionModel)
        {
            InitializeComponent();

            competition = competitionModel;
        
            LienListe();

            LoadFormData();
            LoadRounds();
        }

        private void LoadFormData()
        {

            nomCompetitionLabel.Text = competition.NomCompetition;


        }

        private void LienListe()
        {

            
            roundDropdown.DataSource = rounds;
            matchUpListBox.DataSource = Selectedmatch;
            matchUpListBox.DisplayMember = "DisplayName";

        }


        



        private void LoadRounds()
        {

            //rounds = new BindingList<int>();
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;
            foreach(List<Match>matches in competition.Rounds)
            {

                if(matches.First().RoundMatch > currRound)
                {
                    currRound = matches.First().RoundMatch;
                    rounds.Add(currRound);

                }

            }

            //LoadMatchs(1);
        }

        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchs((int)roundDropdown.SelectedItem);


        }



        private void LoadMatchs(int round)
        {

           

            foreach (List<Match> matches in competition.Rounds)
            {

                if(matches.First().RoundMatch == round)
                {
                    Selectedmatch.Clear();
                    foreach (Match m in matches)
                    {
                        Selectedmatch.Add(m);

                    }
                    

                }


            }

            LoadMatch(Selectedmatch.First());

        }


       public void LoadMatch(Match m)
        {

           

            for(int i = 0; i< m.Entries.Count; i++)
            {

                if(i == 0)
                {
                    if (m.Entries[0].EquipeJouant != null)
                    {

                        equipe1Label.Text = m.Entries[0].EquipeJouant.Nom_Equipe;
                        scoreEquipe1Value.Text = m.Entries[0].Score.ToString();


                        equipe2Label.Text = "<exempt>";
                        scoreEquipe2Value.Text = "0";
                    }
                    else
                    {
                        equipe1Label.Text = "Pas encore définis";
                        scoreEquipe1Value.Text = "";
                    }



                }

                if(i == 1)
                {

                    if (m.Entries[1].EquipeJouant != null)
                    {

                        equipe2Label.Text = m.Entries[1].EquipeJouant.Nom_Equipe;
                        scoreEquipe2Value.Text = m.Entries[1].Score.ToString();

                    }
                    else
                    {
                        equipe2Label.Text = "Pas encore définis";
                        scoreEquipe2Value.Text = "";
                    }



                }

            }

        }


        private void matchUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadMatch((Match)matchUpListBox.SelectedItem);
        }
    }
}
