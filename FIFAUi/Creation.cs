using FIFALib;
using FIFALib.DataAcess;
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
    public partial class Creation : Form
    {


        private List<Joueur> JoueursDispo = GlobalConfig.Connection.GetALLJoueur();
        private List<Joueur> JoueursSelect = new List<Joueur>();
        private IEquipeRequester CallingForm;

        public Creation(IEquipeRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
            // CreerDataExemple();
            
            LienListe();
        }



        private void CreerDataExemple()
        {

            JoueursDispo.Add(new Joueur { Pseudo_Joueur = "av3k" });
            JoueursDispo.Add(new Joueur { Pseudo_Joueur = "fatal1ty" });
            JoueursDispo.Add(new Joueur { Pseudo_Joueur = "rapha" });


            JoueursSelect.Add(new Joueur { Pseudo_Joueur = "COOLLER" });
            JoueursSelect.Add(new Joueur { Pseudo_Joueur = "cYphEr" });


        }



        private void LienListe()
        {

            joueursTournoiDropdown.DataSource = null;
            joueursTournoiDropdown.DataSource = JoueursDispo;
            joueursTournoiDropdown.DisplayMember = "Pseudo_Joueur";

            joueursListBox.DataSource = null;
            joueursListBox.DataSource = JoueursSelect;
            joueursListBox.DisplayMember = "Pseudo_Joueur";

        }






        private void creationJoueurButton_Click(object sender, EventArgs e)
        {
            if (ValiderForm())
            {

                Joueur j = new Joueur(
                    pseudoJoueurValue.Text, 
                    nomJoueurValue.Text, 
                    prenomJoueurValue.Text, 
                    mailJoueurValue.Text,
                    equipeJoueurValue.Text);
            
                  GlobalConfig.Connection.CreerJoueur(j);
                JoueursSelect.Add(j);

                LienListe();

                pseudoJoueurValue.Text = "";
                nomJoueurValue.Text = "";
                prenomJoueurValue.Text = "";
                mailJoueurValue.Text = "";
                equipeJoueurValue.Text = "";
                MessageBox.Show("Le Joueur a été ajouté");


            }
            else
            {

                MessageBox.Show("Le formulaire est mal rempli");

            }


        }


        private bool ValiderForm()
        {

            bool output = true;
            

            if(pseudoJoueurValue.Text.Length == 0 || pseudoJoueurValue.Text=="")
            {

                output = false;

            }

            if (nomJoueurValue.Text.Length == 0)
            {

                output = false;

            }
            if (prenomJoueurValue.Text.Length == 0)
            {

                output = false;


            }
            if (mailJoueurValue.Text.Length == 0)
            {

                output = false;

            }
            if (equipeJoueurValue.Text.Length == 0)
            {

                output = false;

            }



            return output;

        }

        private void ajouterJoueurTournoiButton_Click(object sender, EventArgs e)
        {

            Joueur j = (Joueur)joueursTournoiDropdown.SelectedItem;
            
            
            if (j != null)
            {
                JoueursDispo.Remove(j);
                JoueursSelect.Add(j);

                LienListe();
            }
        }

        private void retirerJoueurButton_Click(object sender, EventArgs e)
        {

            Joueur j = (Joueur)joueursListBox.SelectedItem;



            if (j != null)
            {

                JoueursSelect.Remove(j);
                JoueursDispo.Add(j);

                LienListe();
            }
            else if(j == null)
            {

                MessageBox.Show("Il faut selectionner un joueur");

            }
        }

        private void creationEquipeButton_Click(object sender, EventArgs e)
        {
            Equipe t = new Equipe();
            t.Nom_Equipe = nomEquipeValue.Text;
            t.MembreEquipe = JoueursSelect;
            GlobalConfig.Connection.CreerEquipe(t);
            CallingForm.EquipeComplete(t);
            this.Close();


        }
    }
}
