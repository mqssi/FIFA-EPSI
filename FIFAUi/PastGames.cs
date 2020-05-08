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
    public partial class PastGames : Form
    {

        List<Competition> competitions = GlobalConfig.Connection.Get_CompALL();
        public PastGames()
        {
            InitializeComponent();
            LienListe();
        }



        private void LienListe()
        {

            LoadCompsDropDown.DataSource = competitions;
            LoadCompsDropDown.DisplayMember = "Comp_Nom";


        }

        private void LoadCompButton_Click(object sender, EventArgs e)
        {
            Competition comp = (Competition)LoadCompsDropDown.SelectedItem;
            TournoiViewer frm = new TournoiViewer(comp);
            frm.Show();
        }
    }
}
