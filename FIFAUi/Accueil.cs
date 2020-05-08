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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
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
    }
}
