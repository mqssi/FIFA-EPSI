using FIFALib;
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
using WMPLib;

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

            competition.CompetitionComplete += Competition_CompetitionComplete;
        
            LienListe();

            LoadFormData();
            LoadRounds();
        }

        private void Competition_CompetitionComplete(object sender, DateTime e)
        {


            Recap frmRecap = new Recap(this.competition);
            frmRecap.Show();

            this.Close();

        }

        private void LoadFormData()
        {

            nomCompetitionLabel.Text = competition.Comp_Nom;


        }

        private void LienListe()
        {

            
            roundDropdown.DataSource = rounds;
            matchUpListBox.DataSource = Selectedmatch;
            matchUpListBox.DisplayMember = "DisplayName";

        }


        



        private void LoadRounds()
        {

            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;
            foreach(List<Match>matches in competition.Rounds)
            {

                if(matches.First().Match_Round > currRound)
                {
                    currRound = matches.First().Match_Round;
                    rounds.Add(currRound);

                }

            }

            LoadMatchs(1);
        }

      
        
        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchs((int)roundDropdown.SelectedItem);


        }



        private void LoadMatchs(int round)
        {

           

            foreach (List<Match> matches in competition.Rounds)
            {

                if(matches.First().Match_Round == round)
                {
                    Selectedmatch.Clear();
                    foreach (Match m in matches)
                    {

                        if (m.Winner == null || !unplayedButton.Checked)
                        {
                            Selectedmatch.Add(m);

                        }
                        

                    }
                    

                }


            }
            if(Selectedmatch.Count > 0) { 
            LoadMatch(Selectedmatch.First());
            }

            DisplayMatchInfo();
        }



        private void DisplayMatchInfo()
        {

            bool isVisible = (Selectedmatch.Count > 0);

            equipe1Label.Visible = isVisible;
            scoreEquipe1Value.Visible = isVisible;
            scoreEquipe1Label.Visible = isVisible;


            equipe2Label.Visible = isVisible;
            scoreEquipe2Value.Visible = isVisible;
            scoreEquipe2Label.Visible = isVisible;

            scoreRoundButton.Visible = isVisible;
            vsLabel.Visible = isVisible;


        }

       private void LoadMatch(Match m)
        {
            if (m == null)
            {
                
                return;
            }
            else
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {

                    if (i == 0)
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

                    if (i == 1)
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
        }


        private void matchUpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadMatch((Match)matchUpListBox.SelectedItem);
        }

        private void unplayedButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchs((int)roundDropdown.SelectedItem);
        }

        private string ValidateData()
        {

            string output = "";

            double equipe1Score = 0;
            double equipe2Score = 0;

            bool scoreOneValid = double.TryParse(scoreEquipe1Value.Text, out equipe1Score);
            bool scoreTwoValid = double.TryParse(scoreEquipe2Value.Text, out equipe2Score);

            if(!scoreOneValid )
            {

                output = "Le score de la première équipe est invalide";
            }

           else if (!scoreTwoValid)
            {

                output = "Le score de la deuxième équipe est invalide";
            }

            else if (equipe1Score == 0 && equipe2Score ==0)
            {

                output = "Les match nuls sont impossibles, il faut désigner un vainqueur";
            
            }

            else if (equipe1Score == equipe2Score)
            {

                output = "Les match nuls sont impossibles, il faut désigner un vainqueur";
            }

            return output;
        }


        private void scoreRoundButton_Click(object sender, EventArgs e)
        {

            string errorMessage = ValidateData();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Erreur de saisie : { errorMessage  } ");
                return;
            }


            Match m = (Match)matchUpListBox.SelectedItem;
            double equipe1Score = 0;
            double equipe2Score = 0;
            for (int i = 0; i < m.Entries.Count; i++)
            {

                if (i == 0)
                {
                    if (m.Entries[0].EquipeJouant != null)
                    {

                    
                        bool scoreValid = double.TryParse(scoreEquipe1Value.Text, out equipe1Score);

                        if (scoreValid) 
                        {
                            m.Entries[0].Score = equipe1Score;

                        }
                        else
                        {

                            MessageBox.Show("Entrée invalide");
                            return;
                        }

                    }




                }

                if (i == 1)
                {

                    if (m.Entries[1].EquipeJouant != null)
                    {

                        equipe2Label.Text = m.Entries[0].EquipeJouant.Nom_Equipe;
                       
                        bool scoreValid = double.TryParse(scoreEquipe2Value.Text, out equipe2Score);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = equipe2Score;
                        }
                        else
                        {

                            MessageBox.Show("Entrée invalide");
                            return;
                        }



                    }




                }




            }

            //if(equipe1Score > equipe2Score)
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

            //foreach (List<Match> round in competition.Rounds)
            //{

            //    foreach (Match rm in round)
            //    {
            //        foreach (MatchEntry me in rm.Entries)
            //        {

            //            if(me.MatchParent != null) 
            //            { 

            //                if(me.MatchParent.ID_Match == m.ID_Match)
            //                {

            //                    me.EquipeJouant = m.Winner;
            //                    GlobalConfig.Connection.UpdateMatch(rm);
            //                }

            //            }
            //        }

            //    }

            //}


            try 
            { 
            CompLogic.UpdateCompResults(competition);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur detectée : {ex.Message} ");
                return;

            }


            MessageBox.Show( $"Match terminé: le gagnant est l'équipe { m.Winner.Nom_Equipe } ");

            //MessageBox.Show( $"Match terminé: le gagnant est l'équipe { m.Winner.Nom_Equipe } composée de { m.Winner.MembreEquipe }");
            LoadMatchs((int)roundDropdown.SelectedItem);

            //GlobalConfig.Connection.UpdateMatch(m);
        }
    }
}
