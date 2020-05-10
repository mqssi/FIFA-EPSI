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
    public partial class Recap : Form
    {

        
        public Recap(Competition competition)
        {
            InitializeComponent();
            LoadFormData(competition);

        }

        private void LoadFormData(Competition model)
        {

            Equipe winners = model.Rounds.Last().First().Winner;
            Equipe runnerUp = model.Rounds.Last().First().Entries.Where(x => x.EquipeJouant != winners).First().EquipeJouant;
            //Equipe all = model.EquipeInscrites.First().Nom_Equipe;

            nomCompetitionLabel.Text = model.Comp_Nom;
            gagnantLabel.Text = winners.Nom_Equipe;
            runnerUpLabel.Text = runnerUp.Nom_Equipe;
            
            foreach(Joueur j in winners.MembreEquipe)
            {

                joueursLabel.Text = j.Pseudo_Joueur;
             
            }
            
            foreach (Joueur j in runnerUp.MembreEquipe)
            {

                joueurLabel2.Text = j.Pseudo_Joueur;

            }



            string messageWin = "";


            messageWin = $"Les gagnants {model.Comp_Nom} et {winners.Nom_Equipe}";

           

        }

        private void pdfButton_Click(object sender, EventArgs e)
        {

        }
    }
}
