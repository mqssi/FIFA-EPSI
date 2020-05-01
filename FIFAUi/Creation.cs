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
        public Creation()
        {
            InitializeComponent();
        }


















        private void creationJoueurButton_Click(object sender, EventArgs e)
        {
            if (ValiderForm())
            {

                Joueur model = new Joueur(
                    pseudoJoueurValue.Text, 
                    nomJoueurValue.Text, 
                    prenomJoueurValue.Text, 
                    mailJoueurValue.Text, 
                    equipeJoueurValue.Text);
            
                  GlobalConfig.Connection.CreerJoueur(model);
                

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
    }
}
