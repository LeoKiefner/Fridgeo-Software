using Fridgeo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace What_s_in_my_fridge
{
    public partial class frmRecetteUnique : Form
    {
        public frmRecetteUnique()
        {
            InitializeComponent();
        }
        string chcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
        OleDbConnection connec = new OleDbConnection();
        int cetteRecette;
        public frmRecetteUnique(int recette)
        {
            InitializeComponent();
            cetteRecette = recette;
        }
        DataTable recette = new DataTable();
        DataTable etape = new DataTable();
        System.Drawing.Image[] etape_bd;
        BindingSource bd;
        BindingSource bd2;
        private void frmRecetteUnique_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            chcon = chcon + path + @"\\baseFrigov2023.mdb";
            connec.ConnectionString = chcon;
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM (IngrédientsRecette r INNER JOIN Ingrédients i ON r.codeIngredient = i.codeIngredient) INNER JOIN Recettes re ON re.codeRecette = r.codeRecette WHERE r.codeRecette = " + cetteRecette, connec);
            da.Fill(recette);
            
            chargement_ingredients();
            chargement_description();
            chargement_etape();
            chargement_etape_bd();

            bd = new BindingSource();
            bd2 = new BindingSource();
            bd.DataSource = etape;
            bd2.DataSource = etape_bd;
            lbl_etape_bd.DataBindings.Add("Text", bd, "texteEtape");
            pcb_etape_bd.DataBindings.Add("Image",bd2,"");
        }

        private void chargement_etape_bd()
        {
            etape_bd = new System.Drawing.Image[etape.Rows.Count]; // Créer un tableau de la taille du nombre de lignes dans la DataTable etape

            for (int i = 0; i < etape.Rows.Count; i++)
            {
                string relativePath = etape.Rows[i]["imageEtape"].ToString();
                string fullPath = Path.Combine(Application.StartupPath, "..\\..\\Resources\\", relativePath);
                System.Drawing.Image image = System.Drawing.Image.FromFile(fullPath);
                etape_bd[i] = image;
            }
        }

        private void chargement_etape()
        {
            connec.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM EtapesRecette WHERE codeRecette = " + cetteRecette, connec);
            da.Fill(etape);
            OleDbCommand command = new OleDbCommand("SELECT MAX(numEtape) FROM EtapesRecette WHERE codeRecette = " + cetteRecette, connec);
            lbl_page.Text = "1/" + command.ExecuteScalar();
            lbl_etape.Text = etape.Rows[0]["texteEtape"].ToString();
            System.Drawing.Image image;
            if (etape.Rows[0]["imageEtape"].ToString() != String.Empty)
            {
                image = System.Drawing.Image.FromFile("..\\..\\Resources\\" + etape.Rows[0]["imageEtape"]);
            }
            else
            {
                image = System.Drawing.Image.FromFile("..\\..\\Resources\\fridgeo_logo.png");
            }
            pcb_etape.Image = image;
            connec.Close();
        }

        private void chargement_description()
        {
            string prix = "";
            for (int i = 0; i < int.Parse(recette.Rows[0]["categPrix"].ToString()); i++)
            {
                prix += "€";
            }
            lbl_description.Text = recette.Rows[0]["Commentaire"].ToString();
            lblTitre.Text = recette.Rows[0]["description"].ToString();
            lbl_personnes_prix.Text = recette.Rows[0]["nbPersonnes"] + " Personnes | " + prix;

        }

        private void chargement_ingredients()
        {
            int i = 0;
            foreach (DataRow rows in recette.Rows)
            {
                Label l = new Label();
                l.Text = rows["libIngredient"].ToString() + " : " + rows["quantite"].ToString() + " " + rows["unité"].ToString();
                l.ForeColor = Color.White;
                l.Font = new System.Drawing.Font("Verdana", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Width = 240;
                l.Top = 10 + i * 28;
                l.Left = 10;
                l.Height = 20;
                gbp_ingredients.Controls.Add(l);
                l.BringToFront();
                i++;
            }
        }

        private void lbl_detaillee_Click(object sender, EventArgs e)
        {
            tcRecette.SelectedIndex = 1;

            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcb_globale.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lbl_detaillee.BackColor = Color.FromArgb(247, 126, 8);
            lbl_globale.BackColor = Color.FromArgb(255, 163, 26);
        }

        private void pcbFiltre_Click(object sender, EventArgs e)
        {
            tcRecette.SelectedIndex = 1;

            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcb_globale.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lbl_detaillee.BackColor = Color.FromArgb(247, 126, 8);
            lbl_globale.BackColor = Color.FromArgb(255, 163, 26);
        }

        private void lbl_globale_Click(object sender, EventArgs e)
        {
            tcRecette.SelectedIndex = 0;

            pcb_globale.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lbl_globale.BackColor = Color.FromArgb(247, 126, 8);
            lbl_detaillee.BackColor = Color.FromArgb(255, 163, 26);
        }

        private void pcb_globale_Click(object sender, EventArgs e)
        {
            tcRecette.SelectedIndex = 0;

            pcb_globale.ImageLocation = "..\\..\\Resources\\carreabordsemirondfonce.png";
            pcbFiltre.ImageLocation = "..\\..\\Resources\\carreabordsemirond.png";

            lbl_globale.BackColor = Color.FromArgb(247, 126, 8);
            lbl_detaillee.BackColor = Color.FromArgb(255, 163, 26);
        }

        private void lblFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GenererPDF()
        {
            string fichierSortie = Environment.CurrentDirectory + "/recette.pdf";
            // Création du document
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(fichierSortie, FileMode.Create));

            doc.Open();

            // Palette de couleurs
            BaseColor noir = new BaseColor(27, 27, 27);
            BaseColor orange = new BaseColor(255, 163, 26);
            BaseColor grisclair = new BaseColor(128, 128, 128);
            BaseColor grisfonce = new BaseColor(41, 41, 41);
            BaseColor blanc = BaseColor.WHITE;

            // Polices d'écriture
            iTextSharp.text.Font policeRecette = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 30f, iTextSharp.text.Font.BOLD, orange);
            iTextSharp.text.Font policeTitre = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, orange);
            iTextSharp.text.Font policeTexte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, iTextSharp.text.Font.BOLD, blanc);

            // Page PDF
            // Couleur de fond du pdf
            iTextSharp.text.Rectangle pageSize = doc.PageSize;
            iTextSharp.text.Image background = iTextSharp.text.Image.GetInstance(CreateBackgroundImage(pageSize.Width, pageSize.Height, new BaseColor(41, 41, 41)));
            background.ScaleToFit(pageSize.Width, pageSize.Height);
            background.SetAbsolutePosition(0, 0);
            doc.Add(background);

            // Création de paragraphes

            // Logo de fridgeo
            string cheminImage = "..\\..\\Resources\\fridgeo_logo_scaled.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(cheminImage);
            img.ScaleToFit(150, 80);
            img.Alignment = Element.ALIGN_CENTER;
            doc.Add(img);

            // Nom de la recette
            Paragraph NomRecette = new Paragraph(lblTitre.Text, policeRecette);
            NomRecette.Alignment = Element.ALIGN_LEFT;
            doc.Add(NomRecette);

            //Prix et personnes
            Paragraph InfosRecette = new Paragraph(lbl_personnes_prix.Text + "\n\n", policeTexte);
            InfosRecette.Alignment = Element.ALIGN_LEFT;
            doc.Add(InfosRecette);

            //Image de la recette
            string cheminRecette = "..\\..\\Resources\\" + recette.Rows[0]["imageDesc"].ToString();
            iTextSharp.text.Image imgrec = iTextSharp.text.Image.GetInstance(cheminRecette);
            imgrec.ScaleAbsolute(80, 80);
            imgrec.Alignment = Element.ALIGN_LEFT;
            doc.Add(imgrec);

            // Description de la recette
            Paragraph Description = new Paragraph(lbl_description.Text + "\n\n", policeTexte);
            Description.Alignment = Element.ALIGN_LEFT;
            doc.Add(Description);

            // Ingrédients de la recette
            StringBuilder ingredientsText = new StringBuilder();
            foreach (Control control in gbp_ingredients.Controls)
            {
                if (control is Label label)
                {
                    ingredientsText.AppendLine(label.Text);
                }
            }
            Paragraph TitreIngredients = new Paragraph("Ingrédients : \n\n", policeTitre);
            Paragraph Ingredients = new Paragraph(ingredientsText.ToString(), policeTexte);
            Ingredients.Alignment = Element.ALIGN_LEFT;
            doc.Add(TitreIngredients);
            doc.Add(Ingredients);

            //Espace entre les ingredients et les etapes
            Paragraph Espace = new Paragraph("\n\n");
            doc.Add(Espace);

            //Titre Etape
            Paragraph Etape = new Paragraph("Etapes : \n\n", policeTitre);
            doc.Add(Etape);

            // Création du tableau
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;

            // Définir les largeurs des colonnes
            float[] columnWidths = { 30f, 70f }; // Largeur de chaque colonne en pourcentage
            table.SetWidths(columnWidths);



            int i = 1;
            foreach (DataRow row in etape.Rows)
            {
                // Colonne de gauche : Image des étapes
                string cheminEtape = "..\\..\\Resources\\" + row["imageEtape"].ToString();
                iTextSharp.text.Image imgEtape;

                if (string.IsNullOrEmpty(row["imageEtape"].ToString()) || !File.Exists(cheminEtape))
                {
                    // Utiliser l'image par défaut si le chemin est vide ou si le fichier n'existe pas
                    cheminEtape = "..\\..\\Resources\\fridgeo_logo.png";
                }

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(cheminEtape);
                imgEtape = image;
                PdfPCell cellImage = new PdfPCell(imgEtape);
                cellImage.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cellImage.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                imgEtape.ScaleAbsolute(50, 50);
                cellImage.FixedHeight = 50;

                // Définir la couleur des bordures de la cellule de gauche
                cellImage.BorderColor = new BaseColor(255, 163, 26); // Couleur des bordures

                table.AddCell(cellImage);

                // Colonne de droite : Description des étapes
                PdfPCell cellDescription = new PdfPCell();
                cellDescription.AddElement(new Phrase("Etape " + i + " : " + row["texteEtape"].ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, new BaseColor(255, 163, 26))));
                cellDescription.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;

                // Définir la couleur des bordures de la cellule de droite
                cellDescription.BorderColor = new BaseColor(255, 163, 26); // Couleur des bordures

                table.AddCell(cellDescription);

                i++;
            }

            doc.Add(table);

            // Couleur de fond de la 2nd page du pdf
            background = iTextSharp.text.Image.GetInstance(CreateBackgroundImage(pageSize.Width, pageSize.Height, new BaseColor(41, 41, 41)));
            background.ScaleToFit(pageSize.Width, pageSize.Height);
            background.SetAbsolutePosition(0, 0);
            doc.Add(background);


            // Liste de courses
            Paragraph ListeCourses = new Paragraph("Liste de courses :\n\n", policeTitre);
            doc.Add(ListeCourses);

            // Texte des ingrédients
            string texteIngredients = ingredientsText.ToString();

            // Séparer les ingrédients par des sauts de ligne
            string[] ingredients = texteIngredients.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Créer une liste non ordonnée pour les ingrédients
            List liste = new List(List.UNORDERED);
            liste.SetListSymbol("\u2022"); // Utiliser le symbole • pour chaque élément de la liste

            // Ajouter chaque ingrédient à la liste
            foreach (string ingredient in ingredients)
            {
                liste.Add(new ListItem(ingredient, policeTexte));
            }

            // Ajouter la liste de courses au document
            doc.Add(liste);


            // Couleur de fond de la page actuelle du pdf
            background = iTextSharp.text.Image.GetInstance(CreateBackgroundImage(pageSize.Width, pageSize.Height, new BaseColor(41, 41, 41)));
            background.ScaleToFit(pageSize.Width, pageSize.Height);
            background.SetAbsolutePosition(0, 0);
            doc.Add(background);


            // Fermer le document
            doc.Close();
            Process.Start(fichierSortie);
        }

        private iTextSharp.text.Image CreateBackgroundImage(float width, float height, BaseColor color)
        {
            Bitmap bitmap = new Bitmap((int)width, (int)height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(color.R, color.G, color.B));
            }
            return iTextSharp.text.Image.GetInstance(bitmap, ImageFormat.Png);
        }

        private void lblPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salut");
            GenererPDF();
        }

        private void pcbPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salut");
            GenererPDF();
        }

        private void pcb_fleche_avancer_Click(object sender, EventArgs e)
        {
            int actuel = int.Parse(lbl_page.Text.Split('/')[0]);
            int fin = int.Parse(lbl_page.Text.Split('/')[1]);
            if (actuel < fin)
            {
                lbl_etape.Text = etape.Rows[actuel]["texteEtape"].ToString();
                lbl_page.Text = actuel + 1 + "/" + fin;
                System.Drawing.Image image;
                if (etape.Rows[actuel]["imageEtape"].ToString() != String.Empty)
                {
                    image = System.Drawing.Image.FromFile("..\\..\\Resources\\" + etape.Rows[actuel]["imageEtape"]);
                }
                else
                {
                    image = System.Drawing.Image.FromFile("..\\..\\Resources\\fridgeo_logo.png");
                }
                pcb_etape.Image = image;
            }
        }

        private void pcb_fleche_reculer_Click(object sender, EventArgs e)
        {
            
            int actuel = int.Parse(lbl_page.Text.Split('/')[0]);
            int fin = int.Parse(lbl_page.Text.Split('/')[1]);
            if (actuel > 1)
            {
                lbl_etape.Text = etape.Rows[actuel - 2]["texteEtape"].ToString();
                lbl_page.Text = actuel - 1 + "/" + fin;
                System.Drawing.Image image;
                if (etape.Rows[actuel-2]["imageEtape"].ToString() != String.Empty)
                {
                    image = System.Drawing.Image.FromFile("..\\..\\Resources\\" + etape.Rows[actuel-2]["imageEtape"]);
                }
                else
                {
                    image = System.Drawing.Image.FromFile("..\\..\\Resources\\fridgeo_logo.png");
                }
                pcb_etape.Image = image;
            }

        }

        private void lblGenerPDF_Click(object sender, EventArgs e)
        {
            GenererPDF();
        }

        private void pcbGenerPDF_Click(object sender, EventArgs e)
        {
            GenererPDF();
        }

        private void pcb_fleche_debut_Click(object sender, EventArgs e)
        {
            bd.MoveFirst();
            bd2.MoveFirst();
        }

        private void pcb_debut_etape_Click(object sender, EventArgs e)
        {
            bd.MovePrevious();
            bd2.MovePrevious();
        }

        private void pcb_fleche_suivante_Click(object sender, EventArgs e)
        {
            bd.MoveNext();
            bd2.MoveNext();
        }

        private void pcb_fleche_fin_Click(object sender, EventArgs e)
        {
            bd.MoveLast();
            bd2.MoveLast();
        }

        private void pcbNote_Click(object sender, EventArgs e)
        {
            Form f = new frmNotation(cetteRecette);
            f.ShowDialog();
        }

        private void lblNote_Click(object sender, EventArgs e)
        {
            Form f = new frmNotation(cetteRecette);
            f.ShowDialog();
        }
    }
}
