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
    public partial class Accueil : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        
        public Accueil()
        {
            
            InitializeComponent();
            player.URL = "";
        }

        private void jouerButton_Click(object sender, EventArgs e)
        {
           

            CreationTournoi frm = new CreationTournoi();
    

            frm.Show();
           

        }

        private void infosButton_Click(object sender, EventArgs e)
        {

            infos frm = new infos();


            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            PastGames pg = new PastGames();


            pg.Show();

        }

        private void musicButton_Click(object sender, EventArgs e)
        {
            if(player.URL == "")   
          {
                player.URL = "johnny.MP3";
                player.controls.play();
            }

            player.controls.play();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            player.controls.pause();

        }
    }
}
