using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_s_in_my_fridge
{
    public partial class frmNotation : Form
    {
        string chcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        OleDbConnection connec = new OleDbConnection();

        public frmNotation()
        {
            InitializeComponent();
        }
        int codeCetteRecette;
        public frmNotation(int codeRec)
        {
            InitializeComponent();
            codeCetteRecette = codeRec;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNotation_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            chcon = chcon + path + @"\\baseFrigov2023.mdb";
            connec.ConnectionString = chcon;
        }

        private void lblValider_Click(object sender, EventArgs e)
        {
            /*connec.Open();
            OleDbCommand da1 = new OleDbCommand("SELECT MAX(CodeAvis) FROM tblAvis", connec);
            int avis = int.Parse(da1.ExecuteScalar().ToString())+1;
            int note=1;
            string requete = "INSERT INTO tblAvis (codeAvis, Note, pseudo, codeRecette, avis) VALUES (";
            requete += avis + ",";
            requete += note + ",'";
            requete += txtPseudo.Text + "',";
            requete += codeCetteRecette + ",'";
            requete += txtAvis.Text + "')";
            MessageBox.Show(requete);



            OleDbCommand da = new OleDbCommand(requete,connec);
            int nb_linges = (int)da.ExecuteNonQuery();
            MessageBox.Show(nb_linges + " ajoutée");
            connec.Close();*/
            MessageBox.Show("Votre avis a bien été enregistrer");
        }
    }
}
