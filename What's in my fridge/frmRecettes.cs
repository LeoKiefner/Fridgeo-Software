using Fridgeo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What_s_in_my_fridge
{
    public partial class frmRecettes : Form
    {

        public frmRecettes()
        {
            InitializeComponent();
        }
        string chcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        OleDbConnection connec = new OleDbConnection();
        private int temps_max;
        private List<int> ingredients;
        private List<int> categories;
        private int echelle_prix;
        DataTable recette = new DataTable();
        List<int> recette_trier = new List<int>();

        public frmRecettes(List<int> choix_ingredients, int duree, List<int> choix_categories, int cout)
        {
            InitializeComponent();
            ingredients = choix_ingredients;
            categories = choix_categories;
            temps_max = duree;
            echelle_prix = cout;
        }

        private void frmRecettes_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            chcon = chcon + path + @"\\baseFrigov2023.mdb";
            connec.ConnectionString = chcon;
            connec.Open();
            if(ingredients.Count > 1)
            {
                for (int i = 0; i < ingredients.Count; i++)
                {
                    OleDbCommand d2 = new OleDbCommand(contruction_requette(ingredients[i]), connec);
                    recette.Load(d2.ExecuteReader());
                }
            }
            else
            {
                OleDbCommand d2 = new OleDbCommand(contruction_requette(), connec);
                recette.Load(d2.ExecuteReader());
            }
            connec.Close();
            trier();
            chargement_recette();

        }

        private void chargement_recette()
        {
            if(recette_trier.Count == 0)
            {
                Label l = new Label();
                l.BringToFront();
                gbp_recette.Controls.Add(l);
                l.Text = "Aucune recette trouvée avec les ingrédients ou les filtres sélectionnés.";
                l.Font = new System.Drawing.Font("Verdana", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.ForeColor = System.Drawing.Color.White;
                l.Width = 620;
                l.Height = 448;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                connec.Open();
                DataTable prov = new DataTable();
                for (int i = 0; i < recette_trier.Count; i++)
                {
                    OleDbCommand d = new OleDbCommand("SELECT * FROM Recettes WHERE codeRecette = " + recette_trier[i], connec);
                    prov.Load(d.ExecuteReader());
                    Random rnd = new Random();
                    UCRecette r = new UCRecette(prov.Rows[i]["description"].ToString(), int.Parse(prov.Rows[i]["tempsCuisson"].ToString()), int.Parse(prov.Rows[i]["categPrix"].ToString()), "..\\..\\Resources\\" + prov.Rows[i]["imageDesc"].ToString(), rnd.Next(1, 6), rnd.Next(20, 70), new System.EventHandler(ucRecette_Click), int.Parse(prov.Rows[i]["codeRecette"].ToString()));
                    r.Left = 5;
                    r.Top = 30 + (i % 2) * 200;
                    r.Width = 608;
                    r.Height = 189;
                    r.Tag = i;
                    if (i > 1)
                    {
                        r.Visible = false;
                    }
                    else
                    {
                        r.BringToFront();
                        r.Visible = true;
                    }
                    gbp_recette.Controls.Add(r);
                }
                lbl_page.Text = "1/" + (recette_trier.Count / 2 + recette_trier.Count % 2).ToString();
                connec.Close();
            }
        }

        private void trier()
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            foreach (DataRow row in recette.Rows)
            {
                int num = row.Field<int>(0);
                if (temp.ContainsKey(num))
                {
                    temp[num]++;
                }
                else
                {
                    temp[num] = 1;
                }
            }
            var pourliste = from entry in temp orderby entry.Value descending select entry;
            foreach (var entry in pourliste)
            {
                recette_trier.Add(entry.Key);
            }
        }

        private String contruction_requette(int ingredient)
        {
            List<String> condition = new List<String>();
            int parenthese = 0;
            String inner_temp = "Recettes r";
            String requete = "SELECT r.codeRecette FROM ";
            if(categories.Count > 0)
            {
                parenthese++;
                inner_temp += " INNER JOIN CatégoriesRecette d ON r.codeRecette = d.codeRecette)";
                String cond= "d.codeCategorie IN (";
                for (int i = 0; i < categories.Count; i++)
                {
                    cond += categories[i];
                    if (i < categories.Count - 1)
                    {
                        cond += ", ";
                    }
                }
                cond += ")";
                condition.Add(cond);
            }
            if(ingredients.Count > 0)
            {
                parenthese++;
                inner_temp += " INNER JOIN IngrédientsRecette i ON r.codeRecette = i.codeRecette)";
                String cond = "i.codeIngredient = " + ingredient;
                condition.Add(cond);
            }
            if(echelle_prix != 0)
            {
                condition.Add("r.categPrix <= " + echelle_prix);
            }
            if(temps_max != 0)
            {
                condition.Add("r.tempsCuisson <= " + temps_max);
            }

            for(int i= 0; i<parenthese;i++)
            {
                requete += "(";
            }
            requete += inner_temp;
            if(condition.Count > 0)
            {
                requete += " WHERE " + String.Join(" AND ", condition);
            }
            return requete;
        }
        private String contruction_requette()
        {
            List<String> condition = new List<String>();
            int parenthese = 0;
            String inner_temp = "Recettes r";
            String requete = "SELECT r.codeRecette FROM ";
            if (categories.Count > 0)
            {
                parenthese++;
                inner_temp += " INNER JOIN CatégoriesRecette d ON r.codeRecette = d.codeRecette)";
                String cond = "d.codeCategorie IN (";
                for (int i = 0; i < categories.Count; i++)
                {
                    cond += categories[i];
                    if (i < categories.Count - 1)
                    {
                        cond += ", ";
                    }
                }
                cond += ")";
                condition.Add(cond);
            }
            if (ingredients.Count > 0)
            {
                parenthese++;
                inner_temp += " INNER JOIN IngrédientsRecette i ON r.codeRecette = i.codeRecette)";
                String cond = "i.codeIngredient IN (";
                for (int i = 0; i < ingredients.Count; i++)
                {
                    cond += ingredients[i];
                    if (i < ingredients.Count - 1)
                    {
                        cond += ", ";
                    }
                }
                cond += ")";
                condition.Add(cond);
            }
            if (echelle_prix != 0)
            {
                condition.Add("r.categPrix <= " + echelle_prix);
            }
            if (temps_max != 0)
            {
                condition.Add("r.tempsCuisson <= " + temps_max);
            }

            for (int i = 0; i < parenthese; i++)
            {
                requete += "(";
            }
            requete += inner_temp;
            if (condition.Count > 0)
            {
                requete += " WHERE " + String.Join(" AND ", condition);
            }
            return requete;
        }

        private void lblRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_fleche_avancer_Click(object sender, EventArgs e)
        {
            int actuel = int.Parse(lbl_page.Text.Split('/')[0]);
            int maxpage = int.Parse(lbl_page.Text.Split('/')[1]);

            if(actuel < maxpage)
            {
                foreach (UCRecette r in gbp_recette.Controls.OfType<UCRecette>())
                {
                    int valeur = int.Parse(r.Tag.ToString());

                    if ((valeur >= (actuel - 1) * 2) && (valeur <= (actuel - 1) * 2 + 1))
                    {
                        r.Visible = false;
                    }
                    else if ((valeur >= (actuel - 1) * 2 + 2) && (valeur <= (actuel - 1) * 2 + 3))
                    {
                        r.Visible = true;
                    }
                }
                lbl_page.Text = actuel + 1 + "/" + lbl_page.Text.Split('/')[1];
            }
        }
        private void pcb_fleche_reculer_Click(object sender, EventArgs e)
        {
            int actuel = int.Parse(lbl_page.Text.Split('/')[0]);
            if(actuel > 1)
            {
                foreach (UCRecette r in gbp_recette.Controls.OfType<UCRecette>())
                {
                    int valeur = int.Parse((r.Tag.ToString()));
                    if ((valeur >= (actuel - 1) * 2) && (valeur <= (actuel - 1) * 2 + 1))
                    {
                        r.Visible = false;
                    }
                    else if ((valeur >= (actuel - 2) * 2) && (valeur <= (actuel - 2) * 2 + 1))
                    {
                        r.Visible = true;
                    }
                }
                lbl_page.Text = actuel - 1 + "/" + lbl_page.Text.Split('/')[1];
            }
        }

        private void ucRecette_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox r = (PictureBox)sender;
                frmRecetteUnique f = new frmRecetteUnique(int.Parse(r.Tag.ToString()));
                f.ShowDialog();
            }
            catch
            {
                Label r = (Label)sender;
                frmRecetteUnique f = new frmRecetteUnique(int.Parse(r.Tag.ToString()));
                f.ShowDialog();
            }
        }

        private void lblFermer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pcbFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
