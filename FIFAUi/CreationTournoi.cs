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

namespace FIFAUi
{
    public partial class CreationTournoi : Form, IEquipeRequester
    {

        List<Equipe> EquipesDispo = GlobalConfig.Connection.GetTeam_ALL();
        List<Equipe> EquipesSelected = new List<Equipe>();


        public CreationTournoi()
        {
            InitializeComponent();
            LienListe();
        }



        private void LienListe()
        {
            selectEquipeDropdown.DataSource = null;
            selectEquipeDropdown.DataSource = EquipesDispo;
            selectEquipeDropdown.DisplayMember = "Nom_Equipe";

            equipesTournoiListBox.DataSource = null;
            equipesTournoiListBox.DataSource = EquipesSelected;
            equipesTournoiListBox.DisplayMember = "Nom_Equipe";

        }

        private void ajouterEquipeTournoiButton_Click(object sender, EventArgs e)
        {
            Equipe team = (Equipe)selectEquipeDropdown.SelectedItem;


            if (team != null)
            {
                EquipesDispo.Remove(team);
                EquipesSelected.Add(team);

                LienListe();
            }
        }

        private void retirerEquipeButton_Click(object sender, EventArgs e)
        {
            Equipe team = (Equipe)equipesTournoiListBox.SelectedItem;



            if (team != null)
            {

                EquipesSelected.Remove(team);
                EquipesDispo.Add(team);

                LienListe();
            }
            else if (team == null)
            {

                MessageBox.Show("Il faut selectionner une équipe");

            }
        }

        public void EquipeComplete(Equipe model)
        {
            EquipesSelected.Add(model);
            LienListe();
        }

        private void createEquipelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Creation frm = new Creation(this);

            frm.Show();
        }

        private void creationTournoiButton_Click(object sender, EventArgs e)
        {

            Competition competition = new Competition();
            competition.EquipeInscrites = EquipesSelected;
            competition.Comp_Nom = nomTournoiValue.Text;
            competition.DateCompetition = DateTime.Now;

            //créer matchups
            //TournoiViewer frm = new TournoiViewer(competition);
            //frm.Show();
            CompLogic.CreerRounds(competition);


            GlobalConfig.Connection.CreerCompet(competition);

            
            TournoiViewer frm2 = new TournoiViewer(competition);
            frm2.Show();
            this.Close();


        }


    }
}
