using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace What_s_in_my_fridge
{
    public partial class frmAcceuil : Form
    {
        private System.Windows.Forms.Timer timer;
        private int progressValue;

        public frmAcceuil()
        {
            InitializeComponent();
            InitializeTimer();
            FormClosed += Acceuil_FormClosed;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void Acceuil_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5;
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (progressValue >= 100)
            {
                timer.Stop();
                Close();
            }
            else
            {
                progressValue++;
                progressBar1.Value = progressValue;
                progressBar1.Invalidate(); // Force le rafraîchissement de la barre de progression
                label1.Text = $"{progressValue}%"; // Mettre à jour le texte de label1 avec le pourcentage de progression
            }
        }

 


        private void Acceuil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread newThread = new Thread(OpenIngredientsForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void OpenIngredientsForm()
        {
            Application.Run(new frmIngredients());
        }
        private void pcb_Acceuil_Click(object sender, EventArgs e)
        {
            Form f = new frmIngredients();
            f.ShowDialog();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}