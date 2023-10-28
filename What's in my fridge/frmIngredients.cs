using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_s_in_my_fridge
{
    public partial class frmIngredients : Form
    {
        string chcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        OleDbConnection connec = new OleDbConnection();
        DataSet ds = new DataSet();
        List<int> choix_ingredients = new List<int>();
        List<int> choix_categories = new List<int>();
        int valeur;
        public frmIngredients()
        {
            InitializeComponent();
        }
        private void Ingredients_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            chcon = chcon + path + @"\\baseFrigov2023.mdb";
            connec.ConnectionString = chcon;
            chargement_ds(ds, connec);
            chargement_famille(ds);
            chargement_categories(ds);
            lblmin.Text = "€";
            lblmoy.Text = "€€";
            lblmax.Text = "€€€";
        }
        private void chargement_ds(DataSet d, OleDbConnection connec)
        {
            connec.Open();
            DataTable data = connec.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow row in data.Rows)
            {
                string requete = "SELECT * FROM " + row[2].ToString();
                OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
                da.Fill(d, row[2].ToString());
            }
            connec.Close();
        }

        private void chargement_categories(DataSet ds)
        {
            int j=0; int i=0;
            foreach (DataRow row in ds.Tables["Catégories"].Rows)
            {
                CheckBox cb = new CheckBox();
                cb.Text = row["libCategorie"].ToString();
                cb.Tag = row["codeCategorie"];
                cb.Font = new System.Drawing.Font("Verdana", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cb.BringToFront();
                cb.ForeColor = System.Drawing.Color.White;
                cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged_entree);
                gb_categories.Controls.Add(cb);
                cb.Width = 190;
                cb.Height = 25;
                cb.Left = 15 + j;
                cb.Top = 25 + i;
                i += 30;
                if (i == 4 * 30)
                {
                    j += 200;
                    i = 0;
                }
            }
        }

        private void chargement_famille(DataSet ds)
        {
            int i = 0;
            foreach (DataRow row in ds.Tables["Famille"].Rows)
            {
                RadioButton rb = new RadioButton();
                rb.Text = row["libFamille"].ToString();
                rb.Tag = row["codeFamille"];
                tabc_choix.TabPages[0].Controls.Add(rb);
                rb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
                rb.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
                rb.BringToFront();
                rb.Left = 26;
                rb.Top = 63+i;
                rb.Width = 230;
                if(i==0)
                {
                    rb.Checked = true;
                }
                i += 30;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une page précédente sélectionnée
            if (tabc_choix.SelectedIndex != -1)
            {
                // Récupérez le contrôle de la page précédente
                Control previousPage = tabc_choix.TabPages[tabc_choix.SelectedIndex].Controls[0];

                // Récupérez le contrôle de la nouvelle page sélectionnée
                Control newPage = tabc_choix.SelectedTab.Controls[0];

                // Configurez la transition
                Transition transition = new Transition(previousPage, newPage, transitionPanel);
                transition.TransitionCompleted += (s, args) =>
                {
                    // Supprimez la page précédente du transitionPanel
                    transitionPanel.Controls.Remove(previousPage);
                };

                // Démarrez la transition
                transition.Start();
            }
        }

        public class Transition
        {
            private readonly Control _fromControl;
            private readonly Control _toControl;
            private readonly Panel _transitionPanel;
            private readonly Timer _timer;
            private int _ticks;

            public event EventHandler TransitionCompleted;

            public Transition(Control fromControl, Control toControl, Panel transitionPanel)
            {
                _fromControl = fromControl;
                _toControl = toControl;
                _transitionPanel = transitionPanel;

                _toControl.Visible = false;
                _toControl.Parent = _transitionPanel;

                _timer = new Timer();
                _timer.Interval = 10; // Interval pour la transition (en millisecondes)
                _timer.Tick += Timer_Tick;
            }

            public void Start()
            {
                _toControl.Visible = true;
                _toControl.BringToFront();
                _transitionPanel.Controls.SetChildIndex(_toControl, 0);

                _ticks = 0;
                _timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                _ticks++;

                double progress = (double)_ticks / 50; // Durée de la transition (en nombre de ticks)
                double opacity = Math.Min(progress, 1.0);

                _fromControl.BringToFront();
                _fromControl.Visible = true;
                _fromControl.Parent = _transitionPanel;
                _fromControl.BringToFront();
                _fromControl.Refresh();
                _fromControl.Visible = false;

                _toControl.Visible = true;
                _toControl.Parent = _transitionPanel;
                _toControl.BringToFront();
                _toControl.Refresh();
                _toControl.Visible = true;
                _toControl.BringToFront();
                _toControl.Refresh();

                if (_ticks >= 50) // Durée de la transition (en nombre de ticks)
                {
                    _timer.Stop();
                    OnTransitionCompleted();
                }
            }

            protected virtual void OnTransitionCompleted()
            {
                TransitionCompleted?.Invoke(this, EventArgs.Empty);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (valeur == 0)
            {
                valeur = 1;
            }
            else if(valeur == 90)
            {
                valeur = 3;
            }
            else
            {
                valeur = 2; 
            }
            Form f = new frmRecettes(choix_ingredients,int.Parse(txtTemps.Text),choix_categories,valeur);
            f.ShowDialog();
        }

        private void lblValider_Click(object sender, EventArgs e)
        {
            if (valeur == 0)
            {
                valeur = 1;
            }
            else if (valeur == 90)
            {
                valeur = 3;
            }
            else
            {
                valeur = 2;
            }
            Form f = new frmRecettes(choix_ingredients, int.Parse(txtTemps.Text), choix_categories, valeur);
            f.ShowDialog();
        }

        private void ChildForm_Closed(object sender, EventArgs e)
        {
            // Code pour ramener la fenêtre parent à l'avant-plan
            this.BringToFront();
        }

        private void pcbFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            int max = 0;
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                lbl_famille.Text = rb.Text;
                gb_ingredients.Controls.Clear();
                foreach (DataRow row in ds.Tables["Ingrédients"].Rows)
                {
                    if (row["codeFamille"].ToString() == rb.Tag.ToString())
                    {
                        CheckBox ch = new CheckBox();
                        ch.Text = row["libIngredient"].ToString();
                        ch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ch.Tag = row["codeIngredient"];
                        ch.BringToFront();
                        ch.ForeColor = System.Drawing.Color.White;
                        gb_ingredients.Controls.Add(ch);
                        
                        ch.Left = 20+ j;
                        ch.Top = 20 + i;
                        ch.AutoSize = true;
                        i += 26;
                        if (i == 12*26)
                        {
                            j += 210;
                            i = 0;
                        }
                        if (ch.Width > max && ch.Left == 20)
                        {
                            max = ch.Width;
                        }
                        foreach(int val in choix_ingredients)
                        {
                            if (int.Parse(ch.Tag.ToString()) == val)
                            {
                                ch.Checked = true;
                            }
                        }
                        ch.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
                    }
                }
                foreach(CheckBox ch  in gb_ingredients.Controls.OfType<CheckBox>())
                {
                    if(ch.Left != 20)
                    {
                        ch.Left = max + 30;
                    }
                }    
            }
        }

        private void cb_CheckedChanged_entree(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.Checked)
            {
                choix_categories.Add(int.Parse(cb.Tag.ToString()));
            }
            else
            {
                choix_categories.Remove(int.Parse(cb.Tag.ToString()));
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                if (choix_ingredients.Count < 3)
                {
                    choix_ingredients.Add(int.Parse(cb.Tag.ToString()));
                    foreach (Label lbl in taPIngredients.Controls.OfType<Label>())
                    {
                        if(lbl.Tag != null && int.Parse(lbl.Tag.ToString()) == choix_ingredients.Count)
                        {
                            lbl.Text = cb.Text.ToString();
                        }
                    }
                    foreach (PictureBox pc in taPIngredients.Controls.OfType<PictureBox>())
                    {
                        if(pc.Tag != null && int.Parse(pc.Tag.ToString()) == choix_ingredients.Count)
                        {
                            pc.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez pas choisir plus de 3 ingrédients");
                    cb.Checked = false;
                }
            }
            else
            {
                for (int i = choix_ingredients.Count - 1; i >= 0; i--)
                {
                    if (choix_ingredients[i] == int.Parse(cb.Tag.ToString()))
                    {
                        choix_ingredients.RemoveAt(i);
                        
                        if (lbl_ing1.Text == cb.Text.ToString())
                        {
                            lbl_ing1.Text = lbl_ing2.Text;
                            lbl_ing2.Text = lbl_ing3.Text;
                            lbl_ing3.Text = String.Empty;
                            if(choix_ingredients.Count == 2)
                            {
                                pcbCroix3.Visible = false;
                            }
                            else if(choix_ingredients.Count == 1)
                            {
                                pcbCroix2.Visible = false;
                            }
                            else
                            {
                                pcbCroix1.Visible = false;
                            }   
                        }
                        else if (lbl_ing2.Text == cb.Text.ToString())
                        {
                            lbl_ing2.Text = lbl_ing3.Text;
                            lbl_ing3.Text = String.Empty;
                            if(choix_ingredients.Count == 2)
                            {
                                pcbCroix3.Visible = false;
                            }
                            else
                            {
                                pcbCroix2.Visible = false;
                            }
                        }
                        else if (lbl_ing3.Text == cb.Text.ToString())
                        {
                            lbl_ing3.Text = String.Empty;
                            pcbCroix3.Visible= false;
                        }
                    }
                }
            }
        }

        private void pcbCroix1_Click(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            choix_ingredients.RemoveAt(int.Parse(pc.Tag.ToString())-1);
            lbl_ing1.Text = lbl_ing2.Text;
            lbl_ing2.Text = lbl_ing3.Text;
            lbl_ing3.Text = String.Empty;
            if (choix_ingredients.Count == 2)
            {
                pcbCroix3.Visible = false;
            }
            else if (choix_ingredients.Count == 1)
            {
                pcbCroix2.Visible = false;
            }
            else
            {
                pcbCroix1.Visible = false;
            }
        }

        private void pcbCroix2_Click(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            choix_ingredients.RemoveAt(int.Parse(pc.Tag.ToString())-1);
            lbl_ing2.Text = lbl_ing3.Text;
            lbl_ing3.Text = String.Empty;
            if (choix_ingredients.Count == 2)
            {
                pcbCroix3.Visible = false;
            }
            else
            {
                pcbCroix2.Visible = false;
            }
        }

        private void pcbCroix3_Click(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            choix_ingredients.RemoveAt(int.Parse(pc.Tag.ToString()) - 1);
            lbl_ing3.Text = String.Empty;
            pcbCroix3.Visible = false;
        }

        private void pcbIngredients_Click(object sender, EventArgs e)
        {
            tabc_choix.SelectedIndex = 0;

            pcbIngredient.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lblIngredient.BackColor = Color.FromArgb(247, 126, 8);
            lblFiltre.BackColor = Color.FromArgb(255, 163, 26);

        }

        private void pcbFiltre_Click(object sender, EventArgs e)
        {
           tabc_choix.SelectedIndex = 1;

            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbIngredient.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lblFiltre.BackColor = Color.FromArgb(247, 126, 8);
            lblIngredient.BackColor = Color.FromArgb(255, 163, 26);

        }

        private void lblFiltre_Click(object sender, EventArgs e)
        {
            tabc_choix.SelectedIndex = 1;

            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbIngredient.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lblFiltre.BackColor = Color.FromArgb(247, 126, 8);
            lblIngredient.BackColor = Color.FromArgb(255, 163, 26);

        }

        private void lblIngredient_Click(object sender, EventArgs e)
        {
            tabc_choix.SelectedIndex = 0;

            pcbIngredient.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lblIngredient.BackColor = Color.FromArgb(247, 126, 8);
            lblFiltre.BackColor = Color.FromArgb(255, 163, 26);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.OldValue == e.NewValue)
            {
                if (45 - valeur > valeur)
                {
                    e.NewValue = 0;
                }
                else if (45 - valeur < -22)
                {
                    e.NewValue = 90;
                }
                else
                {
                    e.NewValue = 45;
                }
            }
            valeur = (int)e.NewValue;
        }
    }
}