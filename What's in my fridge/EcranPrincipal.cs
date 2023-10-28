using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace What_s_in_my_fridge
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
            InitializeProgressBar();
            InitializeTimer();
        }

        string chcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            chcon = chcon + path + @"\\baseFrigo.accdb";
            connec.ConnectionString = chcon;
            chargement_ds();
        }

        public void chargement_ds()
        {
            connec.Open();
            DataTable data = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow row in data.Rows)
            {
                string requete = "SELECT * FROM " + row[2].ToString();
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                da.Fill(ds, row[2].ToString());
            }
            connec.Close();
        }

        private ProgressBar progressBar;
        private Timer timer;
        private int progressValue;

        private void InitializeProgressBar()
        {
            progressBar = new ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.ForeColor = Color.Green;
            progressBar.BackColor = Color.White;
            progressBar.Style = ProgressBarStyle.Continuous;

            // Calculer les coordonnées pour centrer la barre de progression en bas de l'écran
            int progressBarWidth = Width - 40; // Largeur de la barre de progression
            int progressBarHeight = 20; // Hauteur de la barre de progression
            int progressBarX = (Width - progressBarWidth) / 2; // Coordonnée X pour centrer la barre horizontalement
            int progressBarY = Height - progressBarHeight - 50; // Coordonnée Y pour placer la barre en bas de l'écran

            progressBar.SetBounds(progressBarX, progressBarY, progressBarWidth, progressBarHeight);
            Controls.Add(progressBar);
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (progressValue >= 100)
            {
                timer.Stop();
                MessageBox.Show("Chargement terminé !");
            }
            else
            {
                progressValue++;
                progressBar.Value = progressValue;
                progressBar.Update(); // Mise à jour de la barre de progression
            }
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
