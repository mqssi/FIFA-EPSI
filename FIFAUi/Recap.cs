using FIFALib.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            dateLabel.Text = model.DateCompetition.ToString();


           

            foreach (Joueur j in winners.MembreEquipe)
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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File |* .pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var RED = new BaseColor(255, 0, 0);
                    var BLACK = new BaseColor(0, 0, 0);
                    var Calibri8 = FontFactory.GetFont("Tahoma", 18, RED);
                    var Calibri7 = FontFactory.GetFont("Tahoma", 12, BLACK);

                    Document doc = new Document(PageSize.A4, 120, 50, 20, 50);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        
                        Paragraph paragraph = new Paragraph();
                     
                        paragraph.SetLeading(1.0f, 3.0f);
                        paragraph.Add(("Récapitulatif généré le  :" + DateTime.Now.ToString("dd/MM/yyyy")).Replace('-', '/'));


                        doc.Open();
                        doc.Add(new Paragraph(" Récapitulatif CROSSED_EPSI", Calibri8));
                        doc.Add(paragraph);
                        doc.Add(new Paragraph(" Compétition crée le  :  " + dateLabel.Text, Calibri7));
                        doc.Add(new Paragraph(" Compétition :  " + nomCompetitionLabel.Text, Calibri7));
                        doc.Add(new Paragraph(" Gagnant :  " + gagnantLabel.Text, Calibri7));
                        doc.Add(new Paragraph(" MVP :  " + joueursLabel.Text, Calibri7));
                        doc.Add(new Paragraph(" Finaliste :  " + runnerUpLabel.Text, Calibri7));
                        
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                        doc.Close();
                    }



                }

            }
        }
    }
}
